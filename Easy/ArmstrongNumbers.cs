namespace CodeEvalPractice.Easy
{
    class ArmstrongNumbers
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

                if (IsArmstrong(line.Trim()))
                {
                    System.Console.WriteLine("True");
                }
                else
                {
                    System.Console.WriteLine("False");
                }
            }
        }

        static bool IsArmstrong(string value)
        {
            int sum = 0;
            int pow = value.Length;

            foreach(char digit in value)
            {
                sum += (int)System.Math.Pow(digit - '0', pow);
            }

            return sum == System.Int32.Parse(value);
        }
    }
}
