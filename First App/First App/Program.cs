using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new String[] { "Line 1", "Line 2", "Line 3444", "Very long string for testingss" };
            int p = 46; // Minimum padding between border and line content
            var m = lines.Max(s => s.Length) + p; // Length of longest string + padding
            string border = new String('═', m); // Generate top and bottom border strings
            Console.WriteLine("╔" + border + "╗"); // Top part of the frame

            foreach (var line in lines)
            {
                string pad = new String(' ', (m - line.Length) / 2); // Pad text to center
                Console.WriteLine("║" + pad + (((line.Length % 2 == 0)||(line.Length==m)) ? "" : " ") + line + pad + "║"); // Line content
            }

            Console.WriteLine("╚" + border + "╝"); // Bottom part of the frame

            Console.ReadKey(); // FU
        }
    }
}