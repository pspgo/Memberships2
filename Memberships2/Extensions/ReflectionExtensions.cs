using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberships2.Extensions
{
    public static class ReflectionExtensions // static - always one instance
    {
        public static string GetPropertyValue<T>(this T item, string propertyName) // extension method; T - we will work on any object
        {
            return item.GetType()
                .GetProperty(propertyName)
                .GetValue(item, null).ToString();
        }
    }
}