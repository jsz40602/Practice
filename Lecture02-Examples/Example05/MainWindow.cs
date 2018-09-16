using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example05
{
    public partial class MainWindow : Form
    {
        private bool hasDotDigit = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "0";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!hasDotDigit)
            {
                resultTextBox.Text += ".";
                hasDotDigit = true;
            }
        }
    }
}