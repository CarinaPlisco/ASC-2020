using System;
using System.Runtime.Serialization;

namespace ASC_Conversie
{
    [Serializable]
    internal class InccorectBaseException : Exception
    {
        public InccorectBaseException()
        {
        }

        public InccorectBaseException(string message) : base(message)
        {
        }

        public InccorectBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InccorectBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}