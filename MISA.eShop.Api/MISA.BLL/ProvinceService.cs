using MISA.Common.Interfaces;
using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BLL
{
    public class ProvinceService : BaseService<Province>, IProvinceService
    {
        public ProvinceService(IDbContext<Province> dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Province> GetProvinceByCountryId(string countryId)
        {
            var sqlCommand = $"SELECT * FROM Province p WHERE p.CountryId = '{countryId}'";
            return dbconnection.Get(sqlCommand, System.Data.CommandType.Text);
        }
    }
}
