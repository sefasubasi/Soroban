namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int label41numb = -1, label42numb = -1, label43numb = -1, label44numb = -1, label45numb = -1, label46numb = -1, label47numb = -1, label48numb = -1, label4numb = -1, label3numb = -1, label2numb = -1, label1numb = -1, label7numb = -1, label8numb = -1, label9numb = -1, label10numb = -1, label12numb = -1, label13numb = -1, label14numb = -1, label15numb = -1, label17numb = -1, label18numb = -1, label19numb = -1, label20numb = -1, label22numb = -1, label23numb = -1, label24numb = -1, label25numb = -1, label27numb = -1, label28numb = -1, label29numb = -1, label30numb = -1, label32numb = -1, label33numb = -1, label34numb = -1, label35numb = -1, label37numb = -1, label38numb = -1, label39numb = -1, label40numb = -1;

        int toplam = 0,total =0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label5.Text = toplam.ToString();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            ++label41numb;
            if (label41numb % 2 == 0)
            {
                label41.Location = new Point(987, 80);
                toplam += 5;
            }

            else
            {
                label41.Location = new Point(987, 52);
                toplam -= 5;
            }


        }
       

        //BÝRLER
        private void label4_Click(object sender, EventArgs e)
        {


            ++label4numb;
            if (label3.Location.X == 987 && label3.Location.Y == 291)
            {
                if (label4numb % 2 == 0)
                {
                    toplam++;
                    label4.Location = new Point(987, 100);
                }

                else
                {
                    label4.Location = new Point(987, 272);
                    toplam--;
                }

            }
            else if ((label4.Location.X == 987 && label4.Location.Y == 100) && (label3.Location.X == 987 && label3.Location.Y == 120) && (label2.Location.X == 987 && label2.Location.Y == 140) && (label1.Location.X == 987 && label1.Location.Y == 160))
            {
                label4.Location = new Point(987, 271);
                label3.Location = new Point(987, 291);
                label2.Location = new Point(987, 311);
                label1.Location = new Point(987, 331);
                label4numb = -1;
                label3numb = -1;
                label2numb = -1;
                label1numb = -1;
                toplam -= 4;

            }
            else
            {
                if (label3numb != -1)
                    label3numb--;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

            ++label3numb;
            if (label4.Location.X == 987 && label4.Location.Y == 100 && (label1.Location.X == 987 && label1.Location.Y == 331) && (label2.Location.X == 987 && label2.Location.Y == 311))
            {
                if (label3numb % 2 == 0)
                {
                    label3.Location = new Point(987, 120);
                    toplam++;
                }

                else
                {
                    label3.Location = new Point(987, 291);
                    toplam--;
                }

            }
            else
            {
                if (label3numb != -1)
                    label3numb--;
            }
        }

   

        private void label2_Click_1(object sender, EventArgs e)
        {
            ++label2numb;
            if (label3.Location.X == 987 && label3.Location.Y == 120 && (label1.Location.X == 987 && label1.Location.Y == 331))
            {
                if (label2numb % 2 == 0)
                {
                    label2.Location = new Point(987, 140);
                    toplam++;
                }

                else
                {
                    label2.Location = new Point(987, 311);
                    toplam--;
                }

            }
            else
            {
                if (label2numb != -1)
                    label2numb--;
            }
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

            ++label1numb;
            if (label2.Location.X == 987 && label2.Location.Y == 140)
            {
                if (label1numb % 2 == 0)
                {
                    label1.Location = new Point(987, 160);
                    toplam++;
                }

                else
                {
                    label1.Location = new Point(987, 331);
                    toplam--;
                }

            }
            else if ((label4.Location.X == 987 && label4.Location.Y == 271) && (label3.Location.X == 987 && label3.Location.Y == 291) && (label2.Location.X == 987 && label2.Location.Y == 311) && (label1.Location.X == 987 && label1.Location.Y == 331))
            {
                label4.Location = new Point(987, 100);
                label3.Location = new Point(987, 120);
                label2.Location = new Point(987, 140);
                label1.Location = new Point(987, 160);
                label4numb = 0;
                label3numb = 0;
                label2numb = 0;
                label1numb = 0;
                toplam += 4;

            }
            else
            {
                if (label1numb != -1)
                    label1numb--;
            }
        }

        //Onlar
        private void label42_Click(object sender, EventArgs e)
        {
            ++label42numb;
            if (label42numb % 2 == 0)
            {
                label42.Location = new Point(887, 80);
                toplam += 50;
            }

            else
            {
                label42.Location = new Point(887, 52);
                toplam -= 50;
            }


        }
        private void label7_Click(object sender, EventArgs e)
        {
            ++label7numb;
            if (label8.Location.X == 887 && label8.Location.Y == 291)
            {
                if (label7numb % 2 == 0)
                {

                    label7.Location = new Point(887, 100);
                    toplam += 10;
                }

                else
                {
                    label7.Location = new Point(887, 272);
                    toplam -= 10;
                }

            }
            else if ((label7.Location.X == 887 && label7.Location.Y == 100) && (label8.Location.X == 887 && label8.Location.Y == 120) && (label9.Location.X == 887 && label9.Location.Y == 140) && (label10.Location.X == 887 && label10.Location.Y == 160))
            {
                label7.Location = new Point(887, 271);
                label8.Location = new Point(887, 291);
                label9.Location = new Point(887, 311);
                label10.Location = new Point(887, 331);
                label7numb = -1;
                label8numb = -1;
                label9numb = -1;
                label10numb = -1;
                toplam -= 40;

            }
            else
            {
                if (label7numb != -1)
                    label7numb--;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ++label8numb;
            if (label7.Location.X == 887 && label7.Location.Y == 100 && (label10.Location.X == 887 && label10.Location.Y == 331) && (label9.Location.X == 887 && label9.Location.Y == 311))
            {
                if (label8numb % 2 == 0)
                {
                    label8.Location = new Point(887, 120);
                    toplam += 10;
                }

                else
                {
                    label8.Location = new Point(887, 291);
                    toplam -= 10;
                }
            }
            else
            {
                if (label8numb != -1)
                    label8numb--;
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {
            ++label9numb;
            if (label8.Location.X == 887 && label8.Location.Y == 120 && (label10.Location.X == 887 && label10.Location.Y == 331))
            {
                if (label9numb % 2 == 0)
                {
                    label9.Location = new Point(887, 140);
                    toplam += 10;
                }

                else
                {
                    label9.Location = new Point(887, 311);
                    toplam -= 10;
                }

            }
            else
            {
                if (label9numb != -1)
                    label9numb--;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ++label10numb;
            if (label9.Location.X == 887 && label9.Location.Y == 140)
            {
                if (label10numb % 2 == 0)
                {
                    label10.Location = new Point(887, 160);
                    toplam += 10;
                }

                else
                {
                    label10.Location = new Point(887, 331);
                    toplam -= 10;
                }

            }
            else if ((label7.Location.X == 887 && label7.Location.Y == 271) && (label8.Location.X == 887 && label8.Location.Y == 291) && (label9.Location.X == 887 && label9.Location.Y == 311) && (label10.Location.X == 887 && label10.Location.Y == 331))
            {
                label7.Location = new Point(887, 100);
                label8.Location = new Point(887, 120);
                label9.Location = new Point(887, 140);
                label10.Location = new Point(887, 160);
                label7numb = 0;
                label8numb = 0;
                label9numb = 0;
                label10numb = 0;
                toplam += 40;

            }
            else
            {
                if (label10numb != -1)
                    label10numb--;
            }
        }


        //Yüzler

        private void label43_Click_1(object sender, EventArgs e)
        {
            ++label43numb;
            if (label43numb % 2 == 0)
            {
                label43.Location = new Point(788, 80);
                toplam += 500;
            }

            else
            {
                label43.Location = new Point(788, 52);
                toplam -= 500;
            }


        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            ++label12numb;
            if (label13.Location.X == 788 && label13.Location.Y == 291)
            {
                if (label12numb % 2 == 0)
                {

                    label12.Location = new Point(788, 100);
                    toplam += 100;
                }

                else
                {
                    label12.Location = new Point(788, 271);
                    toplam -= 100;
                }
            }
            else if ((label12.Location.X == 788 && label12.Location.Y == 100) && (label13.Location.X == 788 && label13.Location.Y == 120) && (label14.Location.X == 788 && label14.Location.Y == 140) && (label15.Location.X == 788 && label15.Location.Y == 160))
            {
                label12.Location = new Point(788, 271);
                label13.Location = new Point(788, 291);
                label14.Location = new Point(788, 311);
                label15.Location = new Point(788, 331);
                label12numb = -1;
                label13numb = -1;
                label14numb = -1;
                label15numb = -1;
                toplam -= 400;

            }
            else
            {
                if (label12numb != -1)
                    label12numb--;
            }
        }

        private void label13_Click_1(object sender, EventArgs e)
        {
            ++label13numb;
            if (label12.Location.X == 788 && label12.Location.Y == 100 && (label15.Location.X == 788 && label15.Location.Y == 331) && (label14.Location.X == 788 && label14.Location.Y == 311))
            {
                if (label13numb % 2 == 0)
                {
                    label13.Location = new Point(788, 120);
                    toplam += 100;
                }

                else
                {
                    label13.Location = new Point(788, 291);
                    toplam -= 100;
                }
            }
            else
            {
                if (label13numb != -1)
                    label13numb--;
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {
            ++label14numb;
            if ((label12.Location.X == 788 && label12.Location.Y == 100) && (label13.Location.X == 788 && label13.Location.Y == 120))
            {
                if (label14numb % 2 == 0)
                {
                    label14.Location = new Point(788, 140);
                    toplam += 100;
                }

                else
                {
                    label14.Location = new Point(788, 311);
                    toplam -= 100;
                }

            }
            else
            {
                if (label14numb != -1)
                    label14numb--;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ++label15numb;
            if (label14.Location.X == 788 && label14.Location.Y == 140)
            {
                if (label15numb % 2 == 0)
                {
                    label15.Location = new Point(788, 160);
                    toplam += 100;
                }

                else
                {
                    label15.Location = new Point(788, 331);
                    toplam -= 100;
                }

            }
            else if ((label12.Location.X == 788 && label12.Location.Y == 271) && (label13.Location.X == 788 && label13.Location.Y == 291) && (label14.Location.X == 788 && label14.Location.Y == 311) && (label15.Location.X == 788 && label15.Location.Y == 331))
            {
                label12.Location = new Point(788, 100);
                label13.Location = new Point(788, 120);
                label14.Location = new Point(788, 140);
                label15.Location = new Point(788, 160);
                label12numb = 0;
                label13numb = 0;
                label14numb = 0;
                label15numb = 0;
                toplam += 400;

            }
            else
            {
                if (label15numb != -1)
                    label15numb--;
            }
        }

        //Binler

        private void label44_Click(object sender, EventArgs e)
        {
            ++label44numb;
            if (label44numb % 2 == 0)
            {
                label44.Location = new Point(687, 80);
                toplam += 5000;
            }

            else
            {
                label44.Location = new Point(687, 53);
                toplam -= 5000;
            }


        }

        private void label17_Click(object sender, EventArgs e)
        {
            ++label17numb;
            if (label18.Location.X == 687 && label18.Location.Y == 291)
            {
                if (label17numb % 2 == 0)
                {

                    label17.Location = new Point(687, 100);
                    toplam += 1000;
                }

                else
                {
                    label17.Location = new Point(687, 271);
                    toplam -= 1000;
                }
            }
            else if ((label17.Location.X == 687 && label17.Location.Y == 100) && (label18.Location.X == 687 && label18.Location.Y == 120) && (label19.Location.X == 687 && label19.Location.Y == 140) && (label20.Location.X == 687 && label20.Location.Y == 160))
            {
                label17.Location = new Point(687, 271);
                label18.Location = new Point(687, 291);
                label19.Location = new Point(687, 311);
                label20.Location = new Point(687, 331);
                label17numb = -1;
                label18numb = -1;
                label19numb = -1;
                label20numb = -1;
                toplam -= 4000;

            }
            else
            {
                if (label17numb != -1)
                    label17numb--;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            ++label18numb;
            if (label17.Location.X == 687 && label17.Location.Y == 100 && (label20.Location.X == 687 && label20.Location.Y == 331) && (label19.Location.X == 687 && label19.Location.Y == 311))
            {
                if (label18numb % 2 == 0)
                {
                    label18.Location = new Point(687, 120);
                    toplam += 1000;
                }

                else
                {
                    label18.Location = new Point(687, 291);
                    toplam -= 1000;
                }
            }
            else
            {
                if (label18numb != -1)
                    label18numb--;
            }


        }

        private void label19_Click(object sender, EventArgs e)
        {
            ++label19numb;
            if ((label17.Location.X == 687 && label17.Location.Y == 100) && (label18.Location.X == 687 && label18.Location.Y == 120))
            {
                if (label19numb % 2 == 0)
                {
                    label19.Location = new Point(687, 140);
                    toplam += 1000;
                }

                else
                {
                    label19.Location = new Point(687, 311);
                    toplam -= 1000;
                }

            }
            else
            {
                if (label19numb != -1)
                    label19numb--;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            ++label20numb;
            if (label19.Location.X == 687 && label19.Location.Y == 140)
            {
                if (label20numb % 2 == 0)
                {
                    label20.Location = new Point(687, 160);
                    toplam += 1000;
                }

                else
                {
                    label20.Location = new Point(687, 331);
                    toplam -= 1000;
                }

            }
            else if ((label17.Location.X == 687 && label17.Location.Y == 271) && (label18.Location.X == 687 && label18.Location.Y == 291) && (label19.Location.X == 687 && label19.Location.Y == 311) && (label20.Location.X == 687 && label20.Location.Y == 331))
            {
                label17.Location = new Point(687, 100);
                label18.Location = new Point(687, 120);
                label19.Location = new Point(687, 140);
                label20.Location = new Point(687, 160);
                label17numb = 0;
                label18numb = 0;
                label19numb = 0;
                label20numb = 0;
                toplam += 4000;

            }
            else
            {
                if (label20numb != -1)
                    label20numb--;
            }
        }


        //onbinler

        private void label45_Click(object sender, EventArgs e)
        {
            ++label45numb;
            if (label45numb % 2 == 0)
            {
                label45.Location = new Point(588, 80);
                toplam += 50000;
            }

            else
            {
                label45.Location = new Point(588, 53);
                toplam -= 50000;
            }


        }

        private void label22_Click(object sender, EventArgs e)
        {
            ++label22numb;
            if (label23.Location.X == 588 && label23.Location.Y == 291)
            {
                if (label22numb % 2 == 0)
                {

                    label22.Location = new Point(588, 100);
                    toplam += 10000;
                }

                else
                {
                    label22.Location = new Point(588, 271);
                    toplam -= 10000;
                }
            }
            else if ((label22.Location.X == 588 && label22.Location.Y == 100) && (label23.Location.X == 588 && label23.Location.Y == 120) && (label24.Location.X == 588 && label24.Location.Y == 140) && (label25.Location.X == 588 && label25.Location.Y == 160))
            {
                label22.Location = new Point(588, 271);
                label23.Location = new Point(588, 291);
                label24.Location = new Point(588, 311);
                label25.Location = new Point(588, 331);
                label22numb = -1;
                label23numb = -1;
                label24numb = -1;
                label25numb = -1;
                toplam -= 40000;

            }
            else
            {
                if (label22numb != -1)
                    label22numb--;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            ++label23numb;
            if (label22.Location.X == 588 && label22.Location.Y == 100 && (label25.Location.X == 588 && label25.Location.Y == 331) && (label24.Location.X == 588 && label24.Location.Y == 311))
            {
                if (label23numb % 2 == 0)
                {
                    label23.Location = new Point(588, 120);
                    toplam += 10000;
                }

                else
                {
                    label23.Location = new Point(588, 291);
                    toplam -= 10000;
                }
            }
            else
            {
                if (label23numb != -1)
                    label23numb--;
            }


        }

        private void label24_Click(object sender, EventArgs e)
        {
            ++label24numb;
            if ((label22.Location.X == 588 && label22.Location.Y == 100) && (label23.Location.X == 588 && label23.Location.Y == 120))
            {
                if (label24numb % 2 == 0)
                {
                    label24.Location = new Point(588, 140);
                    toplam += 10000;
                }

                else
                {
                    label24.Location = new Point(588, 311);
                    toplam -= 10000;
                }

            }
            else
            {
                if (label24numb != -1)
                    label24numb--;
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            ++label25numb;
            if (label24.Location.X == 588 && label24.Location.Y == 140)
            {
                if (label25numb % 2 == 0)
                {
                    label25.Location = new Point(588, 160);
                    toplam += 10000;
                }

                else
                {
                    label25.Location = new Point(588, 331);
                    toplam -= 10000;
                }

            }
            else if ((label22.Location.X == 588 && label22.Location.Y == 271) && (label23.Location.X == 588 && label23.Location.Y == 291) && (label24.Location.X == 588 && label24.Location.Y == 311) && (label25.Location.X == 588 && label25.Location.Y == 331))
            {
                label22.Location = new Point(588, 100);
                label23.Location = new Point(588, 120);
                label24.Location = new Point(588, 140);
                label25.Location = new Point(588, 160);
                label22numb = 0;
                label23numb = 0;
                label24numb = 0;
                label25numb = 0;
                toplam += 40000;

            }
            else
            {
                if (label25numb != -1)
                    label25numb--;
            }
        }

        //yuzbinler

        private void label46_Click(object sender, EventArgs e)
        {
            ++label46numb;
            if (label46numb % 2 == 0)
            {
                label46.Location = new Point(487, 80);
                toplam += 500000;
            }

            else
            {
                label46.Location = new Point(487, 53);
                toplam -= 500000;
            }


        }

        private void label27_Click(object sender, EventArgs e)
        {
            ++label27numb;
            if (label28.Location.X == 487 && label28.Location.Y == 291)
            {
                if (label27numb % 2 == 0)
                {

                    label27.Location = new Point(487, 100);
                    toplam += 100000;
                }

                else
                {
                    label27.Location = new Point(487, 271);
                    toplam -= 100000;
                }
            }
            else if ((label27.Location.X == 487 && label27.Location.Y == 100) && (label28.Location.X == 487 && label28.Location.Y == 120) && (label29.Location.X == 487 && label29.Location.Y == 140) && (label30.Location.X == 487 && label30.Location.Y == 160))
            {
                label27.Location = new Point(487, 271);
                label28.Location = new Point(487, 291);
                label29.Location = new Point(487, 311);
                label30.Location = new Point(487, 331);
                label27numb = -1;
                label28numb = -1;
                label29numb = -1;
                label30numb = -1;
                toplam -= 400000;

            }
            else
            {
                if (label27numb != -1)
                    label27numb--;
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            ++label28numb;
            if (label27.Location.X == 487 && label27.Location.Y == 100 && (label30.Location.X == 487 && label30.Location.Y == 331) && (label29.Location.X == 487 && label29.Location.Y == 311))
            {
                if (label28numb % 2 == 0)
                {
                    label28.Location = new Point(487, 120);
                    toplam += 100000;
                }

                else
                {
                    label28.Location = new Point(487, 291);
                    toplam -= 100000;
                }
            }
            else
            {
                if (label28numb != -1)
                    label28numb--;
            }


        }

        private void label29_Click(object sender, EventArgs e)
        {
            ++label29numb;
            if ((label27.Location.X == 487 && label27.Location.Y == 100) && (label28.Location.X == 487 && label28.Location.Y == 120))
            {
                if (label29numb % 2 == 0)
                {
                    label29.Location = new Point(487, 140);
                    toplam += 100000;
                }

                else
                {
                    label29.Location = new Point(487, 311);
                    toplam -= 100000;
                }

            }
            else
            {
                if (label29numb != -1)
                    label29numb--;
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            ++label30numb;
            if (label29.Location.X == 487 && label29.Location.Y == 140)
            {
                if (label30numb % 2 == 0)
                {
                    label30.Location = new Point(487, 160);
                    toplam += 100000;
                }

                else
                {
                    label30.Location = new Point(487, 331);
                    toplam -= 100000;
                }

            }
            else if ((label27.Location.X == 487 && label27.Location.Y == 271) && (label28.Location.X == 487 && label28.Location.Y == 291) && (label29.Location.X == 487 && label29.Location.Y == 311) && (label30.Location.X == 487 && label30.Location.Y == 331))
            {
                label27.Location = new Point(487, 100);
                label28.Location = new Point(487, 120);
                label29.Location = new Point(487, 140);
                label30.Location = new Point(487, 160);
                label27numb = 0;
                label28numb = 0;
                label29numb = 0;
                label30numb = 0;
                toplam += 400000;

            }
            else
            {
                if (label30numb != -1)
                    label30numb--;
            }
        }


        //milyonlar

        private void label47_Click(object sender, EventArgs e)
        {
            ++label47numb;
            if (label47numb % 2 == 0)
            {
                label47.Location = new Point(387, 80);
                toplam += 5000000;
            }

            else
            {
                label47.Location = new Point(387, 53);
                toplam -= 5000000;
            }


        }

        private void label32_Click(object sender, EventArgs e)
        {
            ++label32numb;
            if (label33.Location.X == 387 && label33.Location.Y == 291)
            {
                if (label32numb % 2 == 0)
                {

                    label32.Location = new Point(387, 100);
                    toplam += 1000000;
                }

                else
                {
                    label32.Location = new Point(387, 271);
                    toplam -= 1000000;
                }
            }
            else if ((label32.Location.X == 387 && label32.Location.Y == 100) && (label33.Location.X == 387 && label33.Location.Y == 120) && (label34.Location.X == 387 && label34.Location.Y == 140) && (label35.Location.X == 387 && label35.Location.Y == 160))
            {
                label32.Location = new Point(387, 271);
                label33.Location = new Point(387, 291);
                label34.Location = new Point(387, 311);
                label35.Location = new Point(387, 331);
                label32numb = -1;
                label33numb = -1;
                label34numb = -1;
                label35numb = -1;
                toplam -= 4000000;

            }
            else
            {
                if (label32numb != -1)
                    label32numb--;
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            ++label33numb;
            if (label32.Location.X == 387 && label32.Location.Y == 100 && (label35.Location.X == 387 && label35.Location.Y == 331) && (label34.Location.X == 387 && label34.Location.Y == 311))
            {
                if (label33numb % 2 == 0)
                {
                    label33.Location = new Point(387, 120);
                    toplam += 1000000;
                }

                else
                {
                    label33.Location = new Point(387, 291);
                    toplam -= 1000000;
                }
            }
            else
            {
                if (label33numb != -1)
                    label33numb--;
            }


        }

        private void label34_Click(object sender, EventArgs e)
        {
            ++label34numb;
            if ((label32.Location.X == 387 && label32.Location.Y == 100) && (label33.Location.X == 387 && label33.Location.Y == 120))
            {
                if (label34numb % 2 == 0)
                {
                    label34.Location = new Point(387, 140);
                    toplam += 1000000;
                }

                else
                {
                    label34.Location = new Point(387, 311);
                    toplam -= 1000000;
                }

            }
            else
            {
                if (label34numb != -1)
                    label34numb--;
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            ++label35numb;
            if (label34.Location.X == 387 && label34.Location.Y == 140)
            {
                if (label35numb % 2 == 0)
                {
                    label35.Location = new Point(387, 160);
                    toplam += 1000000;
                }

                else
                {
                    label35.Location = new Point(387, 331);
                    toplam -= 1000000;
                }

            }
            else if ((label32.Location.X == 387 && label32.Location.Y == 271) && (label33.Location.X == 387 && label33.Location.Y == 291) && (label34.Location.X == 387 && label34.Location.Y == 311) && (label35.Location.X == 387 && label35.Location.Y == 331))
            {
                label32.Location = new Point(387,100);
                label33.Location = new Point(387, 120);
                label34.Location = new Point(387, 140);
                label35.Location = new Point(387, 160);
                label32numb = 0;
                label33numb = 0;
                label34numb = 0;
                label35numb = 0;
                toplam += 4000000;

            }
            else
            {
                if (label35numb != -1)
                    label35numb--;
            }
        }

        //onmilyonlar

        private void label48_Click(object sender, EventArgs e)
        {
            ++label48numb;
            if (label48numb % 2 == 0)
            {
                label48.Location = new Point(286, 80);
                toplam += 50000000;
            }

            else
            {
                label48.Location = new Point(286, 53);
                toplam -= 50000000;
            }


        }

        private void label37_Click(object sender, EventArgs e)
        {
            ++label37numb;
            if (label38.Location.X == 286 && label38.Location.Y == 291)
            {
                if (label37numb % 2 == 0)
                {

                    label37.Location = new Point(286, 100);
                    toplam += 10000000;
                }

                else
                {
                    label37.Location = new Point(286, 271);
                    toplam -= 10000000;
                }
            }
            else if ((label37.Location.X == 286 && label37.Location.Y == 100) && (label38.Location.X == 286 && label38.Location.Y == 120) && (label39.Location.X == 286 && label39.Location.Y == 140) && (label40.Location.X == 286 && label40.Location.Y == 160))
            {
                label37.Location = new Point(286, 271);
                label38.Location = new Point(286, 291);
                label39.Location = new Point(286, 311);
                label40.Location = new Point(286, 331);
                label37numb = -1;
                label38numb = -1;
                label39numb = -1;
                label40numb = -1;
                toplam -= 40000000;

            }
            else
            {
                if (label37numb != -1)
                    label37numb--;
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            ++label38numb;
            if (label37.Location.X == 286 && label37.Location.Y == 100 && (label40.Location.X == 286 && label40.Location.Y == 331) && (label39.Location.X == 286 && label39.Location.Y == 311))
            {
                if (label38numb % 2 == 0)
                {
                    label38.Location = new Point(286, 120);
                    toplam += 10000000;
                }

                else
                {
                    label38.Location = new Point(286, 291);
                    toplam -= 10000000;
                }
            }
            else
            {
                if (label38numb != -1)
                    label38numb--;
            }


        }

        private void label39_Click(object sender, EventArgs e)
        {
            ++label39numb;
            if ((label37.Location.X == 286 && label37.Location.Y == 100) && (label38.Location.X == 286 && label38.Location.Y == 120))
            {
                if (label39numb % 2 == 0)
                {
                    label39.Location = new Point(286, 140);
                    toplam += 10000000;
                }

                else
                {
                    label39.Location = new Point(286, 311);
                    toplam -= 10000000;
                }

            }
            else
            {
                if (label39numb != -1)
                    label39numb--;
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            ++label40numb;
            if (label39.Location.X == 286 && label39.Location.Y == 140)
            {
                if (label40numb % 2 == 0)
                {
                    label40.Location = new Point(286, 160);
                    toplam += 10000000;
                }

                else
                {
                    label40.Location = new Point(286, 331);
                    toplam -= 10000000;
                }

            }
            else if ((label37.Location.X == 286 && label37.Location.Y == 271) && (label38.Location.X == 286 && label38.Location.Y == 291) && (label39.Location.X == 286 && label39.Location.Y == 311) && (label40.Location.X == 286 && label40.Location.Y == 331))
            {
                label37.Location = new Point(286, 100);
                label38.Location = new Point(286, 120);
                label39.Location = new Point(286, 140);
                label40.Location = new Point(286, 160);
                label37numb = 0;
                label38numb = 0;
                label39numb = 0;
                label40numb = 0;
                toplam += 40000000;

            }
            else
            {
                if (label40numb != -1)
                    label40numb--;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(new object(), new EventArgs());
            int sayi1 = 0, sayi2 = 0;
            total = 0;
            int onmilyonlar=0,milyonlar = 0,yuzbinler=0,onbinler=0, binler = 0, yuzler = 0, onlar = 0, birler = 0;
            if (textBox1.Text == "" || textBox2.Text == "") 
                MessageBox.Show("Sayisal Deger Giriniz!");
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                    total = sayi1 + sayi2;
                else if (radioButton2.Checked)
                    total = sayi1 - sayi2;
                else if (radioButton3.Checked)
                    total = sayi1 * sayi2;
                else if (radioButton4.Checked)
                    total = sayi1 / sayi2;
                else
                    MessageBox.Show("Lütfen Seçiminizi Yapýnýz!");


                if (total > 99999999 || total<0)
                {
                    button2_Click(new object(), new EventArgs());
                    MessageBox.Show("Maksimum sonucunuz 99.999.999 olabilir!");
                }
                else
                {
                label21.Text = total.ToString();
                onmilyonlar = total / 10000000;
                total = total - (onmilyonlar * 10000000);
                milyonlar = total / 1000000;
                total = total - (milyonlar * 1000000);
                yuzbinler = total / 100000;
                total = total - (yuzbinler * 100000);
                onbinler = total / 10000;
                total = total - (onbinler * 10000);
                binler = total / 1000;
                total = total - (binler * 1000);
                yuzler = total / 100;
                total = total - (yuzler * 100);
                onlar = total / 10;
                total = total - (onlar * 10);
                birler = total;

                switch(birler)
                {
                    case 1: label4_Click(new object(), new EventArgs()); break;
                    case 2: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); break;
                    case 3: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); break;
                    case 4: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); label1_Click(new object(), new EventArgs()); break;
                    case 5: label41_Click(new object(), new EventArgs()); break;
                    case 6: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); break;
                    case 7: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); break;
                    case 8: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); break;
                    case 9: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); label1_Click(new object(), new EventArgs()); break;
                }
                switch (onlar)
                {
                    case 1: label7_Click(new object(), new EventArgs()); break;
                    case 2: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); break;
                    case 3: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); break;
                    case 4: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); label10_Click(new object(), new EventArgs()); break;
                    case 5: label42_Click(new object(), new EventArgs()); break;
                    case 6: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); break;
                    case 7: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); break;
                    case 8: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); break;
                    case 9: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); label10_Click(new object(), new EventArgs()); break;
                }
                switch (yuzler)
                {
                    case 1: label12_Click_1(new object(), new EventArgs()); break;
                    case 2: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); break;
                    case 3: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); break;
                    case 4: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); label15_Click(new object(), new EventArgs()); break;
                    case 5: label43_Click_1(new object(), new EventArgs()); break;
                    case 6: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); break;
                    case 7: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); break;
                    case 8: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); break;
                    case 9: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); label15_Click(new object(), new EventArgs()); break;
                }
                switch (binler)
                {
                    case 1: label17_Click(new object(), new EventArgs()); break;
                    case 2: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); break;
                    case 3: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); break;
                    case 4: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); label20_Click(new object(), new EventArgs()); break;
                    case 5: label44_Click(new object(), new EventArgs()); break;
                    case 6: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); break;
                    case 7: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); break;
                    case 8: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); break;
                    case 9: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); label20_Click(new object(), new EventArgs()); break;
                }
                switch (onbinler)
                {
                    case 1: label22_Click(new object(), new EventArgs()); break;
                    case 2: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); break;
                    case 3: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); break;
                    case 4: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); label25_Click(new object(), new EventArgs()); break;
                    case 5: label45_Click(new object(), new EventArgs()); break;
                    case 6: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); break;
                    case 7: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); break;
                    case 8: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); break;
                    case 9: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); label25_Click(new object(), new EventArgs()); break;
                }
                switch (yuzbinler)
                {
                    case 1: label27_Click(new object(), new EventArgs()); break;
                    case 2: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); break;
                    case 3: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); break;
                    case 4: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); label30_Click(new object(), new EventArgs()); break;
                    case 5: label46_Click(new object(), new EventArgs()); break;
                    case 6: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); break;
                    case 7: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); break;
                    case 8: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); break;
                    case 9: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); label30_Click(new object(), new EventArgs()); break;
                }
                switch (milyonlar)
                {
                    case 1: label32_Click(new object(), new EventArgs()); break;
                    case 2: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); break;
                    case 3: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); break;
                    case 4: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); label35_Click(new object(), new EventArgs()); break;
                    case 5: label47_Click(new object(), new EventArgs()); break;
                    case 6: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); break;
                    case 7: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); break;
                    case 8: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); break;
                    case 9: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); label35_Click(new object(), new EventArgs()); break;
                }
                switch (onmilyonlar)
                {
                    case 1: label37_Click(new object(), new EventArgs()); break;
                    case 2: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); break;
                    case 3: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); break;
                    case 4: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); label40_Click(new object(), new EventArgs()); break;
                    case 5: label48_Click(new object(), new EventArgs()); break;
                    case 6: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); break;
                    case 7: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); break;
                    case 8: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); break;
                    case 9: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); label40_Click(new object(), new EventArgs()); break;
                }


                button1.Visible = false;
                button2.ForeColor = Color.Red;
                label36.Text = "Sonuç Soroban Gösterimi";


            }

        }
    }
        private void button2_Click(object sender, EventArgs e)
        {
            label36.Text = "Durum";
            toplam = 0;
            total = 0;
            label21.Text = total.ToString();

            label41numb = -1;
            label42numb = -1;
            label43numb = -1;
            label44numb = -1;
            label45numb = -1;
            label46numb = -1;
            label47numb = -1;
            label48numb = -1;
            label4numb = -1;
            label3numb = -1;
            label2numb = -1;
            label1numb = -1;
            label7numb = -1;
            label8numb = -1;
            label9numb = -1;
            label10numb = -1;
            label12numb = -1;
            label13numb = -1;
            label14numb = -1;
            label15numb = -1;
            label17numb = -1;
            label18numb = -1;
            label19numb = -1;
            label20numb = -1;
            label22numb = -1;
            label23numb = -1;
            label24numb = -1;
            label25numb = -1;
            label27numb = -1;
            label28numb = -1;
            label29numb = -1;
            label30numb = -1;
            label27numb = -1;
            label28numb = -1;
            label29numb = -1;
            label30numb = -1;
            label32numb = -1;
            label33numb = -1;
            label34numb = -1;
            label35numb = -1;
            label37numb = -1;
            label38numb = -1;
            label39numb = -1;
            label40numb = -1;


            label41.Location = new Point(987, 52);
            label42.Location = new Point(887, 52);
            label43.Location = new Point(788, 52);
            label44.Location = new Point(687, 53);
            label45.Location = new Point(588, 53);
            label46.Location = new Point(487, 53);
            label47.Location = new Point(387, 53);
            label48.Location = new Point(286, 53);
            label4.Location = new Point(987, 271);
            label3.Location = new Point(987, 291);
            label2.Location = new Point(987, 311);
            label1.Location = new Point(987, 331);
            label7.Location = new Point(887, 271);
            label8.Location = new Point(887, 291);
            label9.Location = new Point(887, 311);
            label10.Location = new Point(887, 331);
            label12.Location = new Point(788, 271);
            label13.Location = new Point(788, 291);
            label14.Location = new Point(788, 311);
            label15.Location = new Point(788, 331);
            label17.Location = new Point(687, 271);
            label18.Location = new Point(687, 291);
            label19.Location = new Point(687, 311);
            label20.Location = new Point(687, 331);
            label22.Location = new Point(588, 271);
            label23.Location = new Point(588, 291);
            label24.Location = new Point(588, 311);
            label25.Location = new Point(588, 331);
            label27.Location = new Point(487, 271);
            label28.Location = new Point(487, 291);
            label29.Location = new Point(487, 311);
            label30.Location = new Point(487, 331);
            label32.Location = new Point(387, 271);
            label33.Location = new Point(387, 291);
            label34.Location = new Point(387, 311);
            label35.Location = new Point(387, 331);
            label37.Location = new Point(286, 271);
            label38.Location = new Point(286, 291);
            label39.Location = new Point(286, 311);
            label40.Location = new Point(286, 331);


            button1.Visible = true;
            button2.ForeColor = Color.SteelBlue;
            button3.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(new object(), new EventArgs());
            int sayi1 = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Sayisal Deger Giriniz!");
                label36.Text = "Durum";
            }
              
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                int onmilyonlar = 0, milyonlar = 0, yuzbinler = 0, onbinler = 0, binler = 0, yuzler = 0, onlar = 0, birler = 0;
                onmilyonlar = sayi1 / 10000000;
                sayi1 = sayi1 - (onmilyonlar * 10000000);
                milyonlar = sayi1 / 1000000;
                sayi1 = sayi1 - (milyonlar * 1000000);
                yuzbinler = sayi1 / 100000;
                sayi1 = sayi1 - (yuzbinler * 100000);
                onbinler = sayi1 / 10000;
                sayi1 = sayi1 - (onbinler * 10000);
                binler = sayi1 / 1000;
                sayi1 = sayi1 - (binler * 1000);
                yuzler = sayi1 / 100;
                sayi1 = sayi1 - (yuzler * 100);
                onlar = sayi1 / 10;
                sayi1 = sayi1 - (onlar * 10);
                birler = sayi1;
                switch (birler)
                {
                    case 1: label4_Click(new object(), new EventArgs()); break;
                    case 2: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); break;
                    case 3: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); break;
                    case 4: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); label1_Click(new object(), new EventArgs()); break;
                    case 5: label41_Click(new object(), new EventArgs()); break;
                    case 6: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); break;
                    case 7: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); break;
                    case 8: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); break;
                    case 9: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); label1_Click(new object(), new EventArgs()); break;
                }
                switch (onlar)
                {
                    case 1: label7_Click(new object(), new EventArgs()); break;
                    case 2: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); break;
                    case 3: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); break;
                    case 4: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); label10_Click(new object(), new EventArgs()); break;
                    case 5: label42_Click(new object(), new EventArgs()); break;
                    case 6: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); break;
                    case 7: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); break;
                    case 8: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); break;
                    case 9: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); label10_Click(new object(), new EventArgs()); break;
                }
                switch (yuzler)
                {
                    case 1: label12_Click_1(new object(), new EventArgs()); break;
                    case 2: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); break;
                    case 3: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); break;
                    case 4: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); label15_Click(new object(), new EventArgs()); break;
                    case 5: label43_Click_1(new object(), new EventArgs()); break;
                    case 6: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); break;
                    case 7: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); break;
                    case 8: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); break;
                    case 9: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); label15_Click(new object(), new EventArgs()); break;
                }
                switch (binler)
                {
                    case 1: label17_Click(new object(), new EventArgs()); break;
                    case 2: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); break;
                    case 3: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); break;
                    case 4: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); label20_Click(new object(), new EventArgs()); break;
                    case 5: label44_Click(new object(), new EventArgs()); break;
                    case 6: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); break;
                    case 7: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); break;
                    case 8: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); break;
                    case 9: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); label20_Click(new object(), new EventArgs()); break;
                }
                switch (onbinler)
                {
                    case 1: label22_Click(new object(), new EventArgs()); break;
                    case 2: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); break;
                    case 3: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); break;
                    case 4: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); label25_Click(new object(), new EventArgs()); break;
                    case 5: label45_Click(new object(), new EventArgs()); break;
                    case 6: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); break;
                    case 7: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); break;
                    case 8: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); break;
                    case 9: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); label25_Click(new object(), new EventArgs()); break;
                }
                switch (yuzbinler)
                {
                    case 1: label27_Click(new object(), new EventArgs()); break;
                    case 2: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); break;
                    case 3: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); break;
                    case 4: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); label30_Click(new object(), new EventArgs()); break;
                    case 5: label46_Click(new object(), new EventArgs()); break;
                    case 6: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); break;
                    case 7: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); break;
                    case 8: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); break;
                    case 9: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); label30_Click(new object(), new EventArgs()); break;
                }
                switch (milyonlar)
                {
                    case 1: label32_Click(new object(), new EventArgs()); break;
                    case 2: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); break;
                    case 3: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); break;
                    case 4: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); label35_Click(new object(), new EventArgs()); break;
                    case 5: label47_Click(new object(), new EventArgs()); break;
                    case 6: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); break;
                    case 7: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); break;
                    case 8: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); break;
                    case 9: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); label35_Click(new object(), new EventArgs()); break;
                }
                switch (onmilyonlar)
                {
                    case 1: label37_Click(new object(), new EventArgs()); break;
                    case 2: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); break;
                    case 3: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); break;
                    case 4: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); label40_Click(new object(), new EventArgs()); break;
                    case 5: label48_Click(new object(), new EventArgs()); break;
                    case 6: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); break;
                    case 7: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); break;
                    case 8: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); break;
                    case 9: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); label40_Click(new object(), new EventArgs()); break;
                }
                button3.Visible = false;
                button4.Visible = true;
                label36.Text = "1.Sayi Soroban Gösterimi";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(new object(), new EventArgs());
            button3.Visible = false;
            int sayi2 = 0;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Sayisal Deger Giriniz!");
                label36.Text = "Durum";
            }
                
            else
            {
                sayi2 = Convert.ToInt32(textBox2.Text);
                int onmilyonlar = 0, milyonlar = 0, yuzbinler = 0, onbinler = 0, binler = 0, yuzler = 0, onlar = 0, birler = 0;
                onmilyonlar = sayi2 / 10000000;
                sayi2 = sayi2 - (onmilyonlar * 10000000);
                milyonlar = sayi2 / 1000000;
                sayi2 = sayi2 - (milyonlar * 1000000);
                yuzbinler = sayi2 / 100000;
                sayi2 = sayi2 - (yuzbinler * 100000);
                onbinler = sayi2 / 10000;
                sayi2 = sayi2 - (onbinler * 10000);
                binler = sayi2 / 1000;
                sayi2 = sayi2 - (binler * 1000);
                yuzler = sayi2 / 100;
                sayi2 = sayi2 - (yuzler * 100);
                onlar = sayi2 / 10;
                sayi2 = sayi2 - (onlar * 10);
                birler = sayi2;
                switch (birler)
                {
                    case 1: label4_Click(new object(), new EventArgs()); break;
                    case 2: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); break;
                    case 3: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); break;
                    case 4: label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); label1_Click(new object(), new EventArgs()); break;
                    case 5: label41_Click(new object(), new EventArgs()); break;
                    case 6: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); break;
                    case 7: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); break;
                    case 8: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); break;
                    case 9: label41_Click(new object(), new EventArgs()); label4_Click(new object(), new EventArgs()); label3_Click(new object(), new EventArgs()); label2_Click_1(new object(), new EventArgs()); label1_Click(new object(), new EventArgs()); break;
                }
                switch (onlar)
                {
                    case 1: label7_Click(new object(), new EventArgs()); break;
                    case 2: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); break;
                    case 3: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); break;
                    case 4: label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); label10_Click(new object(), new EventArgs()); break;
                    case 5: label42_Click(new object(), new EventArgs()); break;
                    case 6: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); break;
                    case 7: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); break;
                    case 8: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); break;
                    case 9: label42_Click(new object(), new EventArgs()); label7_Click(new object(), new EventArgs()); label8_Click(new object(), new EventArgs()); label9_Click(new object(), new EventArgs()); label10_Click(new object(), new EventArgs()); break;
                }
                switch (yuzler)
                {
                    case 1: label12_Click_1(new object(), new EventArgs()); break;
                    case 2: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); break;
                    case 3: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); break;
                    case 4: label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); label15_Click(new object(), new EventArgs()); break;
                    case 5: label43_Click_1(new object(), new EventArgs()); break;
                    case 6: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); break;
                    case 7: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); break;
                    case 8: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); break;
                    case 9: label43_Click_1(new object(), new EventArgs()); label12_Click_1(new object(), new EventArgs()); label13_Click_1(new object(), new EventArgs()); label14_Click(new object(), new EventArgs()); label15_Click(new object(), new EventArgs()); break;
                }
                switch (binler)
                {
                    case 1: label17_Click(new object(), new EventArgs()); break;
                    case 2: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); break;
                    case 3: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); break;
                    case 4: label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); label20_Click(new object(), new EventArgs()); break;
                    case 5: label44_Click(new object(), new EventArgs()); break;
                    case 6: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); break;
                    case 7: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); break;
                    case 8: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); break;
                    case 9: label44_Click(new object(), new EventArgs()); label17_Click(new object(), new EventArgs()); label18_Click(new object(), new EventArgs()); label19_Click(new object(), new EventArgs()); label20_Click(new object(), new EventArgs()); break;
                }
                switch (onbinler)
                {
                    case 1: label22_Click(new object(), new EventArgs()); break;
                    case 2: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); break;
                    case 3: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); break;
                    case 4: label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); label25_Click(new object(), new EventArgs()); break;
                    case 5: label45_Click(new object(), new EventArgs()); break;
                    case 6: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); break;
                    case 7: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); break;
                    case 8: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); break;
                    case 9: label45_Click(new object(), new EventArgs()); label22_Click(new object(), new EventArgs()); label23_Click(new object(), new EventArgs()); label24_Click(new object(), new EventArgs()); label25_Click(new object(), new EventArgs()); break;
                }
                switch (yuzbinler)
                {
                    case 1: label27_Click(new object(), new EventArgs()); break;
                    case 2: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); break;
                    case 3: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); break;
                    case 4: label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); label30_Click(new object(), new EventArgs()); break;
                    case 5: label46_Click(new object(), new EventArgs()); break;
                    case 6: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); break;
                    case 7: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); break;
                    case 8: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); break;
                    case 9: label46_Click(new object(), new EventArgs()); label27_Click(new object(), new EventArgs()); label28_Click(new object(), new EventArgs()); label29_Click(new object(), new EventArgs()); label30_Click(new object(), new EventArgs()); break;
                }
                switch (milyonlar)
                {
                    case 1: label32_Click(new object(), new EventArgs()); break;
                    case 2: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); break;
                    case 3: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); break;
                    case 4: label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); label35_Click(new object(), new EventArgs()); break;
                    case 5: label47_Click(new object(), new EventArgs()); break;
                    case 6: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); break;
                    case 7: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); break;
                    case 8: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); break;
                    case 9: label47_Click(new object(), new EventArgs()); label32_Click(new object(), new EventArgs()); label33_Click(new object(), new EventArgs()); label34_Click(new object(), new EventArgs()); label35_Click(new object(), new EventArgs()); break;
                }
                switch (onmilyonlar)
                {
                    case 1: label37_Click(new object(), new EventArgs()); break;
                    case 2: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); break;
                    case 3: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); break;
                    case 4: label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); label40_Click(new object(), new EventArgs()); break;
                    case 5: label48_Click(new object(), new EventArgs()); break;
                    case 6: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); break;
                    case 7: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); break;
                    case 8: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); break;
                    case 9: label48_Click(new object(), new EventArgs()); label37_Click(new object(), new EventArgs()); label38_Click(new object(), new EventArgs()); label39_Click(new object(), new EventArgs()); label40_Click(new object(), new EventArgs()); break;
                }
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
                label36.Text = "2.Sayi Soroban Gösterimi";
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            textBox1.MaxLength = 9;
            textBox2.MaxLength = 9;
        }
    }
}