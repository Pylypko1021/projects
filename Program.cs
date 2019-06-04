using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequency_split
{
    class Program
    {
        static void Main(string[] args)
        {
            double frequency_start = 0;
            double frequency_end = 0;
            Console.Write("Введите начальную частоту - ");
            frequency_start = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите конечную частоту - ");
            frequency_end = Convert.ToDouble(Console.ReadLine());
            int k = 0;

            for (double i = frequency_start; i <= frequency_end; i=i+0.0125)
            {
                k++;
            }

            double[] table = new double[k+1];
            table[0] = frequency_start;
            for (int j = 1; j < table.Length; j++)
            {
                table[j] = Math.Round((table[j-1] + 0.0125),4);
            }

            StreamWriter str = new StreamWriter("C:/projects/frequency.txt");
            for (int i = 0; i < table.Length; i++)
            {
                str.WriteLine(table[i]);
            }
            str.Close();
            Console.ReadLine();
        }
    }
}
