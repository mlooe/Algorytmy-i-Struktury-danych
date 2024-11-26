namespace PracaDomowa6
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
            NodeG node1 = new NodeG(1);
            NodeG node2 = new NodeG(2);
            NodeG node3 = new NodeG(3);

            Graf graf = new Graf();


            graf.DodajSasiada(node1, node2);
            graf.DodajSasiada(node2, node3);


            label1.Text = graf.ToString();

            var visited = new List<NodeG>();
            graf.PrzejscieGraf(node1, visited);
        }
    }
}
