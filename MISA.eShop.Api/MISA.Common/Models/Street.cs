using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class Street
    {
        /// <summary>
        /// Mã đường phố
        /// </summary>
        public string StreetId { get; set; }

        /// <summary>
        /// Tên đường phố
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Mã xã/phường của đường phô
        /// </summary>
        public string WardId { get; set; }
    }
}
