using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResourcesProject.Helpers
{
    public static class EnumHelper
    {
        /// <summary>
        /// Returns IEnumerable<SelectListItem> from Enum names and values
        /// </summary>
        /// <param name="enumType">The enum type</param>
        /// <returns>IEnumerable<SelectListItem></returns>
        public static IEnumerable<SelectListItem> GetEnumListItems(this Type enumType)
        {
            if (!typeof(Enum).IsAssignableFrom(enumType))
            {
                throw new ArgumentException("Type must be enum");
            }

            var names = Enum.GetNames(enumType);
            var values = Enum.GetValues(enumType).Cast<int>();

            var items = names.Zip(values, (name, value) =>
                    new SelectListItem
                    {
                        Text = GetEnumName(enumType, name),
                        Value = value.ToString()
                    }
                );

            return items;
        }

        /// <summary>
        /// Gets the display name of the attribute if it is provided
        /// </summary>
        /// <param name="enumType">The Enum type</param>
        /// <param name="name">name of the attribute</param>
        /// <returns>string</returns>
        private static string GetEnumName(Type enumType, string name)
        {
            var result = name;

            var attribute = enumType
                .GetField(name)
                .GetCustomAttributes(inherit: false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            if (attribute != null)
            {
                result = attribute.GetName();
            }
            

            return result;
        }
    }
}