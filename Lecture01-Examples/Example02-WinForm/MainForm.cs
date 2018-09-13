using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello " + nameTextBox.Text);
            messageLabel.Text = String.Format("Hello {0}", nameTextBox.Text);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            messageLabel.Text = String.Format("Hello {0}", nameTextBox.Text);
            nameTextBox.BackColor = SystemColors.Window;
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.Info;
        }
    }
}