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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getStartedButton_Click(object sender, EventArgs e)
        {
            UnbrickWindow unbrickWindow = new UnbrickWindow();
            this.Hide();
            unbrickWindow.ShowDialog();
            this.Close();
        }
    }
}
