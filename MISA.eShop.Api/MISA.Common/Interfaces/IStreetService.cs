using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Interfaces
{
    public interface IStreetService: IBaseService<Street>
    {
        /// <summary>
        /// Hàm lấy dữ liệu đường/phố theo mã xã/phường
        /// </summary>
        /// <param name="WardId">Mã xã phường</param>
        /// <returns>Dah sách đường/phố theo xã/phường</returns>
        IEnumerable<Street> GetStreetByWardId(string WardId);
    }
}
