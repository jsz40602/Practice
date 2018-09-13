using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework02_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            string message = string.Format("Pokemon 001 is {0} , Type is {1} , Species is {2}", nameTextBox.Text, typeTextBox.Text, speciesTextBox.Text);
            MessageBox.Show(message);
        }
    }
}