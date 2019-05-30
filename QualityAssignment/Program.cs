using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityAssignment
{
    class Program
    {
        // Create a new dictionary of options
        static Dictionary<int, string> optionsDict = new Dictionary<int, string>();

        static void Main(string[] args)
        {

            // Adding key/value pairs in optionsDict
            optionsDict.Add(1, "Get Rectangle Length");
            optionsDict.Add(2, "Change Rectangle Length");
            optionsDict.Add(3, "Get Rectangle Width");
            optionsDict.Add(4, "Change Rectangle Width");
            optionsDict.Add(5, "Get Rectangle Perimeter");
            optionsDict.Add(6, "Get Rectangle Area");
            optionsDict.Add(7, "Exit");

            Program p = new Program();
            p.go();
            //Console.ReadKey();
        }

        public void go()
        {
            Rectangle rect = new Rectangle();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* Welcome to assignment 1 - Rectangle modification *");
            Console.WriteLine("****************************************************");

            string length = string.Empty;
            int lengths = 0;
            do
            {
                if (length != string.Empty)
                {
                    Console.WriteLine("Input error: Please enter a number greater than zero");
                }
                Console.Write("Please enter the LENGTH of the rectangle: ");
                length = Console.ReadLine();
            } while (!int.TryParse(length, out lengths) || (lengths <= 0));

            rect.SetLength(lengths);

            string width = string.Empty;
            int widths = 0;
            do
            {
                if (width != string.Empty)
                {
                    Console.WriteLine("Input error: Please enter a number greater than zero");
                }
                Console.Write("Please enter the WIDTH of the rectangle: ");
                width = Console.ReadLine();
            } while (!int.TryParse(width, out widths) || (widths <= 0));

            rect.SetWidth(widths);

            bool keepMenu = true;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("**********************************************");
                Console.WriteLine("*                    Menu                    *");
                Console.WriteLine("**********************************************");

                string opt = string.Empty;
                int opts = 0;
                do
                {
                    foreach (KeyValuePair<int, string> option in optionsDict)
                    {
                        Console.WriteLine("{0} - {1}", option.Key, option.Value);
                    }
                    Console.WriteLine("**********************************************");
                    if (opt != string.Empty)
                    {
                        Console.WriteLine("Input error: Please enter a number between 1 and 7");
                    }
                    Console.WriteLine("Please, choose an option from the menu above");
                    Console.WriteLine("");
                    Console.Write("Option: ");
                    opt = Console.ReadLine();
                } while (!int.TryParse(opt, out opts) || (opts <= 0 || opts > 7));

                switch (opts)
                {
                    case 1:
                        Console.WriteLine("The LENGTH of your rectangle is " + rect.GetLength());
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                        break;
                    case 2:

                        length = string.Empty;
                        lengths = 0;
                        do
                        {
                            if (length != string.Empty)
                            {
                                Console.WriteLine("Input error: Please enter a number greater than zero");
                            }
                            Console.Write("Please enter the new LENGTH of the rectangle: ");
                            length = Console.ReadLine();
                        } while (!int.TryParse(length, out lengths) || (lengths <= 0));
                        rect.SetLength(lengths);
                        Console.WriteLine("The LENGTH of your rectangle has been changed SUCCESSFULLY!");
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("The WIDTH of your rectangle is " + rect.GetWidth());
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        width = string.Empty;
                        widths = 0;
                        do
                        {
                            if (width != string.Empty)
                            {
                                Console.WriteLine("Input error: Please enter a number greater than zero");
                            }
                            Console.Write("Please enter the WIDTH of the rectangle: ");
                            width = Console.ReadLine();
                        } while (!int.TryParse(width, out widths) || (widths <= 0));
                        rect.SetWidth(widths);
                        Console.WriteLine("The WIDTH of your rectangle has been changed SUCCESSFULLY!");
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("The PERIMETER of your rectangle is " + rect.GetPerimeter());
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("The AREA of your rectangle is " + rect.GetArea());
                        Console.WriteLine("ENTER to continue...");
                        Console.ReadKey();
                        break;
                    case 7:
                        // Program exits
                        keepMenu = false;
                        break;
                    default:
                        break;
                }

            } while (keepMenu == true);

        }
    }
}
