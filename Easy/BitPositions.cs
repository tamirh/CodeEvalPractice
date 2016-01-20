namespace CodeEvalPractice.Easy
{
    class BitPositions
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

                string[] paramVals = line.Split(',');
                int num = System.Int32.Parse(paramVals[0]);
                int bitPos1 = System.Int32.Parse(paramVals[1]);
                int bitPos2 = System.Int32.Parse(paramVals[2]);

                // Shift over so the bit we care about is in the lowest bit position
                // Then mask out all other bits
                int bitval1 = 1 & (num >> (bitPos1 - 1));
                int bitval2 = 1 & (num >> (bitPos2 - 1));

                if (bitval1 == bitval2)
                {
                    System.Console.WriteLine("true");
                }
                else
                {
                    System.Console.WriteLine("false");
                }
            }
        }
    }
}
