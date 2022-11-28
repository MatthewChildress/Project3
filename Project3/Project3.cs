///<summary>
///File: Project3.cs
///Name: Matthew Childress
///Class: CISP1010
///Semester: Fall 2022
///Project: Don't Be a Square, Be a Rectangle!
/// </summary>
namespace Project3
{
    internal class Project3
    {
        /// <summary>
        /// The Main method is the entry point for this program
        /// </summary>
        static void Main()
        {
            // prints header
            Console.WriteLine("Rectangle Calculator");
            Console.WriteLine("**Enter q for quit**");
            Console.WriteLine();

            do
            {
                // declares variables
                string input;
                double width, height;

                // prompts for width, checks that it's not q and converts to a double
                Console.Write("width-> ");
                input = Console.ReadLine();
                if (input == "q") break;
                width = Convert.ToDouble(input);

                // prompts for height, checks that it's not q and converts to a double
                Console.Write("height-> ");
                input = Console.ReadLine();
                if (input == "q") break;
                height = Convert.ToDouble(input);

                // instantiates new object
                Rectangle rectangle = new Rectangle(width, height);

                // prints rectangle properties
                Console.WriteLine(rectangle);
                Console.WriteLine();

            } while (true);
        }
    }
}