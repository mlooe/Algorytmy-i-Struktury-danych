using System.Windows.Forms;

namespace PracaDomowa3
{
    public partial class Form1 : Form
    {
        int[] tab = null;
        int[] Tab
        {
            get
            {
                return tab;
            }
            set
            {
                tab = value;
                bool isTabEmpty = tab == null || tab.Length == 0;
                button3.Enabled = !isTabEmpty;
                button4.Enabled = !isTabEmpty;
                button5.Enabled = !isTabEmpty;
            }
        }

        private bool isConverted = false;

        public Form1()
        {
            InitializeComponent();
        }


        public void generateTab(int n, int f, int t)
        {
            Tab = new int[n];
            Random random = new Random();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(f, t);
            }
            isConverted = false;
        }

        static string TabToStringTB(int[] tab, TextBox textBox)
        {
            string text = string.Join(", ", tab);
            return textBox.Text = text;
        }

        static string TabToStringLB(int[] tab, Label label)
        {
            string text = string.Join(", ", tab);
            return label.Text = text;
        }



        public void ConvertStringToArray(TextBox textbox)
        {
            string[] tabText = textbox.Text.Split(new char[] { ',' });
            int c = 0;
            int[] arr = new int[tabText.Length];

            foreach (string number in tabText)
            {
                int.TryParse(number, out int x);
                arr[c] = x;
                c++;
            }

            Tab = arr;
            isConverted = true;
        }


        static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = temp;

                    }
                }
            }

        }

        static void InsertionSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int key = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > key)
                {
                    tab[j + 1] = tab[j];
                    j = j - 1;

                }
                tab[j + 1] = key;
            }

        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;


                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);


                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            int iIndex = 0, jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    array[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                array[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }
            while (jIndex < n2)
            {
                array[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            generateTab((int)numericUpDown1.Value, 1, 100);
            textBox1.Text = TabToStringTB(tab, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConvertStringToArray(textBox1);
            MessageBox.Show("Przekonwertowano liczby na tablicê pomyœlnie!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isConverted)
            {
                MessageBox.Show("Tablica nie jest jeszcze przekonwertowana!");
                return;
            }


            int[] tabClone = (int[])Tab.Clone();
            var timer = System.Diagnostics.Stopwatch.StartNew();

            InsertionSort(tabClone);

            timer.Stop();
            label3.Text = TabToStringLB(tabClone, label3);
            label4.Text = timer.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isConverted)
            {
                MessageBox.Show("Tablica nie jest jeszcze przekonwertowana!");
                return;
            }


            int[] tabClone = (int[])Tab.Clone();
            var timer = System.Diagnostics.Stopwatch.StartNew();

            BubbleSort(tabClone);

            timer.Stop();
            label3.Text = TabToStringLB(tabClone, label3);
            label4.Text = timer.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isConverted)
            {
                MessageBox.Show("Tablica nie jest jeszcze przekonwertowana!");
                return;
            }

            int[] tabClone = (int[])Tab.Clone();
            var timer = System.Diagnostics.Stopwatch.StartNew();

            MergeSort(tabClone, 0, tabClone.Length - 1);

            timer.Stop();
            label3.Text = TabToStringLB(tabClone, label3);
            label4.Text = timer.Elapsed.TotalMilliseconds.ToString() + " ms";
        }



    }

}