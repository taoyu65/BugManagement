using System;
using System.Runtime.Serialization;

namespace BugManagement.Core.Tools.Exceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException()
        {

        }

        public BusinessException(string message) : base(message)
        {

        }

        public BusinessException(string message, Exception inner) : base(message, inner)
        {

        }
        
        public BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
