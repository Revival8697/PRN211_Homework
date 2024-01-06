class Ex1
{
    static bool IsPrime(int n)
    {
        if (n <= 1) { return false; }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) { return false; }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[] array = new int[10];
        Console.WriteLine("Enter 10 numbers, one by one:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nPrime numbers in the array:");
        foreach (int n in array)
        {
            if (IsPrime(n)) { Console.WriteLine(n); }
        }
    }
}