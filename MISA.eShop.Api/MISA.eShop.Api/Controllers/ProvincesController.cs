using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Common.Interfaces;
using MISA.Common.Models;
using MISA.CukCuk.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Eshop.Api.Controllers
{
    public class ProvincesController : BaseController<Province>
    {
        IProvinceService _provinceService;
        public ProvincesController(IProvinceService provinceService) : base(provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("{countryId}")]
        public IEnumerable<Province> Get(string countryId)
        {
            return _provinceService.GetProvinceByCountryId(countryId);
        }
    }
}
