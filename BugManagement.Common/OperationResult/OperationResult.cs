using System;
using System.Collections.Generic;
using System.Text;

namespace BugManagement.Common.OperationResult
{
    /// <summary>
    /// Encapsulate operation result
    /// </summary>
    public class OperationResult
    {
        #region Property

        public OperationResultType ResultType { get; set; }
        public string Message { get; set; }
        public string LogInformation { get; set; }

        #endregion

        #region Methods

        public OperationResult(OperationResultType resultType)
        {
            ResultType = resultType;
        }
        
        public OperationResult(OperationResultType resultType, string message)
            : this(resultType)
        {
            Message = message;
        }

        public OperationResult(OperationResultType resultType, string message, string logInformation)
            : this(resultType, message)
        {
            LogInformation = logInformation;
        }

        #endregion
    }
}
