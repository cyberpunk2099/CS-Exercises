using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace FbInterviewQuestion_MsgDecode
{
    public static class Helper
    {
        public static string GetDecodeCount(string code)
        {
            if (string.IsNullOrWhiteSpace(code) || code[0] == '0')
                throw new FormatException(
                    $"Cannot decode {(code == null ? "null" : $"'{code}'")}");
            var start = Environment.TickCount;
            try
            {
                return Calc
                    .GetDecodeCount(code, new Dictionary<int, BigInteger>())
                    .ToString("#,##0");
            }
            finally
            {
                Debug.WriteLine($"{Environment.TickCount - start}ms");
            }
        }

        #region extension methods
        public static bool Contains(this string[] list, char c)
            => list.Contains(c.ToString());

        public static bool Contains(this string[] list, char c1, char c2)
            => list.Contains(c1.ToString() + c2.ToString());
        #endregion
    }
}
