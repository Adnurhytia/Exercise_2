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
        int i;

        public void input()
        {
            while(true)
            {
                Console.WriteLine(" Masukkan Jumlah Element : ");
                string s =Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 1380)
                    break;
                else
                    Console.WriteLine("\n Array maksimum 1380 data. \n ");
            }
        }
    }
}