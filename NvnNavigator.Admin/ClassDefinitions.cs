using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Admin {

    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            LoginForm loginForm = new LoginForm();
            loginForm.AdminUser = true;
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
            if (exc != null) {
                ExceptionForm exceptionForm = new ExceptionForm(exc);
                exceptionForm.ShowDialog();
            }
        }
    }
}
