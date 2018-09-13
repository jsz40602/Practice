using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework03_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.Window;
            pokemonLabel.Text = string.Format("Pokemon 001 is {0} , Type is {1} , Species is {2}", nameTextBox.Text, typeTextBox.Text, speciesTextBox.Text);
        }

        private void typeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            typeTextBox.BackColor = SystemColors.Window;
            pokemonLabel.Text = string.Format("Pokemon 001 is {0} , Type is {1} , Species is {2}", nameTextBox.Text, typeTextBox.Text, speciesTextBox.Text);
        }

        private void speciesTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            speciesTextBox.BackColor = SystemColors.Window;
            pokemonLabel.Text = string.Format("Pokemon 001 is {0} , Type is {1} , Species is {2}", nameTextBox.Text, typeTextBox.Text, speciesTextBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pokemonLabel.Text = "";
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.Info;
        }

        private void typeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            typeTextBox.BackColor = SystemColors.Info;
        }

        private void speciesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            speciesTextBox.BackColor = SystemColors.Info;
        }
    }
}