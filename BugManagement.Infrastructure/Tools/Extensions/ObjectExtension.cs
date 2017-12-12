using System;

namespace BugManagement.Core.Tools.Extensions
{
    public static class ObjectExtension
    {
        /// <summary>
        /// Turn the object into specific type, it will return to the default value of this type when it failed
        /// </summary>
        /// <typeparam name="T"> Type </typeparam>
        /// <param name="value"> Object value </param>
        /// <returns> Returned type</returns>
        public static T CastTo<T>(this object value)
        {
            object result;
            Type type = typeof(T);
            try
            {
                if (type.IsEnum)
                {
                    result = Enum.Parse(type, value.ToString());
                }
                else if (type == typeof(Guid))
                {
                    result = Guid.Parse(value.ToString());
                }
                else
                {
                    result = Convert.ChangeType(value, type);
                }
            }
            catch
            {
                result = default(T);
            }

            return (T)result;
        }

        /// <summary>
        /// Turn the object into specific type, it will return to the given value of this type when it failed
        /// </summary>
        /// <typeparam name="T"> Type </typeparam>
        /// <param name="value"> Object value </param>
        /// <param name="defaultValue"> Default value that when it failed </param>
        /// <returns> Returned type </returns>
        public static T CastTo<T>(this object value, T defaultValue)
        {
            object result;
            Type type = typeof(T);
            try
            {
                result = type.IsEnum ? Enum.Parse(type, value.ToString()) : Convert.ChangeType(value, type);
            }
            catch
            {
                result = defaultValue;
            }
            return (T)result;
        }
    }
}
