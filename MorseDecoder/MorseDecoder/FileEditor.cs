using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MorseDecoder
{
    public class FileEditor
    {
        //Class-Members
        private String textFile;
        private String solutionFile;
        private List<MorseCode> codes;

        StringBuilder text;
        StringBuilder morseText;

        //Constructor
        public FileEditor(String textFile,String solutionFile)
        {
            this.textFile = textFile;
            this.solutionFile = solutionFile;
            this.codes = new List<MorseCode>();
            this.initMorseCodes();
        }

        //Getter and Setter
        private String TextFile
        {
            get { return this.textFile; }
            set { this.textFile = value; }
        }
        private String SolutionFile
        {
            get { return this.solutionFile; }
        }
        private List<MorseCode> Codes
        {
            get { return this.codes; }
        }

        //Methods
        public void readTextFromFile()
        {
            String[] lines;

            if (File.Exists(textFile))
            {

                lines = File.ReadAllLines(textFile);
                morseText = new StringBuilder();
                foreach(String l in lines)
                {
                    morseText.Append(l);
                }
            }

            //Now i have the morseCode
        }
        public void checkMorseCode()
        {
            char[] codeLetter = this.morseText.ToString().ToCharArray();
            foreach(char c in codeLetter)
            {
                if(c.Equals(' ') || c.Equals('.') || c.Equals('-'))
                {
                    //correct
                }
                else
                {
                    try
                    {
                        throw new WrongDigitException("Error: There is a wrong digit!");
                    }catch(WrongDigitException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
        }
        public void compute()
        {
            String[] letter = morseText.ToString().Split("    ");
            text = new StringBuilder();
            foreach (String t in letter)
            {
                text.Append(getLetterFromCode(t.ToString().Trim()) + " ");
            }
            Console.WriteLine(text);
        }
        public String getLetterFromCode(String mcode)
        {
            String[] ll = mcode.Trim().Split(" ");
            String word = "";
            foreach(String lett in ll)
            {
                foreach(MorseCode m in codes)
                {
                    if (m.Code.Equals(lett))
                    {
                        word = word + m.Letter;
                    }
                }
            }
            return word; 
        }

        public void initMorseCodes()
        {
            this.codes.Add(new MorseCode('A', ".-"));
            this.codes.Add(new MorseCode('B', "-..."));
            this.codes.Add(new MorseCode('C', "-.-."));
            this.codes.Add(new MorseCode('D', "-.."));
            this.codes.Add(new MorseCode('E', "."));
            this.codes.Add(new MorseCode('F', "..-."));
            this.codes.Add(new MorseCode('G', "--."));
            this.codes.Add(new MorseCode('H', "...."));
            this.codes.Add(new MorseCode('I', ".."));
            this.codes.Add(new MorseCode('J', ".---"));
            this.codes.Add(new MorseCode('K', "-.-"));
            this.codes.Add(new MorseCode('L', ".-.."));
            this.codes.Add(new MorseCode('M', "--"));
            this.codes.Add(new MorseCode('N', "-."));
            this.codes.Add(new MorseCode('O', "---"));
            this.codes.Add(new MorseCode('P', ".--."));
            this.codes.Add(new MorseCode('Q', "--.-"));
            this.codes.Add(new MorseCode('R', ".-."));
            this.codes.Add(new MorseCode('S', "..."));
            this.codes.Add(new MorseCode('T', "-"));
            this.codes.Add(new MorseCode('U', "..-"));
            this.codes.Add(new MorseCode('V', "...-"));
            this.codes.Add(new MorseCode('W', ".--"));
            this.codes.Add(new MorseCode('X', "-..-"));
            this.codes.Add(new MorseCode('Y', "-.--"));
            this.codes.Add(new MorseCode('Z', "--.."));
            this.codes.Add(new MorseCode('0', "-----"));
            this.codes.Add(new MorseCode('1', ".----"));
            this.codes.Add(new MorseCode('2', "..---"));
            this.codes.Add(new MorseCode('3', "...--"));
            this.codes.Add(new MorseCode('4', "....-"));
            this.codes.Add(new MorseCode('5', "....."));
            this.codes.Add(new MorseCode('6', "-...."));
            this.codes.Add(new MorseCode('7', "--..."));
            this.codes.Add(new MorseCode('8', "---.."));
            this.codes.Add(new MorseCode('9', "----."));
        }
        public void writeTextInFile()
        {
            if (File.Exists(solutionFile))
            {
                using(StreamWriter wr = new StreamWriter(solutionFile))
                {
                    wr.Write(String.Empty); //Clear-File
                    wr.Write(text.ToString());
                    wr.Close();
                }
            }
        }
        public void presentResults()
        {
            writeTextInFile();
            Console.WriteLine(text);
            Console.WriteLine(morseText);
        }
    }
}
