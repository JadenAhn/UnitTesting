/* Program.cs
 * Revision History
 *      Jaden Ahn, 2018-02-01: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;
            bool exit = false;
            Console.WriteLine("Please enter the length and width of the rectangle");

            length = validateInt(length, "Length");
            width = validateInt(width, "Width");

            Console.Clear();
            Rectangle r = new Rectangle(length, width);
            string notice = "";
            showMenu();

            while (!exit)
            {
                Console.Write("Menu: ");
                string reply = Console.ReadLine();
                switch (reply)
                {
                    case "1":
                        r.GetLength();
                        notice = "successfully got length. current length is " + length;
                        Console.Clear();
                        break;
                    case "2":
                        length = validateInt(length, "New Length");
                        r.SetLength(length);
                        notice = "successfully set length. current length is " + length;
                        break;
                    case "3":
                        r.GetWidth();
                        notice = "successfully got width. current width is " + width;
                        break;
                    case "4":
                        width = validateInt(width, "New Width");
                        r.SetWidth(width);
                        notice = "successfully set width. current width is " + width;
                        break;
                    case "5":
                        notice = "Current Perimeter is " + r.GetPerimeter();
                        break;
                    case "6":
                        notice = "Current Area is " + r.GetArea();
                        break;
                    case "7":
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        exit = true;
                        break;
                    default:
                        notice = "Please select from 1 to 7";
                        break;
                }
                Console.Clear();
                showMenu();
                if (notice != "")
                {
                    Console.WriteLine("* " + notice);
                }
                
            }
        }

        static void showMenu()
        {
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
        }

        static int validateInt(int val, string name)
        {
            Console.Write(name + ": ");
            while (!int.TryParse(Console.ReadLine(), out val) || val <= 0)
            {
                Console.WriteLine("Invalid input. " + name + " must be an integer, greater than 0");
                Console.Write(name + ": ");
            }
            return val;
        }
    }
}
