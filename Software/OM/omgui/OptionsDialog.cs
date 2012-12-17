﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OmGui
{
    public partial class OptionsDialog : Form
    {
        public OptionsDialog(string currentDefault)
        {
            InitializeComponent();

            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            textBoxDefaultFolder.Text = currentDefault;

            textBoxDefaultPlugin.Text = Properties.Settings.Default.CurrentPluginFolder;
        }

        //Properties
        public String DefaultFolderName { get; set; }
        public String DefaultPluginName { get; set; }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                DefaultFolderName = fbd.SelectedPath;
                textBoxDefaultFolder.Text = DefaultFolderName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                DefaultPluginName = fbd.SelectedPath;
                textBoxDefaultPlugin.Text = DefaultPluginName;
            }
        }
    }
}
