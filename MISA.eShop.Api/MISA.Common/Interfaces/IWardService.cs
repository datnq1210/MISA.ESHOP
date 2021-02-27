using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Interfaces
{
    public interface IWardService: IBaseService<Ward>
    {
        /// <summary>
        /// Hàm lấy dữ liệu xã/phường theo mã quận/huyện
        /// </summary>
        /// <param name="districtId">Mã quận/huyện</param>
        /// <returns>Danh sách xã/phường theo quận/huyện</returns>
        /// CreatedBy: NQDAT (22/02/2021)
        IEnumerable<Ward> GetWardByDistrictId(string districtId);
    }
}
