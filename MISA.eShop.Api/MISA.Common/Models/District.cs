using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class District
    {
        /// <summary>
        /// Mã quận/huyện
        /// </summary>
        public string DistrictId { get; set; }

        /// <summary>
        /// Tên quận huyện
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// Mã tỉnh/thành phố của quận/huyện
        /// </summary>
        public string ProvinceId { get; set; }
    }
}
