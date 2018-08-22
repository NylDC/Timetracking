using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tttests
{
    public sealed class UnexpectedStringException : Exception
    {
        public UnexpectedStringException(string expected, string have)
            : base(String.Format("Expected string \"{0}\" does not match \"{1}\"", expected, have)) {}
    }

    public class MyAssert {
        public static void Equals(string expected, string have)
        {
            if (!StringAssert.Equals(expected, have))
                throw new UnexpectedStringException(expected, have);
        }
    }
}
