using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookNameCount
{
    partial class Program
    {

        static void Main(string[] args)
        {

            List<string> Names = new List<string>();
            string newName = "";
            int otherCount = 0;

            Console.WriteLine("You just created a status message on Facebook.");
            Console.WriteLine("Names you enter are users who like your post.");
            Console.WriteLine();

            
            do
            {
                Console.Write("Enter a name: ");
                newName = Console.ReadLine();

                if (newName != "")
                {
                    Names.Add(newName);

                    if (Names.Count <= 2)
                    {
                        if (Names.Count == 1)
                        {
                            Console.WriteLine(Names[0] + " likes your post.");
                        }
                        else
                        {
                            string twoNames = string.Format("{0} {1} {2} {3}", Names[0], "and", Names[1], "like your post");
                            Console.WriteLine(twoNames);
                        }
                    }
                    else if (Names.Count == 3)
                    {
                        otherCount = Names.Count - 2;
                        Console.WriteLine(Names[0] + " and " + Names[1] + " plus " + otherCount + " other likes your post");
                    }
                    else
                    {
                        otherCount = Names.Count - 2;
                        Console.WriteLine(Names[0] + " and " + Names[1] + " plus " + otherCount + " others like your post");
                    }

                }
                else
                {

                }

            } while (newName != "");

        }
    }
}
