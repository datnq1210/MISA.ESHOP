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
    public class WardsController : BaseController<Ward>
    {
        IWardService _wardService;

        public WardsController(IWardService wardService):base(wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("{districtId}")]
        public IEnumerable<Ward> Get(string districtId)
        {
            return _wardService.GetWardByDistrictId(districtId);
        }
    }
}
