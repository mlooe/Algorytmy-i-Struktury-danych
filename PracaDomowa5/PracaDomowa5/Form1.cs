namespace PracaDomowa5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tree t1 = new Tree();

            t1.Add(1);
            t1.Add(2);
            t1.Add(3);
            t1.Add(4);
            t1.Add(5);
            t1.Add(6);
            label1.Text = t1.ToString();

            t1.Remove(4);
            label1.Text = t1.ToString();

            t1.Remove(5);
            label1.Text = t1.ToString();
        }
    }
}