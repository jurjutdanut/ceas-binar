﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti ora sub forma HH:MM:SS :");
            string ora = Console.ReadLine();

            int linii = 4;
            int coloane = 6;

            int[,] m = new int[linii, coloane];


            for (int j = 0; j < coloane; j++)
            {
                int k = j;
                if (j > 1)
                    k++; // ca sa nu se ia :
                if (j > 3)
                    k++; // ca sa nu se ia :
                int nr = Convert.ToInt32(ora[k]);
                for (int i = linii - 1; i >= 0; i--)

                {
                    int r = nr % 2;
                    m[i, j] = r;
                    nr = nr / 2;
                }

            }
            Console.WriteLine("Ceasul Binar:");
            Console.WriteLine("H H M M S S");

            for (int i = 0; i < linii; i++)
            {
                for (int j = 0; j < coloane; j++)
                {
                    if ((i == 0 && j == 0) || (i == 1 && j == 0) || (i == 0 && j == 2) || (i == 0 && j == 4))
                        Console.Write("  "); // ca sa nu afisam elementele de care nu avem nevoie
                    else
                        Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
