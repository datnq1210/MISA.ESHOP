using MISA.Common.Entities;
using MISA.Common.Enumrations;
using MISA.Common.Interfaces;
using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.BLL
{
    public class StoreService : BaseService<Store>, IStoreService
    {
        public StoreService(IDbContext<Store> dbContext) : base(dbContext)
        {

        }

        public Store GetStoreById(string StoreId)
        {
            var sqlCommand = $"SELECT * FROM Store WHERE StoreId = '{StoreId}'";
            return dbconnection.Get(sqlCommand, System.Data.CommandType.Text).FirstOrDefault();
        }

        public override ServiceResult Update(string StoreId,Store store)
        {
            var serviceResult = new ServiceResult();
            //Kiểm tra trường bắt buộc nhập
            var properties = store.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(store);
                if (property.IsDefined(typeof(Required), true))
                {
                    if (propertyValue == null || propertyValue.ToString().Trim() == String.Empty)
                    {
                        var requiredAttr = property.GetCustomAttributes(typeof(Required), true).FirstOrDefault();
                        if (requiredAttr != null)
                        {
                            var errMsg = (requiredAttr as Required).errorMsg;
                            serviceResult.MISACode = (int)MISACode.BadRequest;
                            serviceResult.userMsg = errMsg;
                            return serviceResult;
                        }
                    }
                }
            }
            var sqlCommand = $"SELECT * FROM Store WHERE StoreCode = '{store.StoreCode}' AND StoreId != '{StoreId}'";
            var res = dbconnection.Get(sqlCommand, System.Data.CommandType.Text).FirstOrDefault();
            if (res != null)
            {
                serviceResult.Data = res;
                serviceResult.MISACode = (int)MISACode.BadRequest;
                serviceResult.userMsg = Common.Properties.Resources.UserMsg_Duplicate_StoreCode;
                return serviceResult;
            }
            return base.Update(StoreId, store);
        }
    }
}
