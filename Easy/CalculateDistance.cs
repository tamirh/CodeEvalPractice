namespace CodeEvalPractice.Easy
{
    class CalculateDistance
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

                string[] paramVals = line.Split(new char[] { '(' }, System.StringSplitOptions.RemoveEmptyEntries);
                int x1, y1, x2, y2;
                GetCoords(paramVals[0], out x1, out y1);
                GetCoords(paramVals[1], out x2, out y2);

                int dx = x2 - x1;
                int dy = y2 - y1;
                double distance = System.Math.Sqrt(dx*dx + dy*dy);

                System.Console.WriteLine((int)distance);
            }
        }

        static void GetCoords(string coord, out int x, out int y)
        {
            x = y = 0;

            string[] splitCoords = coord.Split(new char[] { ')', ' ', ',' }, System.StringSplitOptions.RemoveEmptyEntries);
            x = System.Int32.Parse(splitCoords[0]);
            y = System.Int32.Parse(splitCoords[1]);
        }
    }
}
