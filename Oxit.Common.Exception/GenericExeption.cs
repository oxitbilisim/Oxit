using System;

namespace Oxit.Common.Exception
{
    public class GenericExeption : System.Exception
    {
        public GenericExeption()
        {
        }

        public GenericExeption(string message)
            : base(message)
        {
        }

        public GenericExeption(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
