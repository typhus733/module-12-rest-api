﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Time<T>(this int count, Func<int, T> func)
        {
            for (var i = 1; i <= count; i++) yield return func.Invoke(i);
        }    
    }
}
