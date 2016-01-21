namespace CodeEvalPractice.Easy
{
    // https://www.codeeval.com/open_challenges/104/
    class WordToDigit
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

                string[] words = line.Split(';');

                int index = 0;
                char[] digits = new char[words.Length];
                foreach(string word in words)
                {
                    char c = '0';
                    switch (word.ToLower())
                    {
                        case "zero": c = '0'; break;
                        case "one": c = '1'; break;
                        case "two": c = '2'; break;
                        case "three": c = '3'; break;
                        case "four": c = '4'; break;
                        case "five": c = '5'; break;
                        case "six": c = '6'; break;
                        case "seven": c = '7'; break;
                        case "eight": c = '8'; break;
                        case "nine": c = '9'; break;
                    }

                    digits[index++] = c;
                }

                System.Console.WriteLine(digits);
            }
        }
    }
}
