using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugberkUg.Extensions {

    public static class StringExtensions {

        /// <summary>
        /// Normalize the string in order it to be a better url string (This does not URLEncode, just replace the chars).
        /// </summary>
        /// <param name="str"></param>
        /// <returns>URLNormalized string</returns>
        //Created on 2011, 07.27. The URLs will be generated from this dynamically. So, changing this code could result broken URLs.
        public static string URLNormalize(this string str) { 

            string value = (String)str.ToLower();
            
            value = value.Replace(" / ", "-");
            value = value.Replace(" - ", "-");
            value = value.Replace("=\"", "-");
            value = value.Replace(" = ", "-");
            value = value.Replace("=", "-");
            value = value.Replace(" \" ", "-");
            value = value.Replace(" \"", "-");
            value = value.Replace("\" ", "-");
            value = value.Replace(" . ", "-");
            value = value.Replace(" .", "");
            value = value.Replace(". ", "-");
            value = value.Replace(" ? ", "-");
            value = value.Replace(" ?", "");
            value = value.Replace(" ! ", "-");
            value = value.Replace(" !", "");
            value = value.Replace(" | ", "-");
            value = value.Replace(" |", "");
            value = value.Replace(" > ", "-");
            value = value.Replace(" >", "");
            value = value.Replace(" < ", "-");
            value = value.Replace(" <", "");

            value = value.Replace(" ", "-");
            value = value.Replace(",", "");
            value = value.Replace("|", "-");
            value = value.Replace("&&", "");
            value = value.Replace("&amp;", "and");
            value = value.Replace("&", "and");
            value = value.Replace("(", "");
            value = value.Replace(")", "");
            value = value.Replace("!", "");
            value = value.Replace("'", "-");
            value = value.Replace("\"", "-");
            value = value.Replace("\\", "-");
            value = value.Replace("/", "-");
            value = value.Replace(":", "-");
            value = value.Replace(".", "-");
            value = value.Replace("c#", "c-sharp");
            value = value.Replace("#", "sharp");
            value = value.Replace("{", "");
            value = value.Replace("}", "");
            value = value.Replace("[", "");
            value = value.Replace("]", "");
            value = value.Replace("?", "-");
            value = value.Replace("*", "");
            value = value.Replace(";", "");

            #region turkish chars

            value = value.Replace("ı", "i");
            value = value.Replace("ü", "u");
            value = value.Replace("ö", "o");
            value = value.Replace("ğ", "g");
            value = value.Replace("ç", "c");
            value = value.Replace("ş", "s");

            #endregion

            string[] trimmedChars = new string[] { "-", " ", "...", "." };

            for (int i = 0; i < trimmedChars.Length; i++) {

                var v = trimmedChars[i].ToString();

                if (value.StartsWith(v))
                    value = value.TrimStart(new char[] { char.Parse(v) });

                if (value.EndsWith(v))
                    value = value.TrimEnd(new char[] { char.Parse(v) });

            }

            value = value.Trim();

            return value;
        }

        public static string PadTo(this string str, int length) {

            if (str.Length < length) {

                int _strlght = str.Length;
                for (int i = 0; i < length - _strlght; i++) {

                    str = "0" + str;
                }
            }

            return str;
        }

    }
}