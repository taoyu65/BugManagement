using BugManagement.Core.Tools.Exceptions;
using BugManagement.Core.Tools.Extensions;
using System;

namespace BugManagement.Core.Tools.Helpers
{
    public static class PublicHelper
    {
        #region Public Method

        /// <summary>
        /// Check parameter if valid, cannot be less than 0. Reference type cannot be null.
        /// </summary>
        /// <param name="arg"> pre-check parameter</param>
        /// <param name="argName"> name of pre-check parameter </param>
        /// <param name="canZero"> if can be 0 </param>
        /// <exception cref="ComponentException" />
        public static void CheckArgument(object arg, string argName, bool canZero = false)
        {
            if (arg == null)
            {
                ArgumentNullException e = new ArgumentNullException(argName);
                throw ThrowComponentException(string.Format("param {0} is null causes exception.", argName), e);
            }
            Type type = arg.GetType();
            if (type.IsValueType && type.IsNumeric())
            {
                bool flag = !canZero ? arg.CastTo(0.0) <= 0.0 : arg.CastTo(0.0) < 0.0;
                if (flag)
                {
                    ArgumentOutOfRangeException e = new ArgumentOutOfRangeException(argName);
                    throw ThrowComponentException(string.Format("param {0} is not in the valid range, please check log information.", argName), e);
                }
            }
            if (type == typeof(Guid) && (Guid)arg == Guid.Empty)
            {
                ArgumentNullException e = new ArgumentNullException(argName);
                throw ThrowComponentException(string.Format("param {0} is null causes the exception", argName), e);
            }
        }

        /// <summary>
        /// Throw the exception to the invoking layer
        /// </summary>
        /// <param name="msg"> Custom information of exception </param>
        /// <param name="e"> The instance of actual causes the exception </param>
        public static ComponentException ThrowComponentException(string msg, Exception e = null)
        {
            if (string.IsNullOrEmpty(msg) && e != null)
            {
                msg = e.Message;
            }
            else if (string.IsNullOrEmpty(msg))
            {
                msg = "Unknown exception.";
            }
            return e == null ? new ComponentException(string.Format("Component invalid：{0}", msg)) : new ComponentException(string.Format("Component invalid：{0}", msg), e);
        }

        /// <summary>
        /// Throw DAL layer exception to a invoking layer
        /// </summary>
        /// <param name="msg"> Message </param>
        /// <param name="e">  </param>
        public static DataAccessException ThrowDataAccessException(string msg, Exception e = null)
        {
            if (string.IsNullOrEmpty(msg) && e != null)
            {
                msg = e.Message;
            }
            else if (string.IsNullOrEmpty(msg))
            {
                msg = "Unknown exception.";
            }
            return e == null
                ? new DataAccessException(string.Format("DAL layer exception：{0}", msg))
                : new DataAccessException(string.Format("DAL layer exception：{0}", msg), e);
        }

        /// <summary>
        /// Throw BLL layer exception to a invoking layer
        /// </summary>
        /// <param name="msg"> Message </param>
        /// <param name="e">  </param>
        public static BusinessException ThrowBusinessException(string msg, Exception e = null)
        {
            if (string.IsNullOrEmpty(msg) && e != null)
            {
                msg = e.Message;
            }
            else if (string.IsNullOrEmpty(msg))
            {
                msg = "Unknown exception.";
            }
            return e == null ? new BusinessException(string.Format("BLL layer exception：{0}", msg)) : new BusinessException(string.Format("BLL layer exception：{0}", msg), e);
        }

        #endregion
    }
}
