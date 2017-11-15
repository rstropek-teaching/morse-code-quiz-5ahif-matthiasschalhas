using System;
using System.Collections.Generic;
using System.Text;

namespace MorseDecoder
{
    public class WrongDigitException : Exception
    {
        public WrongDigitException(String message) : base(message)
        {

        }
        public WrongDigitException()
        {
        }
    }
}
