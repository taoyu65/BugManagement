using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BugManagement.Core.Tools.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// Get enum item description
        /// </summary>
        /// <param name="enumeration"> </param>
        /// <returns> </returns>
        public static string ToDescription(this Enum enumeration)
        {
            Type type = enumeration.GetType();
            MemberInfo[] members = type.GetMember(enumeration.CastTo<string>());
            if (members.Length > 0)
            {
                return members[0].ToDescription();
            }
            return enumeration.CastTo<string>();
        }
    }
}
