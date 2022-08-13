namespace stamina
{
    public partial class Form1 : Form
    {
        string ava = "But the current kinds of shortterm grants we have here do not enable us to give the full needed support for all projects";
        
        public Form1()
        {
            InitializeComponent();
        }
        int sekunt = 0;
        int minut = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sekunt == 60)
            {
                minut++;
                sekunt = 0;
            }
            else
            {
                sekunt++;
            }

            label1.Text = "0" + minut.ToString() + ":" + sekunt.ToString();

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (startToolStripMenuItem.Text == "Start")
            {
                textBox2.Text = ava;
                timer1.Start();
                startToolStripMenuItem.Text = "Stop";
                startToolStripMenuItem.Enabled = true;
            }

            else
            {
                startToolStripMenuItem.Text = "stop";
                textBox1.Text = "Game";
                textBox2.Text = "over";
                timer1.Stop();

            }
        }

        private void bizHaqqimizdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ob = new Form2();
            this.SendToBack();
            ob.Show();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
         this.BackColor = Color.White;
         textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;

        }

        private void yelloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Blue;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.DarkGray;
        }
     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == textBox2.Text[0])
            {

                textBox1.Text += e.KeyChar;
                textBox2.Text = textBox2.Text.Substring(1);
                if (textBox1.Text.Length > 15)
                {
                    textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 15);
                }
            }
            else if (startToolStripMenuItem.Text == "Start" && e.KeyChar == ' ')//start.click
            {
                startToolStripMenuItem.Text = "Stop";
                textBox2.Text = ava;
                textBox1.Text = "";
                timer1.Start();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}