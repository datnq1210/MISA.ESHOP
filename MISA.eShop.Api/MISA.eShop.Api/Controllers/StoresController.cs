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
    public class StoresController : BaseController<Store>
    {
        IStoreService _storeService;
        public StoresController(IStoreService storeService) : base(storeService)
        {
            _storeService = storeService;
        }
        [HttpGet("{StoreId}")]
        public Store Get(string StoreId)
        {
            return _storeService.GetStoreById(StoreId);
        }
    }
}
