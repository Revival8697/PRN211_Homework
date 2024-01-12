class Ex2
{
    static void Main(string[] args)
    {
        double a, b, c = 0;
        Console.Write("Enter a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("\nSelect an operation:" +
            "\n1 for +" +
            "\n2 for -" +
            "\n3 for *" +
            "\n4 for /" +
            "\n0 to Exit.");
        string op = Console.ReadLine();

        switch (op)
        {
            case "1": c = a + b; break;
            case "2": c = a - b; break;
            case "3": c = a * b; break;
            case "4":
                if (b == 0) { Console.WriteLine("\nOf course I have a Divide by 0 check, lol."); }
                else { c = a / b; break; }
                return;
            case "0": return;
            default:
                Console.WriteLine("You can only choose from 1, 2, 3 or 4.");
                return;
        }
        Console.WriteLine($"\nResult: {c}");
        Console.WriteLine();
    }
}
