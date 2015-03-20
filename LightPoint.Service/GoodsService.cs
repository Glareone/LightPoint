using LightPoint.Domain.Entities;
using System.Collections.Generic;
using LightPoint.Domain.Services;

namespace LightPoint.Service
{
    using System;

    public class GoodsService : IGoodsService
    {
        public List<Goods> GetAllGoodsByShopId(int shopid)
        {
            return Data.Context.Current.RepositoryFactory.GetGoodsRepository().GetAllGoodsByShopId(shopid);
        }

        public List<Goods> GetAllGoods()
        {
            var goods = Data.Context.Current.RepositoryFactory.GetGoodsRepository().GetAllGoods();

            if (goods == null)
            {
                throw new Exception("goods is not exist in database");
            }

            return goods;
        }
    }
}
