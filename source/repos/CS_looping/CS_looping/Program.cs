using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_looping
{
    class Program
    {
        static void Main()

        {
            var x = new List<int>() { 33, 9, 96, 69, 96, 88, 17, 11, 99, 22, 85, 97, 21, 63, 72, 72, 84, 12, 7, 36, 7, 55, 24, 25, 94, 29, 68, 14, 98, 4, 19, 38, 43, 14, 72, 53, 71, 75, 85, 49, 27, 16, 61, 75, 33, 45, 83, 81, 23, 91, 80, 60, 78, 6, 5, 33, 9, 47, 38, 23, 5, 60, 37, 9, 1, 49, 63, 2, 86, 96, 69, 38, 43, 96, 9, 15, 22, 75, 40, 33, 3, 14, 23, 86, 89, 6, 92, 87, 62, 45, 3, 4, 75, 64, 28, 84, 13, 10, 14, 4, 71, 65, 20, 50, 64, 62, 71, 77, 26, 5, 84, 4, 5, 49, 4, 51, 79, 46, 37, 47, 77, 42, 28, 83, 9, 99, 75, 86, 48, 95, 1, 100, 17, 81, 23, 62, 69, 71, 49, 97, 26, 44, 65, 16, 68, 92, 15, 81, 30, 23, 3, 69, 1, 93, 30, 5, 60, 88, 15, 38, 91, 14, 25, 7, 62, 23, 89, 36, 37, 96, 24, 94, 33, 72, 37, 97, 1, 55, 17, 41, 97, 97, 80, 59, 99, 59, 6, 39, 89, 72, 74, 15, 28, 41, 48, 23, 12, 14, 20, 77, 38, 66, 10, 34, 12, 22, 20, 9, 76, 67, 92, 48, 77, 65, 63, 82, 32, 98, 7, 64, 31, 7, 83, 11, 85, 48, 23, 100, 2, 11, 32, 2, 89, 86, 17, 31, 50, 63, 25, 46, 41, 71, 38, 33, 20, 14, 6, 54, 27, 66, 90, 81, 75, 94, 23, 43, 51, 11, 67, 40, 75, 49, 29, 24, 50, 21, 92, 2, 65, 65, 29, 100, 82, 80, 32, 96, 55, 67, 96, 82, 20, 29, 22, 8, 73, 14, 20, 88, 88, 27, 8, 79, 49, 25, 97, 88, 75, 84, 94, 16, 86, 92, 94, 8, 31, 96, 1, 67, 100, 29, 65, 20, 40, 10, 27, 62, 80, 28, 11, 27, 99, 52, 21, 33, 51, 84, 74, 1, 81, 30, 24, 45, 70, 72, 10, 38, 90, 94, 94, 13, 66, 82, 33, 33, 50, 58, 13, 66, 17, 73, 11, 87, 14, 32, 37, 48, 87, 34, 13, 7, 59, 85, 67, 30, 62, 55, 99, 46, 52, 92, 9, 63, 17, 44, 25, 100, 80, 60, 45, 13, 39, 24, 42, 60, 50, 46, 28, 88, 64, 58, 83, 6, 68, 91, 12, 88, 14, 100, 55, 53, 56, 18, 57, 53, 41, 56, 70, 59, 48, 31, 81, 11, 7, 57, 37, 54, 30, 31, 22, 93, 11, 92, 46, 23, 80, 64, 90, 77, 76, 12, 23, 29, 69, 80, 21, 21, 57, 83, 42, 77, 38, 22, 5, 20, 23, 16};

            var found = false;
            var i = 0;
            int item;
            Console.WriteLine("What item would you like to find?: (enter a number between 1 and 100)");
            var input = Console.ReadLine();
            while (found == false) 
            {
                item = x[i];
                if (Int32.Parse(input) == item)
                {
                    Console.WriteLine($"Item found at position {i + 1}");
                    found = true;
                }
                i += 1;
            }
            Console.ReadLine();


        }
    }
}
