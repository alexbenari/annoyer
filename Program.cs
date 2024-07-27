using System;
using System.Runtime.InteropServices;
using System.Threading;
public class Program
{
    static void Main()
    {
        Infinite_dots("ha ");
    }

    static void Infinite_dots(string whattoprint=".")
    {
        Console.WriteLine("Hello, CHILD!");
        Console.WriteLine("I HAVE COME FOR YOUR COMPUTER!");

        // Print periods with 1-second intervals
        while (true) 
        {
            Thread.Sleep(1000); // Wait for 1 second
            Console.Write(whattoprint);
        }
    }
}