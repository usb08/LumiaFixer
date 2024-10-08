using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumiaFixer
{
    public partial class IssuesWindow : Form
    {
        public IssuesWindow()
        {
            InitializeComponent();
        }

        private void redirectButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/usb08/LumiaFixer?tab=readme-ov-file#issues",
                UseShellExecute = true
            });
        }
    }
}
