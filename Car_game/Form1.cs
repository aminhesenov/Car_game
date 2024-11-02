namespace Car_game
{
    public partial class Form1 : Form
    {
        bool isGasOpen = false;
        bool isROpen = false;
        bool controlLeft = false;
        bool controlRight = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            isROpen = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isGasOpen)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            }


        }
        private void pictureBox4_MouseEnter_1(object sender, EventArgs e)
        {
            isROpen = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        
            if (isROpen)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            }
        }
        int l = 0;
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            l++;
            //Left
            if (l == 1 && isGasOpen==true)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 180, pictureBox1.Location.Y);
            }
            else
            {
                l = 0;
            }
        }
        int r = 0;
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            //Right
            r++;
            if (r == 1 && isGasOpen==true)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 180, pictureBox1.Location.Y);
            }
            else
            {
                r = 0;
            }
        }
        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
            isROpen = false;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
