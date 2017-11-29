using System;
using System.Runtime.Serialization;

namespace BugManagement.Infrastructure.Tools.Exceptions
{
    [Serializable]
    public class DataAccessException : Exception
    {
        public DataAccessException()
        {

        }

        public DataAccessException(string message) : base(message)
        {

        }

        public DataAccessException(string message, Exception inner) : base(message, inner)
        {

        }

        public DataAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}