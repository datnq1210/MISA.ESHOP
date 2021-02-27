using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Interfaces
{
    public interface IDistrictService: IBaseService<District>
    {
        /// <summary>
        /// Hàm lấy dữ liệu quận/huyện theo mã tỉnh/thành phố
        /// </summary>
        /// <param name="provinceId">Mã tỉnh/thành phố</param>
        /// <returns>Danh sách các quận/huyện theo mã quốc gia</returns>
        /// CreatedBy: NQDAT(22/02/2021)
        IEnumerable<District> GetDistrictByProvinceId(string provinceId);
    }
}
