namespace CodeEvalPractice.Moderate
{
    class MixedContent
    {
        static System.IO.StreamReader OpenInput(string[] args)
        {
            string filename;
            if (args == null || args.Length < 1)
            {
                filename = "./../../Moderate/" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ".txt";
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

                string[] items = line.Split(',');
                System.Collections.Generic.List<int> numbers = new System.Collections.Generic.List<int>();
                System.Collections.Generic.List<string> words = new System.Collections.Generic.List<string>();

                foreach (string item in items)
                {
                    int intvalue;
                    if (System.Int32.TryParse(item, out intvalue))
                    {
                        numbers.Add(intvalue);
                    }
                    else
                    {
                        words.Add(item);
                    }
                }

                string wordsString = string.Join(",", words);
                string numbersString = string.Join(",", numbers);

                if (words.Count == 0)
                {
                    System.Console.WriteLine(numbersString);
                }
                else if (numbers.Count == 0)
                {
                    System.Console.WriteLine(wordsString);
                }
                else
                {
                    System.Console.WriteLine(wordsString + "|" + numbersString);
                }
            }
        }
    }
}
