namespace CodeEvalPractice.Easy
{
    // https://www.codeeval.com/open_challenges/4/
    class SumOfPrimes
    {
        static System.IO.StreamReader OpenInput(string[] args)
        {
            string filename;
            if (args == null || args.Length < 1)
            {
                filename = "./../../Easy/" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ".txt";
            }
            else
            {
                filename = args[0];
            }

            return System.IO.File.OpenText(filename);
        }

        public static void Main(string[] args)
        {
            const int DEFAULT_PRIME_COUNT = 1000;
            int primeCount = DEFAULT_PRIME_COUNT;

            System.IO.StreamReader reader = OpenInput(args);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;

                string[] paramVals = line.Split();

                primeCount = System.Int32.Parse(paramVals[0]);
            }

            // Brute force find first X number of primes
            System.Collections.Generic.List<int> primes = new System.Collections.Generic.List<int>();

            // Seed with first prime number being 2
            primes.Add(2);
            int currentValue = 3;

            while (primes.Count < primeCount)
            {
                if (!IsDivisible(currentValue, primes))
                {
                    primes.Add(currentValue);
                }

                currentValue++;
            }

            // Sum up our prime numbers
            int sum = 0;
            foreach (int prime in primes)
            {
                sum += prime;
            }

            System.Console.WriteLine(sum);
        }

        static bool IsDivisible(int value, System.Collections.Generic.IList<int> divisors)
        {
            foreach (int div in divisors)
            {
                if (value % div == 0)
                    return true;
            }

            return false;
        }
    }
}
