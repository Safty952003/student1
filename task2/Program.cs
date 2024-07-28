namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your SSN: ");
                string ssn = Console.ReadLine();

                Console.Write("Enter your salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (salary >= 40000)
                {
                    Console.WriteLine("The salary should be less than 40000.");
                }
               
                else if (age == 0)
                {
                    Console.WriteLine("Age cannot be zero.");
                }
                else
                {
                    Console.WriteLine($"Employee Name: {name}");
                    Console.WriteLine($"Employee SSN: {ssn}");
                    Console.WriteLine($"Employee Salary: {salary}");
                    Console.WriteLine($"Employee Age: {age}");
                }
            }
        }

    }
