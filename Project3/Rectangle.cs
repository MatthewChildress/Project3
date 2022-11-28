using System.Threading.Channels;
///<summary>
///File: Rectangle.cs
///Name: Matthew Childress
///Class: CISP1010
///Semester: Fall 2022
///Project: Don't Be a Square, Be a Rectangle!
/// </summary>
namespace Project3
{
    /// <summary>
    /// Models a Rectangle object
    /// </summary>
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Calculates a rectangle's area from width and height
        /// </summary>
        public double Area
        {

            get
            {
                return Width * Height;
            }

        }
        /// <summary>
        /// Calculates a rectangle's diagonal length from width and height
        /// </summary>
        public double Diagional
        {

            get
            {
                return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            }

        }
        /// <summary>
        /// Checks if a rectangle is a square
        /// </summary>
        public bool IsSquare
        {

            get
            {
                return Width == Height;
            }

        }
        /// <summary>
        /// Calculates a rectangle's perimeter length from width and height
        /// </summary>
        public double Perimeter
        {

            get
            {
                return 2 * (Width + Height);
            }

        }
        
        
        /// <summary>
        /// Creates a string representation of the Rectangle
        /// </summary>
        /// <returns>The string representation of the Rectangle</returns>
        override public string ToString()
        {

            return $"\nrectangle -> \nwidth = {Width} \nheight = {Height}\narea = {Area}\nperimeter = {Perimeter}\ndiagonal = {Diagional}\nis square = {IsSquare}";
        }

    }
}
