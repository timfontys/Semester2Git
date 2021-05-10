using System;
using System.Runtime.Serialization;

namespace BigBucksBankWithoutExceptions
{
    [Serializable]
    public class NoInformationGivenExeption : Exception
    {
        public NoInformationGivenExeption() : base("Please fill in the textboxes")
        {
        }

        public NoInformationGivenExeption(string message) : base(message)
        {
        }

        public NoInformationGivenExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoInformationGivenExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}