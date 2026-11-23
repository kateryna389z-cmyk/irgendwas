namespace katze;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        //double value = double.Parse(Console.ReadLine());
        double value = 0;
        bool worked = double.TryParse(Console.ReadLine(), out value);

        if (worked)
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("This is not a valid number.");
        }
    }
}


