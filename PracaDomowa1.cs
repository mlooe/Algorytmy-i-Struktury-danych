namespace ProgramTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] tabText = textBox1.Text.Split(new char[] { ',' });
            int c = 0;
            int[] arr = new int[tabText.Length];

            foreach (string number in tabText) 
            {
                int.TryParse(number, out int x);
                arr[c] = x;
                c++;
            }


            int temp = 0;
            for (int i = 0; i < arr.Length; i++)                     //Bubble sort
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            textBox1.Text = String.Join(", ", arr);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
