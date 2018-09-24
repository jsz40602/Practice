using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VieShowApp
{
    public partial class MainForm : Form
    {
        private PictureBox[] seats; //class裡加入seats的矩陣

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int seat_x = 5;
            int seat_y = 3;
            seats = new PictureBox[seat_x * seat_y]; //做出seat_x*seat_y個PictureBox陣列
            int x_init = 10;
            int y_init = 10;
            for (int count_y = 0; count_y < seat_y; count_y++)
            {
                for (int count_x = 0; count_x < seat_x; count_x++)
                {
                    int count = count_x + count_y * seat_x; //第幾個位置
                    seats[count] = new PictureBox(); //建立PictureBox物件
                    int x = x_init + count_x * 90;
                    int y = y_init + count_y * 130;
                    seats[count].Image = Properties.Resources.seat_avail;
                    seats[count].Location = new Point(x, y);
                    seats[count].Size = new Size(80, 120);
                    seats[count].SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(seats[count]); //加入這物件到MainForm裡
                }
            }
        }
    }
}