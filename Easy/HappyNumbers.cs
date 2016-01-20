namespace CodeEvalPractice.Easy
{
    class HappyNumbers
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

                if (IsHappy(System.Int32.Parse(line)))
                {
                    System.Console.WriteLine("1");
                }
                else
                {
                    System.Console.WriteLine("0");
                }
            }
        }

        static bool IsHappy(int inputNumber)
        {
            System.Collections.Generic.HashSet<int> numbersSeen = new System.Collections.Generic.HashSet<int>();
            while (!numbersSeen.Contains(inputNumber))
            {
                string inputString = inputNumber.ToString();
                numbersSeen.Add(inputNumber);

                inputNumber = 0;
                foreach (char digit in inputString)
                {
                    int digitVal = digit - '0';
                    inputNumber += digitVal * digitVal;
                }

                if (inputNumber == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
