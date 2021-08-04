using System;
using System.Collections.Generic;
using System.IO;
public class Test
{
    public static void Main()
    {
        // foreach (string line in File.ReadLines(@"input.txt"))
        // {
        //     Console.WriteLine(line);
        // }

        string[] vet = Console.ReadLine().Split(" ");

        int x = int.Parse(vet[0]);
        int y = int.Parse(vet[1]);

        for (int i = 1; i <= y; i++)
        {
            Console.Write(i);
            if (i % x == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}