namespace ListyDwukierunkowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List lista = new List();
            lista.AddLast(1);
            lista.AddFirst(2);
            lista.RemoveFirst();
            lista.AddLast(3);
            lista.RemoveLast();
            lista.AddLast(4);
            lista.PrintAll();
        }
    }
}
