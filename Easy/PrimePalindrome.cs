namespace CodeEvalPractice.Easy
{
    // https://www.codeeval.com/open_challenges/3/
    class PrimePalindrome
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
            const int DEFAULT_MAX_PRIME = 1000;
            int maxPrime = DEFAULT_MAX_PRIME;

            System.IO.StreamReader reader = OpenInput(args);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;

                string[] paramVals = line.Split();
                maxPrime = System.Int32.Parse(paramVals[0]);
            }

            // Seive of Erastamus(sp?)
            // Keep track of primes by ruling out multiples of previous primes
            // A true value means we have ruled out that as a prime number
            bool[] seive = new bool[maxPrime+1];
            System.Array.Clear(seive, 1, maxPrime);
            seive[0] = true;
            seive[1] = true;

            System.Collections.Generic.IList<int> primes = new System.Collections.Generic.List<int>();
            for (int i = 2; i < maxPrime; ++i)
            {
                // If we have already ruled out this value, we don't need to check multiples
                if (seive[i])
                    continue;

                // This value is prime, rule out further multiples of this number
                primes.Add(i);
                for (int j = i + i; j < maxPrime; j += i)
                {
                    seive[j] = true;
                }
            }

            // Go over our primes in reverse, looking for a palindrome to find largest
            for (int i = primes.Count - 1; i >= 0; --i)
            {
                string prime = primes[i].ToString();
                if (IsPalindrome(prime))
                {
                    System.Console.WriteLine(prime);
                    return;
                }
            }
        }

        static bool IsPalindrome(string s)
        {
            for (int j = 0; j < s.Length / 2; ++j)
            {
                if (s[j] != s[s.Length - j - 1])
                    return false;
            }

            return true;
        }
    }
}
