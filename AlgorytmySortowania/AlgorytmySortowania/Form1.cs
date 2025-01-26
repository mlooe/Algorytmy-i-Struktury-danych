namespace AlgorytmySortowania
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
                button6.Enabled = !isTabEmpty;
                button7.Enabled = !isTabEmpty;
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


        public static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
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

        public static void InsertionSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int key = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > key)
                {
                    tab[j + 1] = tab[j];
                    j--;

                }
                tab[j + 1] = key;
            }
        }


        public static void CountingSort(int[] tab)
        {
            int max = tab.Max();
            int[] tab2 = new int[max + 1];

            for (int i = 0; i < tab.Length; i++)
            {
                tab2[tab[i]]++;
            }

            for (int i = 0, j = 0; i <= max; i++)
            {
                while (tab2[i] > 0)
                {
                    tab[j++] = i;
                    tab2[i]--;
                }
            }

        }

        public static int Partition(int[] tab, int low, int high)
        {
            int pivot = tab[high];
            int i = low - 1;

            for (int j = low; j <= high; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;
                    Swap(tab, i, j);
                }
            }
            Swap(tab, i + 1, high);
            return i + 1;
        }

        public static void Swap(int[] tab, int i, int j)
        {
            int temp = tab[i];
            tab[i] = tab[j];
            tab[j] = temp;
        }

        public static void QuickSort(int[] tab, int low, int high)
        {
            if (low < high)
            {
                int partIndex = Partition(tab, low, high);

                QuickSort(tab, low, partIndex - 1);
                QuickSort(tab, partIndex + 1, high);
            }
        }


        public static void Merge(int[] tab, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] tempL = new int[n1];
            int[] tempR = new int[n2];

            for (int a = 0; a < n1; a++)
            {
                tempL[a] = tab[left + a];
            }

            for (int b = 0; b < n2; b++)
            {
                tempR[b] = tab[middle + b + 1];
            }

            int k = left;
            int i = 0;
            int j = 0;

            while (i < n1 && j < n2)
            {
                if (tempL[i] <= tempR[j])
                {
                    tab[k] = tempL[i];
                    i++;
                }
                else
                {
                    tab[k] = tempR[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                tab[k] = tempL[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                tab[k] = tempR[j];
                j++;
                k++;
            }
        }

        public static void MergeSort(int[] tab, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(tab, left, middle);
                MergeSort(tab, middle + 1, right);


                Merge(tab, left, middle, right);
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
            MessageBox.Show("Przekonwertowano tablice pomyślnie!");
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isConverted)
            {
                MessageBox.Show("Tablica nie jest jeszcze przekonwertowana!");
                return;
            }

            int[] tabClone = (int[])Tab.Clone();
            var timer = System.Diagnostics.Stopwatch.StartNew();

            QuickSort(tabClone, 0, tabClone.Length - 1);

            timer.Stop();
            label3.Text = TabToStringLB(tabClone, label3);
            label4.Text = timer.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!isConverted)
            {
                MessageBox.Show("Tablica nie jest jeszcze przekonwertowana!");
                return;
            }

            int[] tabClone = (int[])Tab.Clone();
            var timer = System.Diagnostics.Stopwatch.StartNew();

            CountingSort(tabClone);

            timer.Stop();
            label3.Text = TabToStringLB(tabClone, label3);
            label4.Text = timer.Elapsed.TotalMilliseconds.ToString() + " ms";
        }
    }
}
