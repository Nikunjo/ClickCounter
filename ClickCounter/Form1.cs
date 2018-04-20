using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
       

        private void timer1_Tick(object sender, EventArgs e)
        {

          


            
                int x;
                Random r = new Random();
                x = r.Next(11);

                if (x == 1)
                {
                    this.bt1.BackColor = Color.Green;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }

                else if (x == 2)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Green;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }
                //

               else if (x == 3)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Green;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }


                //
                else if (x == 4)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Green;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }

                //

                else if (x == 5)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Green;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }

            //

                else if (x == 6)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Green;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }


            //

                else if (x == 7)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Green;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;
                }

            ///

                else if (x == 8)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Green;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Red;

                   
                }


            //

                else if (x == 9)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Green;
                    this.bt10.BackColor = Color.Red;
                }



            ///

                else if (x == 10)
                {
                    this.bt1.BackColor = Color.Red;
                    this.bt2.BackColor = Color.Red;
                    this.bt3.BackColor = Color.Red;
                    this.bt4.BackColor = Color.Red;
                    this.bt5.BackColor = Color.Red;
                    this.bt6.BackColor = Color.Red;
                    this.bt7.BackColor = Color.Red;
                    this.bt8.BackColor = Color.Red;
                    this.bt9.BackColor = Color.Red;
                    this.bt10.BackColor = Color.Green;
                }

             



            }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int count;

        private void bt1_Click(object sender, EventArgs e)
        {
            if (this.bt1.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();
               
            }

            if (this.bt1.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();
               

            }

           

        }

        private void bt2_Click(object sender, EventArgs e)
        {

            if (this.bt2.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt2.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt3_Click(object sender, EventArgs e)
        {

            if (this.bt3.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt3.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt4_Click(object sender, EventArgs e)
        {

            if (this.bt4.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt4.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt5_Click(object sender, EventArgs e)
        {

            if (this.bt5.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt5.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt6_Click(object sender, EventArgs e)
        {

            if (this.bt6.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt6.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt7_Click(object sender, EventArgs e)
        {

            if (this.bt7.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt7.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt8_Click(object sender, EventArgs e)
        {

            if (this.bt8.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt8.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt9_Click(object sender, EventArgs e)
        {

            if (this.bt9.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt9.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void bt10_Click(object sender, EventArgs e)
        {

            if (this.bt10.BackColor == Color.Red)
            {
                count -= 10;
                scr.Text = count.ToString();

            }

            if (this.bt10.BackColor == Color.Green)
            {
                count += 10;
                scr.Text = count.ToString();


            }

        }

        private void playagain_Click(object sender, EventArgs e)
        {
            if (playagain.Text == "Start")
            {
                count = 0;
                scr.Text = count.ToString();


                scr.Text = 0 + "";
                playagain.Text = "Stop";
                timer1.Enabled = true;
                

                bt1.Visible = true;
                bt2.Visible = true;
                bt3.Visible = true;
                bt4.Visible = true;
                bt5.Visible = true;
                bt6.Visible = true;
                bt7.Visible = true;
                bt8.Visible = true;
                bt9.Visible = true;
                bt10.Visible = true;


            }

            else


            {

                playagain.Text = "Start";
                timer1.Enabled = false;
                bt1.Visible = false;
                bt2.Visible = false;
                bt3.Visible = false;
                bt4.Visible = false;
                bt5.Visible = false;
                bt6.Visible = false;
                bt7.Visible = false;
                bt8.Visible = false;
                bt9.Visible = false;
                bt10.Visible = false;

               
              


                
            
            }

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {

                this.WindowState = FormWindowState.Minimized;

            }

        }

        private void pb2_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        int Togmove;
        int MVX;
        int MVY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            Togmove = 1;
            MVX = e.X;
            MVY = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            Togmove = 0;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Togmove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MVX, MousePosition.Y - MVY);
            }

        }


       
      
               



            }







        }
    
