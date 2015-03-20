
using System.Collections.Generic;
using LightPoint.Domain.Entities;
using LightPoint.Domain.Services;

namespace LightPoint.Service
{
    using System;

    public class ShopService : IShopService
    {
        public List<Shop> FindAllShops()
        {
            var shops = Data.Context.Current.RepositoryFactory.GetShopRepository().FindAllShops();
            
            if (shops == null)
            {
                throw new InvalidOperationException("Shop do not exist in database");
            }

            return shops;
        }
    }
}
