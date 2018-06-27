﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Extentions
{
    public static class ICollectionExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>
            (this ICollection<T> items, int selectedValue)
        {
            return from item in items
                   select new SelectListItem
                   {
                       Text = item.GetPropertyValue("Value"),
                       Value = item.GetPropertyValue("Id"),
                       Selected = item.GetPropertyValue("Value").Equals(selectedValue.ToString())
                   };
        }
    }
}