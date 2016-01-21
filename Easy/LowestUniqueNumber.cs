namespace CodeEvalPractice.Easy
{
    class LowestUniqueNumber
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
                string line = reader.ReadLine();
                if (line == null)
                    continue;

                LowestUnique(line.Replace(" ", System.String.Empty));
            }
        }

        static void LowestUnique(string input)
        {
            int[] digitCounts = new int[10];
            foreach (char c in input)
            {
                if (c >= '0' && c <= '9')
                {
                    digitCounts[c - '0']++;
                }
            }

            for (int i = 0; i < 10; ++i)
            {
                if (digitCounts[i] == 1)
                {
                    // we know which value was the winner, find which player said that value
                    int player = 1;
                    foreach (char c in input)
                    {
                        if (c >= '0' && c <= '9')
                        {
                            if (c - '0' == i)
                            {
                                System.Console.WriteLine(player);
                                return;
                            }

                            ++player;
                        }
                    }
                }
            }

            System.Console.WriteLine("0");
        }
    }
}
