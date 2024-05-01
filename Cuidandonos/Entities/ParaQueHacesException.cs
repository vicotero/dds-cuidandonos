using System;
using System.Runtime.Serialization;

namespace Entities
{
    [Serializable]
    internal class ParaQueHacesException : Exception
    {
        public ParaQueHacesException()
        {
        }

        public ParaQueHacesException(string message) : base(message)
        {
        }

        public ParaQueHacesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParaQueHacesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}