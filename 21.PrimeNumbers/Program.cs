internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of Prime numbers you want to see: ");
        int n = Convert.ToInt32(Console.ReadLine());
        foreach (var prime in GeneratePrime(n))
            Console.Write(prime + " ");
    }

    private static long[] GeneratePrime(int length)
    {
        long[] primes = new long[length];
        for (int i = 0; i < length; i++)
        {
            primes[i] = PrimeN(i + 1);
        }

        return primes;
    }


    private static long PrimeN(int n)
    {
        if (n < 0)
            return -1;
        int primes = 0;
        int num = 2;
        while (true)
        {
            if (IsPrime(num))
            {
                primes++;
                if (primes == n)
                    return num;
            }
            num++;
        }
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;
        int i = 5;
        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
            i += 6;
        }
        return true;
    }
}