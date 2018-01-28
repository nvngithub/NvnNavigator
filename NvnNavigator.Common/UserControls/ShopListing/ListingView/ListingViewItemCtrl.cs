using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NvnNavigator.Common {
    internal partial class ListingViewItemCtrl : UserControl {
        public ListingViewItemCtrl() {
            InitializeComponent();
        }

        public string ShopName {
            get { return lblShopName.Text; }
            set { lblShopName.Text = value; }
        }

        public string Description {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public string IconName {
            set {
                string iconFile = Globals.SettingsResourceDir + value;
                if (File.Exists(iconFile)) {
                    pbLogo.Image = ImageLoader.GetImageFromFile(iconFile, pbLogo.Width, pbLogo.Height);
                }
            }
        }

        public Color ShopNameColor {
            set {
                lblShopName.ForeColor = value;
            }
        }

        public Font ShopNameFont {
            set {
                lblShopName.Font = value;
            }
        }

        public Color ShopDescriptionColor {
            set {
                lblDescription.ForeColor = value;
            }
        }

        public Font ShopDescriptionFont {
            set {
                lblDescription.Font = value;
            }
        }

        public Color BackgroundColor {
            set {
                this.BackColor = value;
            }
        }

        public Size LogoSize {
            set {
                pbLogo.Size = value;
            }
        }

        public Size ShopControlSize {
            set {
                this.Size = value;
            }
        }
    }
}