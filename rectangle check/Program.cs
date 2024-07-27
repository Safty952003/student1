namespace rectangle_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            if (length == width)
            {
                Console.WriteLine("The rectangle is a square.");
            }
            else
            {
                Console.WriteLine("The rectangle is not a square.");
            }
        }
    }
}
