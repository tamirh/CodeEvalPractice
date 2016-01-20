namespace CodeEvalPractice.Easy
{
    class FileSize
    {
        static string InputPath(string[] args)
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

            return filename;
        }

        public static void Main(string[] args)
        {
            string path = InputPath(args);
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);

            System.Console.WriteLine(fileInfo.Length);
        }
    }
}
