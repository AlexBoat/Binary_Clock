namespace Binary_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime time;
        int ora, minutul, secunda, aux;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                button1.Enabled=false;
                button1_Click(sender, e);
            }
            else
            {
                button1.Enabled = true;
            }
        }

        string binary;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Empty_circle;
            pictureBox2.Image = Properties.Resources.Empty_circle;
            pictureBox3.Image = Properties.Resources.Empty_circle;
            pictureBox4.Image = Properties.Resources.Empty_circle;
            pictureBox5.Image = Properties.Resources.Empty_circle;
            pictureBox6.Image = Properties.Resources.Empty_circle;
            pictureBox7.Image = Properties.Resources.Empty_circle;
            pictureBox8.Image = Properties.Resources.Empty_circle;
            pictureBox9.Image = Properties.Resources.Empty_circle;
            pictureBox10.Image = Properties.Resources.Empty_circle;
            pictureBox11.Image = Properties.Resources.Empty_circle;
            pictureBox12.Image = Properties.Resources.Empty_circle;
            pictureBox13.Image = Properties.Resources.Empty_circle;
            pictureBox14.Image = Properties.Resources.Empty_circle;
            pictureBox15.Image = Properties.Resources.Empty_circle;
            pictureBox16.Image = Properties.Resources.Empty_circle;
            pictureBox17.Image = Properties.Resources.Empty_circle;
            pictureBox18.Image = Properties.Resources.Empty_circle;
            pictureBox19.Image = Properties.Resources.Empty_circle;
            pictureBox20.Image = Properties.Resources.Empty_circle;
            button1.Text = "Refresh";
            time = DateTime.Now;
            ora = time.Hour;
            if(ora<10)
            {
                label1.Text = "0" + Convert.ToString(ora);
            }
            else
            {
                label1.Text = Convert.ToString(ora);
            }
            minutul = time.Minute;
            if(minutul<10)
            {
                label2.Text = "0" + Convert.ToString(minutul);
            }
            else
            {
                label2.Text = Convert.ToString(minutul);
            }
            secunda = time.Second;
            if(secunda<10)
            {
                label3.Text = "0" + Convert.ToString(secunda);
            }
            else
            {
                label3.Text =Convert.ToString(secunda);
            }
            //Hh:mm:ss
            binary = Convert.ToString(ora/10, 2);
            aux = Convert.ToInt32(binary);
            if(aux%10==1)
                pictureBox1.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox2.Image = Properties.Resources.Filled_circle;
            //hH:mm:ss
            binary = Convert.ToString(ora % 10, 2);
            aux = Convert.ToInt32(binary);
            if (aux % 10 == 1)
                pictureBox3.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox4.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox5.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox6.Image = Properties.Resources.Filled_circle;
            //hh:Mm:ss
            binary = Convert.ToString(minutul / 10, 2);
            aux = Convert.ToInt32(binary);
            if (aux % 10 == 1)
                pictureBox7.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox8.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox9.Image = Properties.Resources.Filled_circle;
            //hh:mM:ss
            binary = Convert.ToString(minutul % 10, 2);
            aux = Convert.ToInt32(binary);
            if (aux % 10 == 1)
                pictureBox10.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox11.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox12.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox13.Image = Properties.Resources.Filled_circle;
            //hh:mm:Ss
            binary = Convert.ToString(secunda / 10, 2);
            aux = Convert.ToInt32(binary);
            if (aux % 10 == 1)
                pictureBox14.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox15.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox16.Image = Properties.Resources.Filled_circle;
            //hh:mm:sS
            binary = Convert.ToString(secunda % 10, 2);
            aux = Convert.ToInt32(binary);
            if (aux % 10 == 1)
                pictureBox17.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox18.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox19.Image = Properties.Resources.Filled_circle;
            aux /= 10;
            if (aux % 10 == 1)
                pictureBox20.Image = Properties.Resources.Filled_circle;
        }
    }
}
