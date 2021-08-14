using AulaIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace AulaIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Vini\AulaArquivos\icomparable\docu.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); // Necessita de um IComparable na classe Employee para funcionar
                    foreach(Employee str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
