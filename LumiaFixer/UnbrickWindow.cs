using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumiaFixer
{
    public partial class UnbrickWindow : Form
    {
        FolderBrowserDialog WDRTPath = new FolderBrowserDialog();
        OpenFileDialog FFUPath = new OpenFileDialog();
        OpenFileDialog EDEPath = new OpenFileDialog();
        OpenFileDialog EDPPath = new OpenFileDialog();
        public UnbrickWindow()
        {
            InitializeComponent();
        }

        private void UnbrickWindow_Load(object sender, EventArgs e)
        {

        }

        private void openWDRTButton_Click(object sender, EventArgs e)
        {
            WDRTPath.ShowDialog();
            if (WDRTPath.SelectedPath != "")
            {
                if (System.IO.File.Exists(WDRTPath.SelectedPath + "\\thor2.exe"))
                {
                    WDRTPathLabel.Text = WDRTPath.SelectedPath;
                }
                else
                {
                    MessageBox.Show("The selected folder does not contain thor2.exe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openEDEButton_Click(object sender, EventArgs e)
        {
            EDEPath.Title = "Select the EDE file";
            EDEPath.Filter = "EDE Files|*.ede";
            EDEPath.ShowDialog();
            if (EDEPath.FileName != "")
            {
                if (System.IO.Path.GetExtension(EDEPath.FileName) == ".ede")
                {
                    EDEPathLabel.Text = EDEPath.FileName;
                }
                else
                {
                    MessageBox.Show("The selected file is not an EDE file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openEDPButton_Click(object sender, EventArgs e)
        {
            EDPPath.Title = "Select the EDP file";
            EDPPath.Filter = "EDP Files|*.edp";
            EDPPath.ShowDialog();
            if (EDPPath.FileName != "")
            {
                if (System.IO.Path.GetExtension(EDPPath.FileName) == ".edp")
                {
                    EDPPathLabel.Text = EDPPath.FileName;
                }
                else
                {
                    MessageBox.Show("The selected file is not an EDP file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openFFUButton_Click(object sender, EventArgs e)
        {
            FFUPath.Title = "Select the FFU file";
            FFUPath.Filter = "FFU Files|*.ffu";
            FFUPath.ShowDialog();
            if (FFUPath.FileName != "")
            {
                if (System.IO.Path.GetExtension(FFUPath.FileName) == ".ffu")
                {
                    FFUPathLabel.Text = FFUPath.FileName;
                }
                else
                {
                    MessageBox.Show("The selected file is not an FFU file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
