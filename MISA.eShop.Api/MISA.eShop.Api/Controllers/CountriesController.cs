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
    public class CountriesController : BaseController<Country>
    {
        public CountriesController(ICountryService countryService) : base(countryService)
        {

        }
    }
}
