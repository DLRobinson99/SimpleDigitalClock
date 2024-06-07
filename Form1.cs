namespace SimpleDigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
            this.label2.Text = DateTime.Now.ToString("dd/MM/yyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
