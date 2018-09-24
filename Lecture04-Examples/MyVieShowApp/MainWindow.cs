using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVieShowApp
{
    public partial class MainWindow : Form
    {
        private PictureBox[] seats;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            seats = new PictureBox[10];
            int x_init = 12;
            int y_init = 12;
            for (int count = 0; count < seats.Length; count++)
            {
                seats[count] = new PictureBox();
                seats[count].Image = Properties.Resources.seat_avail;
                int x = x_init + 90 * count;
                seats[count].Location = new Point(x, y_init);
                seats[count].Size = new System.Drawing.Size(80, 120);
                seats[count].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.Controls.Add(seats[count]);
            }
        }
    }
}