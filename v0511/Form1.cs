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
            //MessageBox.Show("����ɂ��͎���");
            button1.Text = "��Ԃ����̂𗊂�";
            button1.Left = 0;
            button1.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
        }
    }
}