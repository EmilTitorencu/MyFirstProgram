using System;

namespace lab1ex9
{
    /* Scrieti un program care interschimba valoarea a doua variabile intregi */
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 9;
            int temp = x;
            x = y;
            y = temp;
            Console.Write(x);
            Console.Write(" ");
            Console.Write(y);
        }
    }
}
