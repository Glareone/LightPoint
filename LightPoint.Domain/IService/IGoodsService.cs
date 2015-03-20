using LightPoint.Domain.Entities;

namespace LightPoint.Domain.Services
{
    using System.Collections.Generic;

    public interface IGoodsService
    {
        List<Goods> GetAllGoodsByShopId(int shopid);

        List<Goods> GetAllGoods(); 
    }
}
