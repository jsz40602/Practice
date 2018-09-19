using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework02
{
    public partial class Form1 : Form
    {
        private Pokemon pokemon001 = new Pokemon()
        {
            No = "001",
            Name = "Bulbasaur",
            Type = "Grass,Poison",
            Species = "Seed",
            PicturePath = @"D:\台大C#\C# 程式設計基礎上課講義\練習用檔案\Pokemons\001.png"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text == "001")
            {
                noTextBox.Text = "001";
                nameTextBox.Text = pokemon001.Name;
                typeTextBox.Text = pokemon001.Type;
                speciesTextBox.Text = pokemon001.Species;
                pictureBox.Load(pokemon001.PicturePath);
            }
        }
    }
}