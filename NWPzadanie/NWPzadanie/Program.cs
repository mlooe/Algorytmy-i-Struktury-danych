namespace Program
{
    internal class Program
    {
        public static string NWP(string s1, string s2, int m, int n)
        {

            if(m==0 || n == 0)
            {
                return "";
            }

            if (s1[m-1] == s2[n - 1])
            {
                return NWP(s1, s2, m - 1, n - 1) + s1[m - 1];
            }

            else
            {
                string p1 = NWP(s1, s2, m, n - 1);
                string p2 = NWP(s1, s2, m - 1, n);

                if(p1.Length > p2.Length)
                {
                    return p1;
                }
                else
                {
                    return p2;
                }
            }
        }
        
        public static void Main(string[] args)
        {
            string s1 = "POLITECHNIKA";
            string s2 = "TOALETA";

            int m = s1.Length;
            int n = s2.Length;

            Console.WriteLine("Najdłuższy wspólny podciąg: " + NWP(s1, s2, m , n));
        }

    }
}