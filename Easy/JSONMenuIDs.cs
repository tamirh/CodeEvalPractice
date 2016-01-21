namespace CodeEvalPractice.Easy
{
    class JSONMenuIDs
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

                int itemsPos = line.IndexOf("\"items\"");
                if (itemsPos == -1)
                    continue;

                int itemsBegin = line.IndexOf("[", itemsPos);
                if (itemsBegin == -1)
                    continue;

                int itemsEnd = line.IndexOf("]", itemsBegin);
                if (itemsEnd == -1)
                    continue;

                string[] items = line.Substring(itemsBegin, itemsEnd-itemsBegin).Split(new char[] { '{', '[', ']' }, System.StringSplitOptions.RemoveEmptyEntries);

                int sum = 0;
                foreach(string item in items)
                {
                    if (item.IndexOf("\"label\"") >= 0)
                    {
                        int idBegin = item.IndexOf("\"id\":");
                        if (idBegin == -1)
                            continue;

                        int idEnd = item.IndexOf(",", idBegin);
                        if (idEnd == -1)
                            continue;

                        string idValueString = item.Substring(5 + idBegin, idEnd - idBegin - 5).Trim();
                        int idValue = System.Int32.Parse(idValueString);

                        sum += idValue;
                    }
                }

                System.Console.WriteLine(sum);
            }
        }
    }
}
