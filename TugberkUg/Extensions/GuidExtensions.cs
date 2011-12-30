using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TugberkUg.Extensions {

    public static class GuidExtensions {

        /// <summary>
        /// Returns a dashless string with the charss accuired from the Guid
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static string ToDashlessGuidString(this Guid guid) {

            return guid.ToString().Replace("-", "");
        }

    }
}