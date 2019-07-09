using System;

namespace Sba.DotNetUtils.Tabulate {
    public static class TabulateStringExt {
        public static string Tabulate(this string str, int length, char fill = ' ') {
            int absLength = Math.Abs(length);

            return length == 0
                ? ""
                : (length > 0
                    ? str.PadLeft(absLength, fill)
                    : str.PadRight(absLength, fill)).Substring(0, absLength);
        }
    }
}