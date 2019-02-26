using System;

namespace WebApplicationWithDI
{
    internal class Test : ITest
    {
        public string X()
        {
            return "abc : " + DateTime.Now;
        }
    }
}