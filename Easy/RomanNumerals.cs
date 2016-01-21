namespace CodeEvalPractice.Easy
{
    class RomanNumerals
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

                int[] romanValues = new int[]           { 1,   4,    5,   9,    10,  40,   50,  90,   100, 400,  500, 900,  1000 };
                string[] romanStrings = new string[]    { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

                int num = System.Int32.Parse(line.Trim());
                System.Text.StringBuilder output = new System.Text.StringBuilder();

                while(num > 0)
                {
                    for(int i = romanValues.Length - 1; i >= 0; --i)
                    {
                        if (romanValues[i] <= num)
                        {
                            num -= romanValues[i];
                            output.Append(romanStrings[i]);
                            break;
                        }
                    }
                }

                System.Console.WriteLine(output.ToString());
            }
        }
    }
}
