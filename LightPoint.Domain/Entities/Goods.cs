using System.Collections.Generic;
using LightPoint.Domain.Services;

namespace LightPoint.Domain.Entities
{
    public class Goods
    {
        public int? Shopid { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public static List<Goods> GetAllGoods()
        {
            return ServiceLocator.ServiceLocator.Resolve<IGoodsService>().GetAllGoods();
        }

        public static List<Goods> GetGoodsByShopId(int shopid)
        {
            return ServiceLocator.ServiceLocator.Resolve<IGoodsService>().GetAllGoodsByShopId(shopid);
        }
    }
}
