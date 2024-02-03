namespace سبحه
{
    public partial class Form1 : Form
    {
        int i = 0;

        int k = 0;
        int h = 0;
        int all = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = i + 1;
            label1.Text = i.ToString();
            all = all + 1;
            label4.Text = all.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            k = k + 1;
            label2.Text = k.ToString();
            all = all + 1;
            label4.Text = all.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            h = h + 1;
            label3.Text=h.ToString();
            all = all + 1;

            label4.Text=all.ToString();
            


        }
    }
}