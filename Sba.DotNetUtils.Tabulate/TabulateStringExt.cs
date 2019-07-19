using System;

namespace Sba.DotNetUtils.Tabulate {
    public static class TabulateStringExt {
        public static string Tabulate(this string str, int length, char fill = ' ') {
            int absLength = Math.Abs(length);

            string paddedStr = length == 0
                ? ""
                : length > 0
                    ? str.PadLeft(absLength, fill)
                    : str.PadRight(absLength, fill);

            return paddedStr.Length > absLength && length > 0
                ? paddedStr.Substring(paddedStr.Length - absLength)
                : paddedStr.Substring(0, absLength);
        }
    }
}