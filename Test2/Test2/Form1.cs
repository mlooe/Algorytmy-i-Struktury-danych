namespace Test2
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
            }
        }

        private bool isGenerated = false;

        public void GenerateTab(int n)                             // generacja tablicy 
        {
            Tab = new int[n];            
            Random random = new Random(DateTime.Now.Millisecond);                          // u�ycie wbudowanej klasy Random do wygenerowania losowych liczb

            for (int i = 0; i < Tab.Length; i++)
            {
                Tab[i] = random.Next(0, 100);                      // ustawienie przedzia�u losowanych liczb <od, do>
            }

            isGenerated = true;
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
                int key = tab[i];                      //key zapisuje warto�� elementu pod indeksem i
                int j = i - 1;                         //j = indeks poprzedniego elementu w stosunku do i

                while (j >= 0 && tab[j] > key)              //je�li element tab[j] jest wi�kszy ni� key to jest przesuwany o jedno miejsce w prawo
                {
                    tab[j + 1] = tab[j];                     //przesuni�cie elementu tab[j] o miejsce w prawo
                    j--;                                     //przej�cie do poprzedniego elementu

                }
                tab[j + 1] = key;                            //wstawianie warto�ci key na odpowiedni� pozycje w posortowanej tablicy
            }
        }

        public static void CountingSort(int[] tab)
        {
            int max = tab.Max();                             //znalezenie najwi�kszego elementu w tab
            int[] tab2 = new int[max + 1];                   //tworzenie tablicy pomocniczej tab2 wielko�ci [max + 1] (ka�dy indeks tab2 odpowiada warto�ci z tab)

            for (int i = 0; i < tab.Length; i++)
            { 
                tab2[tab[i]]++;                                 //zliczenie wyst�pie� element�w
            }

            for (int i = 0, j = 0 ; i <= max; i++)
            {
                while (tab2[i] > 0)                           //budowa posortowanej tablicy, przypisuje warto�� i do pozycji tab[j]
                {
                    tab[j++] = i;
                    tab2[i]--;
                }
            }

        }

        public static int Partition(int[] tab, int low, int high)                // funkcja do QuickSort (organizacja tablicy wok� punktu pivot)
        {
            int pivot = tab[high];
            int i = low - 1;                                                    //index mniejszego elementu

            for (int j = low; j <= high; j++)                    //przechodzenie po tablicy i przesuni�cie wszystkich mniejszych element�w na lew� stron�
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

        public static void Swap(int[] tab, int i, int j)                       // funkcja do QuickSort (zamiania miejsc)
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

                QuickSort(tab, low, partIndex - 1);                            //u�ycie rekurencji do zwr�cenia mniejszych i wi�kszych lub r�wnych element�w
                QuickSort(tab, partIndex + 1, high);
            }
        }

        public static void Merge(int[] tab, int left, int middle, int right)             // funkcja do MergeSort
        {
            int n1 = middle - left + 1;                                   //znalezenie rozmiar�w podtablicy
            int n2 = right - middle;

            int[] tempL = new int[n1];                                   //stworzenie tymczasowych tablic
            int[] tempR = new int[n2];

            for (int a = 0; a < n1; a++)
            {
                tempL[a] = tab[left + a];
            }
                                                                       //przekopiowanie danych do tymczasowych tablic
            for (int b = 0; b < n2; b++)
            {
                tempR[b] = tab[middle + b + 1];
            }

            int k = left;                                          
            int i = 0;                                            //indexy
            int j = 0;

            while (i < n1 && j < n2)                                //��czenie tymczasowych tablic
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

            while (i < n1)                                        //skopiowanie pozosta�ych element�w tempL[] je�li jakie� s�
            {
                tab[k] = tempL[i];
                i++;
                k++;
            }

            while (j < n2)                                       //skopiowanie pozosta�ych element�w tempR[] je�li jakie� s�
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
                int middle = left + (right - left) / 2;                //znalezenie �rodka

                MergeSort(tab, left, middle);                          //posortowanie pierwszej i drugiej po�owy
                MergeSort(tab, middle + 1, right);


                Merge(tab, left, middle, right);                      //po��czenie ju� posortowanych po��wek ze sob�
            }
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateTab(6);
            label1.Text = String.Join(", ", Tab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isGenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }

            int[] tabClone = (int[])Tab.Clone();
            BubbleSort(tabClone);
            label1.Text = String.Join(", ", tabClone);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isGenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }
            int[] tabClone = (int[])Tab.Clone();
            InsertionSort(tabClone);
            label1.Text = String.Join(", ", tabClone);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isGenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }
            int[] tabClone = (int[])Tab.Clone();
            CountingSort(tabClone);
            label1.Text = String.Join(", ", tabClone);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isGenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }
            int[] tabClone = (int[])Tab.Clone();
            QuickSort(tabClone, 0, tabClone.Length - 1);
            label1.Text = String.Join(", ", tabClone);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isGenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }
            int[] tabClone = (int[])Tab.Clone();
            MergeSort(tabClone, 0, tabClone.Length - 1);
            label1.Text = String.Join(", ", tabClone);

        }





    }
}
