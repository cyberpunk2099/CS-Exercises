using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace FbInterviewQuestion_MsgDecode
{
    public static class Helper
    {
        public static string GetDecodeCount(string code)
        {
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

    }
}
