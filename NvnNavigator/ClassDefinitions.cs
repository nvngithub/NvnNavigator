using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NvnNavigator.Common;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace NvnNavigator {

    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            LoginForm loginForm = new LoginForm();
            loginForm.AdminUser = false;
            if (loginForm.ShowDialog() == DialogResult.OK) {
                // Show project loaded / recent file form
                RecentFilesForm recentFilesForm = new RecentFilesForm();
                if (recentFilesForm.ShowDialog() == DialogResult.OK) {
                    MainForm mainForm = new MainForm(recentFilesForm.SelectedPath);
                    Application.Run(mainForm);
                }
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            LogException((Exception)e.ExceptionObject);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            LogException(e.Exception);
        }

        private static void LogException(Exception exc) {
            //if (exc != null) {
            //    Logger.ApplicationLog(new LogMessage(exc.Message, exc));
            //    ExceptionForm exceptionForm = new ExceptionForm(exc);
            //    exceptionForm.ShowDialog();
            //}
        }
    }

    // HOW TO USE
        //   private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        bool isRemote = IOSupport.IsRemoteFile(dlg.FileName);
        //        if (isRemote)
        //        {
        //            string dirName = new DirectoryInfo(Path.GetDirectoryName(dlg.FileName)).Name;
        //            Globals.ProjectFile = Globals.LocalFolder + dirName + "\\" + Path.GetFileName(dlg.FileName);
        //            Globals.RemoteProjectFile = dlg.FileName;
        //        }
        //    }

        //    (new Sync()).Synchronize();
        //}
    public class Sync {
        public void Synchronize() {
            CopyFiles();

            SyncFolders();
        }

        private void CopyFiles() {
            string remoteDir = Path.GetDirectoryName(Globals.RemoteProjectFile);

            IOSupport.CopyFile(Globals.RemoteProjectFile, Globals.ProjectFile, true);
            IOSupport.CopyFile(remoteDir + @"\Settings\categories.xml", Globals.SettingsDir + "categories.xml", true);
        }

        private void SyncFolders() {
            string remoteDir = Path.GetDirectoryName(Globals.RemoteProjectFile);
            SyncFolder(remoteDir, Globals.LocalFolder + new DirectoryInfo(remoteDir).Name);
        }

        private void SyncFolder(string srcFolder, string destFolder) {
            IOSupport.CreateDirectory(destFolder);
            // 1. FILES
            // copy all files if does not exists or changed
            List<string> existingFiles = new List<string>();
            foreach (string srcFile in Directory.GetFiles(srcFolder)) {
                string name = Path.GetFileName(srcFile);
                string destFile = destFolder + "\\" + name;
                if (File.Exists(destFile)) {
                    // copy only if modified
                    FileInfo srcFileInfo = new FileInfo(srcFile);
                    FileInfo destFileInfo = new FileInfo(destFile);
                    if (srcFileInfo.LastWriteTime != destFileInfo.LastWriteTime) {
                        IOSupport.CopyFile(srcFile, destFile, true);
                    }

                } else {
                    // new file
                    IOSupport.CopyFile(srcFile, destFile, true);
                }

                existingFiles.Add(name);
            }
            // Delete unused files
            foreach (string destFile in Directory.GetFiles(destFolder)) {
                string name = Path.GetFileName(destFile);
                if (existingFiles.Contains(name) == false) {
                    IOSupport.DeleteFile(destFile);
                }
            }

            // 2. FOLDERS
            List<string> existingFolders = new List<string>();
            // recursively process all sub directories
            foreach (string subfolder in Directory.GetDirectories(srcFolder)) {
                string foldername = new DirectoryInfo(subfolder).Name;
                // recursive call
                SyncFolder(subfolder, destFolder + "\\" + foldername);

                existingFolders.Add(foldername);
            }
            // delete all unused folders
            foreach (string destDir in Directory.GetDirectories(destFolder)) {
                string name = new DirectoryInfo(destDir).Name;
                if (existingFolders.Contains(name) == false) {
                    IOSupport.DeleteDirectory(destDir, true);
                }
            }
        }
    }

    #region Windows Key Hook
    
    //How to use
        // globalKeyboardHook gkh = new globalKeyboardHook();
        //    private void Form1_Load(object sender, EventArgs e) {
        //    gkh.HookedKeys.Add(Keys.A);
        //    gkh.HookedKeys.Add(Keys.B);
        //    gkh.HookedKeys.Add(Keys.Escape);
        //    gkh.HookedKeys.Add(Keys.Delete);
        //    gkh.HookedKeys.Add(Keys.Tab);
        //    gkh.HookedKeys.Add(Keys.LControlKey);
        //    gkh.HookedKeys.Add(Keys.LMenu);
        //    gkh.HookedKeys.Add(Keys.LWin);
        //    gkh.HookedKeys.Add(Keys.F4);
        //    gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        //    gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        //}

        //void gkh_KeyUp(object sender, KeyEventArgs e) {
        //    e.Handled = true;
        //}

        //void gkh_KeyDown(object sender, KeyEventArgs e) {
        //    e.Handled = true;
        //}

    internal class globalKeyboardHook {
        #region Constant, Structure and Delegate Definitions
        /// <summary>
        /// defines the callback type for the hook
        /// </summary>
        public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

        public struct keyboardHookStruct {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
        #endregion

        #region Instance Variables
        /// <summary>
        /// The collections of keys to watch for
        /// </summary>
        public List<Keys> HookedKeys = new List<Keys>();
        /// <summary>
        /// Handle to the hook, need this to unhook and call the next hook
        /// </summary>
        IntPtr hhook = IntPtr.Zero;
        #endregion

        #region Events
        /// <summary>
        /// Occurs when one of the hooked keys is pressed
        /// </summary>
        public event KeyEventHandler KeyDown;
        /// <summary>
        /// Occurs when one of the hooked keys is released
        /// </summary>
        public event KeyEventHandler KeyUp;
        #endregion

        #region Constructors and Destructors
        /// <summary>
        /// Initializes a new instance of the <see cref="globalKeyboardHook"/> class and installs the keyboard hook.
        /// </summary>
        public globalKeyboardHook() {
            hook();
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the
        /// <see cref="globalKeyboardHook"/> is reclaimed by garbage collection and uninstalls the keyboard hook.
        /// </summary>
        ~globalKeyboardHook() {
            unhook();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Installs the global hook
        /// </summary>
        public void hook() {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }

        /// <summary>
        /// Uninstalls the global hook
        /// </summary>
        public void unhook() {
            UnhookWindowsHookEx(hhook);
        }

        /// <summary>
        /// The callback for the keyboard hook
        /// </summary>
        /// <param name="code">The hook code, if it isn't >= 0, the function shouldn't do anyting</param>
        /// <param name="wParam">The event type</param>
        /// <param name="lParam">The keyhook event information</param>
        /// <returns></returns>
        public int hookProc(int code, int wParam, ref keyboardHookStruct lParam) {
            if (code >= 0) {
                Keys key = (Keys)lParam.vkCode;
                if (HookedKeys.Contains(key)) {
                    KeyEventArgs kea = new KeyEventArgs(key);
                    if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && (KeyDown != null)) {
                        KeyDown(this, kea);
                    } else if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && (KeyUp != null)) {
                        KeyUp(this, kea);
                    }
                    if (kea.Handled)
                        return 1;
                }
            }
            return CallNextHookEx(hhook, code, wParam, ref lParam);
        }
        #endregion

        #region DLL imports
        /// <summary>
        /// Sets the windows hook, do the desired event, one of hInstance or threadId must be non-null
        /// </summary>
        /// <param name="idHook">The id of the event you want to hook</param>
        /// <param name="callback">The callback.</param>
        /// <param name="hInstance">The handle you want to attach the event to, can be null</param>
        /// <param name="threadId">The thread you want to attach the event to, can be null</param>
        /// <returns>a handle to the desired hook</returns>
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

        /// <summary>
        /// Unhooks the windows hook.
        /// </summary>
        /// <param name="hInstance">The hook handle that was returned from SetWindowsHookEx</param>
        /// <returns>True if successful, false otherwise</returns>
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        /// <summary>
        /// Calls the next hook.
        /// </summary>
        /// <param name="idHook">The hook id</param>
        /// <param name="nCode">The hook code</param>
        /// <param name="wParam">The wparam.</param>
        /// <param name="lParam">The lparam.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

        /// <summary>
        /// Loads the library.
        /// </summary>
        /// <param name="lpFileName">Name of the library</param>
        /// <returns>A handle to the library</returns>
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);
        #endregion
    }

    internal class WindowsTaskManagerButtons {
        private const string systemSubkey = @"Software\Microsoft\Windows\CurrentVersion\Policies\System";
        private const string explorerSubkey = @"Software\Microsoft\Windows\CurrentVersion\Policies\explorer";

        public static void EnableControls() {
            try {
                // System registry
                RegistryKey systemRegistry = Registry.CurrentUser.CreateSubKey(systemSubkey);
                if (systemRegistry != null) {
                    systemRegistry.DeleteValue("DisableTaskMgr");
                    systemRegistry.DeleteValue("DisableLockWorkstation");
                    systemRegistry.DeleteValue("DisableChangePassword");
                }

                systemRegistry.Close();

                // Explorer registry
                RegistryKey explorerRegistry = Registry.CurrentUser.CreateSubKey(explorerSubkey);
                if (explorerRegistry != null) {
                    explorerRegistry.DeleteValue("NoLogOff");
                    explorerRegistry.DeleteValue("NoClose");
                }

                explorerRegistry.Close();
            } catch {
            }
        }

        public static void DisableControls() {
            try {
                // System registry keys
                RegistryKey systemRegistry = Registry.CurrentUser.CreateSubKey(systemSubkey);
                if (systemRegistry != null) {
                    systemRegistry.SetValue("DisableTaskMgr", "1");
                    systemRegistry.SetValue("DisableLockWorkstation", "1");
                    systemRegistry.SetValue("DisableChangePassword", "1");
                }

                systemRegistry.Close();

                // Explorer registry keys
                RegistryKey explorerRegistry = Registry.CurrentUser.CreateSubKey(explorerSubkey);
                if (explorerRegistry != null) {
                    explorerRegistry.SetValue("NoLogOff", "1");
                    explorerRegistry.SetValue("NoClose", "1");
                }

                explorerRegistry.Close();
            } catch {
            }
        }
    }

    #endregion
}
