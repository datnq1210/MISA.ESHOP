using MISA.Common.Interfaces;
using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BLL
{
    public class StreetService : BaseService<Street>, IStreetService
    {
        public StreetService(IDbContext<Street> dbContext): base(dbContext)
        {

        }
        public IEnumerable<Street> GetStreetByWardId(string WardId)
        {
            var sqlCommand = $"SELECT * FROM Street s WHERE s.WardId = '{WardId}'";
            return dbconnection.Get(sqlCommand, System.Data.CommandType.Text);
        }
    }
}
