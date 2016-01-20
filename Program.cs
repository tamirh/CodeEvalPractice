namespace CodeEvalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Easy.MultiplicationTables.Main(null);

            System.Console.WriteLine();
        }


        /*
                static void MakeBlankStuff()
                {
                    System.IO.StreamReader moderateText = System.IO.File.OpenText("e:\\Users\\Tamir\\Desktop\\moderate.txt");
                    System.IO.StreamReader hardText = System.IO.File.OpenText("e:\\Users\\Tamir\\Desktop\\hard.txt");

                    Create("e:\\users\\tamir\\documents\\visual studio 2015\\Projects\\CodeEvalPractice\\CodeEvalPractice\\Moderate\\", moderateText);
                    Create("e:\\users\\tamir\\documents\\visual studio 2015\\Projects\\CodeEvalPractice\\CodeEvalPractice\\Hard\\", hardText);
                }

                static void Create(string templateFilename, System.IO.StreamReader reader)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                            continue;

                        string name = line.Replace(" ", string.Empty);
                        MakeSkeleton(templateFilename, name);
                    }

                    reader.Close();
                }

                static void MakeSkeleton(string dir, string className)
                {
                    string templateFilename = dir + "~Template.cs";
                    string classFilename = dir + className + ".cs";

                    System.IO.StreamReader template = System.IO.File.OpenText(templateFilename);
                    System.IO.StreamWriter output = System.IO.File.CreateText(classFilename);

                    while(!template.EndOfStream)
                    {
                        string line = template.ReadLine();
                        if (line == null)
                            continue;

                        output.WriteLine(line.Replace("_Template", className));
                    }

                    output.Close();
                    template.Close();
                }
            }*/
    }
}
