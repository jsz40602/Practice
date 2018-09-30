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

        private Pokemon pokemon002 = new Pokemon()
        {
            No = "002",
            Name = "Ivysaur",
            Type = "Grass,Poison",
            Species = "Seed",
            PicturePath = @"D:\台大C#\C# 程式設計基礎上課講義\練習用檔案\Pokemons\002.png"
        };

        private Pokemon pokemon003 = new Pokemon()
        {
            No = "003",
            Name = "Venusaur",
            Type = "Grass,Poison",
            Species = "Seed",
            PicturePath = @"D:\台大C#\C# 程式設計基礎上課講義\練習用檔案\Pokemons\003.png"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int caseswitch = int.Parse(findTextBox.Text);
            switch (caseswitch)

            {
                case 1:
                    noTextBox.Text = "001";
                    nameTextBox.Text = pokemon001.Name;
                    typeTextBox.Text = pokemon001.Type;
                    speciesTextBox.Text = pokemon001.Species;
                    pictureBox.Load(pokemon001.PicturePath);
                    break;

                case 2:
                    noTextBox.Text = "002";
                    nameTextBox.Text = pokemon002.Name;
                    typeTextBox.Text = pokemon002.Type;
                    speciesTextBox.Text = pokemon002.Species;
                    pictureBox.Load(pokemon002.PicturePath);
                    break;

                case 3:
                    noTextBox.Text = "003";
                    nameTextBox.Text = pokemon003.Name;
                    typeTextBox.Text = pokemon003.Type;
                    speciesTextBox.Text = pokemon003.Species;
                    pictureBox.Load(pokemon003.PicturePath);
                    break;
            }
        }
    }
}