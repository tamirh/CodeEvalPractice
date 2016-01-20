namespace CodeEvalPractice.Easy
{
    class QueryBoard
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
            int MAX = 256;
            int[,] matrix = new int[MAX, MAX];
            System.IO.StreamReader reader = OpenInput(args);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;
                
                string[] paramVals = line.Split();
                string command = paramVals[0];

                if (command.IndexOf("Set")==0)
                {
                    int value = System.Int32.Parse(paramVals[2]);
                    if (command.IndexOf("Row") > 0)
                    {
                        int row = System.Int32.Parse(paramVals[1]);
                        for (int x=0; x < MAX; ++x)
                        {
                            matrix[x, row] = value;
                        }
                    }
                    else // command.IndexOf("Col") > 0
                    {
                        int col = System.Int32.Parse(paramVals[1]);
                        for (int y = 0; y < MAX; ++y)
                        {
                            matrix[col, y] = value;
                        }
                    }
                }
                else if (command.IndexOf("Query")==0)
                {
                    int sum = 0;
                    if (command.IndexOf("Row") > 0)
                    {
                        int row = System.Int32.Parse(paramVals[1]);
                        for (int x = 0; x < MAX; ++x)
                        {
                            sum += matrix[x, row];
                        }
                    }
                    else // command.IndexOf("Col") > 0
                    {
                        int col = System.Int32.Parse(paramVals[1]);
                        for (int y = 0; y < MAX; ++y)
                        {
                            sum += matrix[col, y];
                        }
                    }

                    System.Console.WriteLine(sum);
                }
                else
                {
                    // invalid line, ignore
                }
            }
        }
    }
}
