﻿using System;
using System.Windows.Forms;

namespace UtilityTool {
    static class Program {
        // Constants
        public static string ProgramName { get; private set; } = "Utility Tool";

        // Static objects
        public static MainForm MainForm { get; private set; }
        public static Tray Tray { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();
            Tray = new Tray();

            // Event handlers
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            // Start application
            Application.Run(MainForm);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e) {
            // Make it so the icon doesnt stay when exiting the program
            Tray.TrayIcon.Visible = false;
        }

    }
}
