using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NvnNavigator.Common {
    public partial class AdViewCtrl : UserControl {
        Thread imageThread;

        private DateTime time;
        private int currentIndex;
        private AdSettings currentAdSettings;

        public AdViewCtrl() {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false; //TODO: bad practice. 
        }

        public void LoadControl() {
            if (AdSettingsContainer.IsLoaded == false) {
                AdSettingsContainer.Load();// NOTE: dont reload again and again. Because new instance created when loaded everytime
            }

            logoViewCtrl1.UpdateControl();

            imageThread = new Thread(new ThreadStart(Thread_Worker));
            imageThread.IsBackground = true;
            imageThread.Start();
        }

        public void RefreshControl() {
            time = DateTime.Now;
            currentIndex = 0;
            currentAdSettings = null;

            logoViewCtrl1.UpdateControl();
        }

        void Thread_Worker() {
            while (true) {
                try {
                    if (AdSettingsContainer.Ads.Count > 0) {
                        bool displayed = false;
                        if (currentAdSettings == null) /* Reset or just started */ {
                            currentAdSettings = AdSettingsContainer.Ads[0];
                            time = DateTime.Now;

                            DisplayAd();
                            displayed = true;
                        } else if (DateTime.Now > time.AddSeconds(currentAdSettings.DisplayInterval)) {
                            Fade();

                            currentAdSettings = AdSettingsContainer.Ads[currentIndex];
                            time = DateTime.Now;

                            DisplayAd();
                            displayed = true;
                        }

                        if (displayed) {
                            currentIndex++;
                            if (currentIndex == AdSettingsContainer.Ads.Count) {
                                currentIndex = 0; // back to first item
                            }
                        }
                    } else {
                        pbAd.Image = null;
                    }
                } catch { }

                Thread.Sleep(1000); // Interval = 1 sec
            }
        }

        private void DisplayAd() {
            string filename = Globals.SettingsResourceDir + currentAdSettings.FileName;
            pbAd.Image = ImageLoader.GetImageFromFile(filename, pbAd.Width, pbAd.Height);
        }

        private void Fade() {
            if (currentAdSettings == null) return;

            FadeImage fadeImage = new FadeImage();
            fadeImage.PictureBox = pbAd;

            switch (currentAdSettings.FadeType) {
                case FadeType.SplitRightToLeft:
                    fadeImage.SplitRightToLeft();
                    break;
                case FadeType.BottomToTop:
                    fadeImage.FadeBottomToTop();
                    break;
                case FadeType.BrightenImage:
                    fadeImage.BrightenImage();
                    break;
                case FadeType.DarkenImage:
                    fadeImage.DarkenImage();
                    break;
                case FadeType.LeftToRight:
                    fadeImage.FadeLeftToRight();
                    break;
                case FadeType.RightToLeft:
                    fadeImage.FadeRightToLeft();
                    break;
                case FadeType.TopToBottom:
                    fadeImage.FadeTopToBottom();
                    break;
            }
        }
    }
}