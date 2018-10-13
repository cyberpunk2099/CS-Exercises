﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace FbInterviewQuestion_MsgDecode
{
    public static class Calc
    {
        /// <summary>
        /// Mapping
        /// </summary>
        static readonly string[] Table =
            { "1", "2", "3", "4", "5", "6", "7", "8", "9",
              "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
              "20", "21", "22", "23", "24", "25", "26"
            };

        public static BigInteger GetNumberOfDecodes(string code)
        {
            var start = Environment.TickCount;
            try
            {
                return GetNumberOfDecodes(code, new Dictionary<int, BigInteger>());
            }
            finally
            {
                Debug.WriteLine($"{Environment.TickCount - start}ms");
            }
        }

        static BigInteger GetNumberOfDecodes(string s, Dictionary<int, BigInteger> memo)
        {
            var len = s.Length;
            if (len == 0 || s == "0") return 0;
            if (memo.ContainsKey(len)) return memo[len];
            BigInteger result = 0;
            switch (len)
            {
                case 1:
                    if (Table.Contains(s)) result++;
                    break;
                case 2:
                    if (Table.Contains(s))
                        result++;
                    if (Table.Contains(s.Substring(0, 1)) && Table.Contains(s.Substring(1, 1)))
                        result++;
                    break;
                default:
                    if (Table.Contains(s.Substring(0, 1)))
                        result = GetNumberOfDecodes(s.Substring(1), memo);
                    if (Table.Contains(s.Substring(0, 2)))
                        result += GetNumberOfDecodes(s.Substring(2), memo);
                    break;
            }
            memo.Add(len, result);
            return result;
        }
    }
}
