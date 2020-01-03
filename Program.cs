using System;
using static System.Console;

namespace park_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Park grandCanyon = new Park();
            WriteLine(grandCanyon.ParkType());
            WriteLine(grandCanyon.ParkFacilities());
        }
    }
}
