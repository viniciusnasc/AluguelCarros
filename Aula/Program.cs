using Aula.Entities;
using Aula.Entities.Interfaces;
using Aula.Enums;
using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2, Color = Color.Black };
            Console.WriteLine(s1);
        }
    }
}
