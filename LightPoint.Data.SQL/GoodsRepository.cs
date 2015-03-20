using System.Collections.Generic;

namespace LightPoint.Data.SQL
{
    public class GoodsRepository : IGoodsRepository
    {
        public List<Domain.Entities.Goods> GetAllGoodsByShopId(int shopid)
        {
            return new List<Domain.Entities.Goods>();
        }

        public List<Domain.Entities.Goods> GetAllGoods()
        {
            return new List<Domain.Entities.Goods>();
        }
    }
}
