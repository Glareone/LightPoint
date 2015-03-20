using System.Collections.Generic;
using LightPoint.Domain.Entities;

namespace LightPoint.Data
{
    public interface IGoodsRepository
    {
        List<Goods> GetAllGoodsByShopId(int shopid);

        List<Goods> GetAllGoods();
    }
}
