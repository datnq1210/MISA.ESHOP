using MISA.Common.Interfaces;
using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BLL
{
    public class CountryService: BaseService<Country>,ICountryService
    {
        public CountryService(IDbContext<Country> dbContext) : base(dbContext)
        {

        }
    }
}
