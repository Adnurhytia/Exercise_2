using System;

namespace SearchAlgorithm
{
    class Program
    {
        //Definisikan array dengan ukuran maksimum 1380
        private int[] dinda = new int[1380];

        //variable ukuran array 
        private int n;

        //get the number of elements to storein in the array
        int j;

        public void input()
        {
            while (true)
            {
                Console.WriteLine(" Masukkan Jumlah Element : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 1380)
                    break;
                else
                    Console.WriteLine("\n Array maksimum 1380 data. \n ");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Masukkan element Array");
            Console.WriteLine("----------------------");
        }
        public void mergesort(int[] dinda, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = dinda [l + i];
            for (j = 0; j < n2; ++j)
                R[j] = dinda [m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    dinda[k] = L[i];
                    i++;
                }
                else
                {
                    dinda[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                dinda[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                dinda[k] = R[j];
                j++;
                k++;
            }
        }

        // A utility function to
        // print array of size n */
        static void printArray(int[] dinda)
        {
            int n = dinda.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(dinda[i] + " ");
            Console.WriteLine();
        }
        public void insertionSort()
        {
            int n = dinda.Length;
            for (int i = 1;i < n; ++i)
            {
                int key = dinda[i];
                int j = i - 1;

                //MoveElements
                while (j >= 0 && dinda[j] > key)
                {
                    dinda[j + 1] = dinda[j];
                    j = j - 1;
                }
                dinda[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;

            Console.WriteLine("Menu option");
            Console.WriteLine("============");
            Console.WriteLine("1. Merge sort");
            Console.WriteLine("2. Insertion sort");

            pilihanmenu = Convert.ToInt32(Console.ReadLine());

        }
    }
}