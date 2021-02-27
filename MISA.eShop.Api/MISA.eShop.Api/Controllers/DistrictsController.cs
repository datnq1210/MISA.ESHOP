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
    public class DistrictsController : BaseController<District>
    {
        IDistrictService _districtService;

        public DistrictsController(IDistrictService districtService):base(districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("{provinceId}")]
        public IEnumerable<District> Get(string provinceId)
        {
            return _districtService.GetDistrictByProvinceId(provinceId);
        }
    }
}
