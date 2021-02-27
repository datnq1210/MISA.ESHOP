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
    public class StreetsController : BaseController<Street>
    {
        IStreetService _StreetService;

        public StreetsController(IStreetService StreetService) : base(StreetService)
        {
            _StreetService = StreetService;
        }

        [HttpGet("{wardId}")]
        public IEnumerable<Street> Get(string wardId)
        {
            return _StreetService.GetStreetByWardId(wardId);
        }
    }
}
