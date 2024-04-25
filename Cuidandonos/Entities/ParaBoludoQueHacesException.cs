using System;
using System.Runtime.Serialization;

namespace Entities
{
    [Serializable]
    internal class ParaBoludoQueHacesException : Exception
    {
        public ParaBoludoQueHacesException()
        {
        }

        public ParaBoludoQueHacesException(string message) : base(message)
        {
        }

        public ParaBoludoQueHacesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParaBoludoQueHacesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}