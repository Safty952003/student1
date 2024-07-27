namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter your ID:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter tour age:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your depatment:");
            string dept = Console.ReadLine();

            Console.WriteLine("**************");

            Console.WriteLine($"your Name is:{name}");
            Console.WriteLine($"your age is:{age}");
            Console.WriteLine($"your ID is:{id}");
            Console.WriteLine($"your depatment is:{dept}");

        }
    }
}
