using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class Ward
    {
        /// <summary>
        /// Mã xã/phường
        /// </summary>
        public string WardId { get; set; }

        /// <summary>
        /// Tên xã phường
        /// </summary>
        public string WardName { get; set; }

        /// <summary>
        /// Mã quận/huyện của xã phường
        /// </summary>
        public string DistrictId { get; set; }
    }
}
