using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Interfaces
{
    public interface IStoreService: IBaseService<Store>
    {
        Store GetStoreById(string StoreId);
    }
}
