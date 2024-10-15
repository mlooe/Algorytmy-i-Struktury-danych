namespace ProgramTest
{
    public partial class PracaDomowa2 : Form
    {
        public PracaDomowa2()
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

        private void button2_Click_1(object sender, EventArgs e)
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

            
            for(int i = 1; i < arr.Length; i++)                         //Insertion sort
            {
                int key = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                   
                }
                arr[j + 1] = key;
            }

            textBox1.Text = String.Join(", ", arr);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sJ = Microsoft.VisualBasic.Interaction.InputBox("Podaj ilosc liczb:");

            string sMin = Microsoft.VisualBasic.Interaction.InputBox("Przedzia³ od:");
            
            string sMax = Microsoft.VisualBasic.Interaction.InputBox("Przedzia³ do:");

            int j = Int32.Parse(sJ);
            int min = Int32.Parse(sMin);
            int max = Int32.Parse(sMax);

            Random rnd = new Random();
            int[] arr = new int[j];

            for(int i = 0; i < j; i++)
            {
                arr[i] = rnd.Next(min, max);
            }

            textBox1.Text= String.Join(", ", arr);

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
