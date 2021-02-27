using MISA.Common.Interfaces;
using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BLL
{
    public class DistrictService : BaseService<District>, IDistrictService
    {   

        public DistrictService(IDbContext<District> dbContext) : base(dbContext)
        {

        }
        public IEnumerable<District> GetDistrictByProvinceId(string provinceId)
        {
            var sqlCommand = $"SELECT * FROM District d WHERE d.ProvinceId = '{provinceId}'";
            return dbconnection.Get(sqlCommand, System.Data.CommandType.Text);
        }
    }
}
