using System;
using System.Runtime.Serialization;

namespace BigBucksBankWithoutExceptions
{
    [Serializable]
    public class NotEnoughMoneyExeption : Exception
    {
        public NotEnoughMoneyExeption() : base("Cannot witdraw amount.")
        {
        }

        public NotEnoughMoneyExeption(string message) : base(message)
        {
        }

        public NotEnoughMoneyExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughMoneyExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}