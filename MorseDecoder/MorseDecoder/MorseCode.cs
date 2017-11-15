using System;
using System.Collections.Generic;
using System.Text;

namespace MorseDecoder
{
    public class MorseCode
    {
        //Members
        private char letter;
        private String code;

        //Constructor
        public MorseCode(char letter,String code)
        {
            this.letter = letter;
            this.code = code;
        }

        //Setter und Getter
        public char Letter
        {
            get { return this.letter; }
        }

        public String Code
        {
            get { return this.code; }
        }
    }
}
