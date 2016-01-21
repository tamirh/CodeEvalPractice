namespace CodeEvalPractice.Easy
{
    class EvenNumbers
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

                int num = System.Int32.Parse(line.Trim());
                
                if (num%2==0)
                {
                    System.Console.WriteLine("1");
                }
                else
                {
                    System.Console.WriteLine("0");
                }
            }
        }
    }
}
