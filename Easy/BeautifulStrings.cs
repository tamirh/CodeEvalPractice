namespace CodeEvalPractice.Easy
{
    class BeautifulStrings
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
            System.IO.StreamReader reader = OpenInput(args);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine().Trim().ToLower();
                if (line == null)
                    continue;

                int[] charCounts = new int[26];
                foreach(char c in line)
                {
                    int index = c - 'a';

                    // ignore punctuation
                    if (index < 26 && index >= 0)
                        charCounts[index]++;
                }

                System.Array.Sort(charCounts);

                int charBeauty = 26;
                int beautySum = 0;
                for (int i = charCounts.Length - 1; i >= 0; --i)
                {
                    beautySum += charCounts[i] * charBeauty--;
                }

                System.Console.WriteLine(beautySum);
            }
        }
    }
}
