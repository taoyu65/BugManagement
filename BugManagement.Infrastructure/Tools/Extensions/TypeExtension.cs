using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace BugManagement.Infrastructure.Tools.Extensions
{
    public static class TypeExtension
    {
        public static bool IsNumeric(this Type type)
        {
            return type == typeof(Byte)
                || type == typeof(Int16)
                || type == typeof(Int32)
                || type == typeof(Int64)
                || type == typeof(SByte)
                || type == typeof(UInt16)
                || type == typeof(UInt32)
                || type == typeof(UInt64)
                || type == typeof(Decimal)
                || type == typeof(Double)
                || type == typeof(Single);
        }

        /// <summary>
        /// Get member's description information
        /// </summary>
        /// <param name="member">object of member</param>
        /// <param name="inherit">if search member inherit chain</param>
        /// <returns>return description</returns>
        public static string ToDescription(this MemberInfo member, bool inherit = false)
        {
            DescriptionAttribute desc = member.GetAttribute<DescriptionAttribute>(inherit);
            return desc?.Description;
            //return desc == null ? null : desc.Description;
        }

        /// <summary>
        /// Check attribute from a member object if exist
        /// </summary>
        /// <typeparam name="T">Type of attribute</typeparam>
        /// <param name="memberInfo">Member</param>
        /// <param name="inherit">If check from inherit</param>
        /// <returns>If exist</returns>
        public static bool AttributeExists<T>(this MemberInfo memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.GetCustomAttributes(typeof(T), inherit).Any(m => (m as T) != null);
        }

        /// <summary>
        /// Get attribute
        /// </summary>
        /// <typeparam name="T">Type of attribute</typeparam>
        /// <param name="memberInfo">Member</param>
        /// <param name="inherit">If check from inherit</param>
        /// <returns>Return type from the first of attributes</returns>
        public static T GetAttribute<T>(this MemberInfo memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.GetCustomAttributes(typeof(T), inherit).SingleOrDefault() as T;
        }

        /// <summary>
        /// Get attributes
        /// </summary>
        /// <typeparam name="T">Type of attribute</typeparam>
        /// <param name="memberInfo">Member</param>
        /// <param name="inherit">If check from inherit</param>
        /// <returns>Return array of type</returns>
        public static T[] GetAttributes<T>(this MemberInfo memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.GetCustomAttributes(typeof(T), inherit).Cast<T>().ToArray();
        }

    }
}
