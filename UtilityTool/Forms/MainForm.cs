﻿using System;
using System.Windows.Forms;

namespace UtilityTool {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            Icon = Properties.Resources.Icon;
        }

        private void MainForm_FormLoad(object sender, EventArgs e) {
            CenterToScreen();
            BringToFront();
            Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Hide();
            e.Cancel = true;
        }
    }
}
