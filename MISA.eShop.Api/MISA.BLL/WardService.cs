using MISA.Common.Interfaces;
using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BLL
{
    public class WardService : BaseService<Ward>, IWardService
    {
        public WardService (IDbContext<Ward> dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Ward> GetWardByDistrictId(string districtId)
        {
            var sqlCommand = $"SELECT * FROM Ward w WHERE w.DistrictId = '{districtId}'";
            return dbconnection.Get(sqlCommand, System.Data.CommandType.Text);
        }
    }
}
