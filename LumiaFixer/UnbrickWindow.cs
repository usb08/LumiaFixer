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

        private async void startRecoveryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(WDRTPath.SelectedPath) && !string.IsNullOrEmpty(EDEPath.FileName) &&
                !string.IsNullOrEmpty(EDPPath.FileName) && !string.IsNullOrEmpty(FFUPath.FileName))
            {
                consoleOutput.Text = "Starting recovery process...\n";
                consoleOutput.AppendText("If you do not immediately see any output, don't worry and just be patient.\n");
                consoleOutput.AppendText("----------------------------\n");

                string thor2Path = System.IO.Path.Combine(WDRTPath.SelectedPath, "thor2.exe");
                string edePath = $"\"{EDEPath.FileName.Trim()}\"";
                string edpPath = $"\"{EDPPath.FileName.Trim()}\"";
                string ffuPath = $"\"{FFUPath.FileName.Trim()}\"";

                string arguments = $"-mode emergency -hexfile {edePath} -edfile {edpPath} -ffufile {ffuPath}";

                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = thor2Path,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo = startInfo;

                process.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler((s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        consoleOutput.AppendText(ev.Data + Environment.NewLine);
                        consoleOutput.SelectionStart = consoleOutput.Text.Length;
                        consoleOutput.ScrollToCaret();
                    });
                });

                process.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler((s, ev) =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        consoleOutput.AppendText(ev.Data + Environment.NewLine);
                        consoleOutput.SelectionStart = consoleOutput.Text.Length;
                        consoleOutput.ScrollToCaret();
                    });
                });

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await Task.Run(() => process.WaitForExit());

                consoleOutput.AppendText("----------------------------\n");
                consoleOutput.AppendText("Recovery process completed. Check if there are any errors." + Environment.NewLine);
                consoleOutput.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Please select all files before starting the recovery process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void faqButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be implemented in the future.");
        }
    }
}
