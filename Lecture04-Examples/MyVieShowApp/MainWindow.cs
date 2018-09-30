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
        private Random random;
        private bool[] seatAvail;
        private int numberOfRow = 6;
        private int start = 0;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            seats = new PictureBox[20];
            seatAvail = new bool[20];
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            int x_init = 12;
            int y_init = 12;

            for (int count = 0; count < seats.Length; count++)
            {
                int randomNumber = random.Next(1, 7);
                int row = count / numberOfRow;
                int col = count % numberOfRow;

                seats[count] = new PictureBox();
                //if (randomNumber > 2)
                //{
                //    seats[count].Image = Properties.Resources.seat_avail;
                //    seatAvail[count] = true;
                //}
                //else
                //{
                //    seats[count].Image = Properties.Resources.seat_unavail;
                //    seatAvail[count] = false;
                //}

                seats[count].Image =
                    randomNumber > 2 ?
                    Properties.Resources.seat_avail :
                    Properties.Resources.seat_unavail;
                seatAvail[count] = randomNumber > 2;

                int x = x_init + 90 * col;
                int y = y_init + 130 * row;
                seats[count].Location = new Point(x, y);
                seats[count].Size = new System.Drawing.Size(80, 120);
                seats[count].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                seats[count].Click += new System.EventHandler(this.pictureBox1_Click);
                this.Controls.Add(seats[count]);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int numberOfPeople = selectNumberComboBox.SelectedIndex + 1;
            // MessageBox.Show(numberOfPeople.ToString());
            if (numberOfPeople == 0)
            {
                MessageBox.Show("請選擇張數");
            }
            else
            {
                for (int number = start; number <= seatAvail.Length - numberOfPeople; number++)
                {
                    if (!seatAvail[number])  //如果不能買 下面程式跳過
                        continue;

                    int row = number / numberOfRow;
                    int col = number % numberOfRow;
                    int finded = 1;

                    for (int next = number + 1; next < number + numberOfPeople; next++) //找連號的第一組
                    {
                        if (seatAvail[next] && next / numberOfRow == row) //使否連號 && 同一排
                            finded++;
                        else
                            break;
                    }

                    if (finded == numberOfPeople) //找到的連號第一組換成選擇圖
                    {
                        string receipt = "你的座位是:\n";
                        for (int index = number; index < number + numberOfPeople; index++)
                        {
                            seats[index].Image = Properties.Resources.seat_select;
                            receipt += string.Format("第{0}排{1}號\n", index / numberOfRow + 1, index % numberOfRow + 1);
                        }
                        receiptRichTextBox.Text = receipt;
                        start = number + 1;
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox seat = sender as PictureBox;

            if (seat.Image == Properties.Resources.seat_select)

                seat.Image = Properties.Resources.seat_avail;
            else
                seat.Image = Properties.Resources.seat_select;
        }
    }
}