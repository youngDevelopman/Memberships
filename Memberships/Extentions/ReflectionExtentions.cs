﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberships.Extentions
{
    public static class ReflectionExtentions
    {
        public static string GetPropertyValue<T>(this T item,string propertyName)
        {
            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
        }
    }
}