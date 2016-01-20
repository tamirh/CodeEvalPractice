namespace CodeEvalPractice.Easy
{
    class SimpleSorting
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

                string[] stringValues = line.Split();
                double[] values = System.Array.ConvertAll(stringValues, System.Double.Parse);

                System.Array.Sort(values);

                System.Collections.Generic.List<string> output = new System.Collections.Generic.List<string>();
                foreach(double value in values)
                {
                    output.Add(value.ToString("F3"));
                }

                System.Console.WriteLine(string.Join(" ", output));
            }
        }
    }
}
