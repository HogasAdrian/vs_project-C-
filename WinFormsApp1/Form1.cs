namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            label1.Hide();
            // MessageBox.Show("S-a introdus " + numberTextBox.Text);
            int result = 0;
            bool isNumber = Int32.TryParse(textBox1.Text, out result);
            if (isNumber)
            {
                bool isPrime = true;
                for (int i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
            else
            {
                pictureBox1.Show();
                pictureBox2.Show();
                label1.Show();
                BackColor = Color.DarkRed;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
        