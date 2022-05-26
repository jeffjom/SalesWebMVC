using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityExcption : ApplicationException
    {
        public IntegrityExcption(string message) : base(message)
        {
        }
    }
}
