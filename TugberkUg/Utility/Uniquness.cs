using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TugberkUg.Extensions;

namespace TugberkUg.Utility {

    public class Uniquness {

        public static string GetUniqueTimeValueString() {

            StringBuilder str = new StringBuilder();

            str.Append(
                string.Format("{0}{1}{2}{3}{4}{5}{6}",
                    DateTime.Today.ToString("yy"),
                    DateTime.Today.ToString("MM"),
                    DateTime.Today.ToString("dd"),
                    DateTime.Now.ToString("HH"),
                    DateTime.Now.ToString("mm"),
                    DateTime.Now.ToString("ss"),
                    DateTime.Now.Millisecond.ToString().PadTo(3)
                )
            );

            return str.ToString();
        }
    }
}