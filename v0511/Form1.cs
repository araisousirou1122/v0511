namespace v0511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("‚±‚ñ‚É‚¿‚ÍŽ€‚Ë");
            button1.Text = "ˆê”Ô‚¢‚¢‚Ì‚ð—Š‚Þ";
            button1.Left = 0;
            button1.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
        }
    }
}