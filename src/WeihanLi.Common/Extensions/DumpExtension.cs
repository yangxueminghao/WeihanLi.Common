﻿using System;
using WeihanLi.Common;

// ReSharper disable once CheckNamespace
namespace WeihanLi.Extensions
{
    public static class DumpExtension
    {
        private const string NullValue = "(null)";

        public static void Dump<T>(this T t) => Dump(t, Console.WriteLine);

        public static void Dump<T>(this T t, Action<string> dumpAction)
        {
            Guard.NotNull(dumpAction, nameof(dumpAction))
                .Invoke(t is null ? NullValue : t.ToJsonOrString());
        }

        public static void Dump<T>(this T t, Action<string> dumpAction, Func<T, string> dumpValueFactory)
        {
            Guard.NotNull(dumpAction, nameof(dumpAction))
                .Invoke(Guard.NotNull(dumpValueFactory, nameof(dumpValueFactory)).Invoke(t));
        }
    }
}