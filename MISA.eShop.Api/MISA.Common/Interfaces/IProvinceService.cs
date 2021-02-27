using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Interfaces
{
    public interface IProvinceService: IBaseService<Province>
    {   
        /// <summary>
        /// Hàm lẫy dữ liệu tỉnh/thành phố theo mã quốc gia
        /// </summary>
        /// <param name="countryId">Mã quốc gia</param>
        /// <returns>Danh sách các tỉnh thành phố theo quốc gia</returns>
        /// CreatedBy: NQDAT (22/02/2021)
        IEnumerable<Province> GetProvinceByCountryId(string countryId);
    }
}
