using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class Store
    {
        #region Properties
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid StoreId { get; set; }

        /// <summary>
        /// Mã cửa hàng
        /// </summary>
        [Required("Mã cửa hàng", "Mã cửa hàng không được phép để trống!")]
        [Duplicated("Mã cửa hàng", "Mã cửa hàng đã tồn tại trên hệ thống!")]
        public string StoreCode { get; set; }

        /// <summary>
        /// Tên cửa hàng
        /// </summary>
        [Required("Tên cửa hàng", "Tên cửa hàng không được phép để trống!")]
        public string StoreName { get; set; }


        /// <summary>
        /// Địa chỉ cửa hàng
        /// </summary>
        [Required("Địa chỉ cửa hàng", "Địa chỉ cửa hàng không được phép để trống!")]
        public string Address { get; set; }

        /// <summary>
        /// Số điện thoại cửa hàng
        /// </summary>
        public int PhoneNumber { get; set; }

        /// <summary>
        /// Mã số thuế cửa hàng
        /// </summary>
        public int StoreTaxCode { get; set; }

        /// <summary>
        /// Trạng thái cửa hàng
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Mã quốc gia
        /// </summary>
        public string CountryId { get; set; }

        /// <summary>
        /// Tên quốc gia
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Mã tỉnh/thành phố
        /// </summary>
        public string ProvinceId { get; set; }

        /// <summary>
        /// Tên tỉnh/thành phố
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// Mã quận/huyện
        /// </summary>
        public string DistrictId { get; set; }

        /// <summary>
        /// Tên quận/huyện
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// Mã xã/phường
        /// </summary>
        public string WardId { get; set; }

        /// <summary>
        /// Tên xã/phường
        /// </summary>
        public string WardName { get; set; }

        /// <summary>
        /// Mã đường/phố
        /// </summary>
        public string StreetId { get; set; }

        /// <summary>
        /// Tên đường/phố
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Ngày tạo bản ghi
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo bản ghi
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày chỉnh sửa bản ghi
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người chỉnh sửa bản ghi
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion
    }
}
