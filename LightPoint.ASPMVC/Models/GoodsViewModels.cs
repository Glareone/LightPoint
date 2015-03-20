using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LightPoint.Domain.Entities;

namespace LightPoint.ASPMVC.Models
{
    public class GoodsViewModels
    {
        public List<Goods> GetGoodsByShopId(int shopid)
        {
            return Goods.GetGoodsByShopId(shopid);
        }

        public List<Goods> GetAllGoods()
        {
            return Goods.GetAllGoods();
        }
    }
}