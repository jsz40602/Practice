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

        private String aa;
        private String m;

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

        private void plusButton_Click(object sender, EventArgs e)
        {
            m = plusButton.Text;
            aa = resultTextBox.Text;
            resultTextBox.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            Double a = Double.Parse(aa);
            Double b = Int32.Parse(resultTextBox.Text);
            Double c = 0;

            switch (m)
            {
                case "+":
                    c = a + b;
                    break;

                case "-":
                    c = a - b;
                    break;

                case "*":
                    c = a * b;
                    break;

                case "/":
                    c = a / b;
                    break;
            }
            resultTextBox.Text = c.ToString();
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            m = minusButton.Text;
            aa = resultTextBox.Text;
            resultTextBox.Text = "";
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            m = multipleButton.Text;
            aa = resultTextBox.Text;
            resultTextBox.Text = "";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            m = divideButton.Text;
            aa = resultTextBox.Text;
            resultTextBox.Text = "";
        }
    }
}