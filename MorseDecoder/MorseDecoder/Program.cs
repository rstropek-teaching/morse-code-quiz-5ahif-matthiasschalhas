using System;

namespace MorseDecoder
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(args != null)
            {
                if(args.Length == 2)
                {
                    Console.WriteLine("Input-File: " + args[0]);
                    Console.WriteLine("Outut-File: " + args[1]);
                    FileEditor editor = new FileEditor(args[0],args[1]);
                    editor.readTextFromFile();
                    editor.checkMorseCode();
                    editor.compute();
                    editor.presentResults();
                }
                else
                {
                    Console.WriteLine("Error: Arguments are not correct");   
                }
            }
            else
            {
                Console.WriteLine("Error: Args is null");
            }
            Console.ReadKey();
        }
        
    }
}
