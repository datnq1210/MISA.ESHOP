using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class Province
    {
        /// <summary>
        /// Mã tỉnh/thành phố
        /// </summary>
        public string ProvinceId { get; set; }

        /// <summary>
        /// Tên tỉnh/thành phố
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// Mã quốc gia của tỉnh/thành phố
        /// </summary>
        public string CountryId { get; set; }
    }
}
