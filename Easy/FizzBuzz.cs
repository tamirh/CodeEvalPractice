// https://www.codeeval.com/open_challenges/1/
namespace CodeEvalPractice.Easy
{
    class FizzBuzz
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

                string[] paramVals = line.Split();
                int fizzVal = System.Int32.Parse(paramVals[0]);
                int buzzVal = System.Int32.Parse(paramVals[1]);
                int maxCount = System.Int32.Parse(paramVals[2]);

                System.Text.StringBuilder output = new System.Text.StringBuilder();
                for (int i=1; i<= maxCount; ++i)
                {
                    bool fizz = i % fizzVal == 0;
                    bool buzz = i % buzzVal == 0;

                    if (!fizz && !buzz)
                    {
                        output.Append(i);
                    }
                    else
                    {
                        if (fizz)
                            output.Append('F');

                        if (buzz)
                            output.Append('B');
                    }

                    output.Append(' ');
                }

                // Strip off trailing space we added
                System.Console.WriteLine(output.ToString(0, output.Length - 1));
            }
        }
    }
}
