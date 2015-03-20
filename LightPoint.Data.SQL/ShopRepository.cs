using System.Collections.Generic;

namespace LightPoint.Data.SQL
{
    public class ShopRepository : IShopRepository
    {
        public List<Domain.Entities.Shop> FindAllShops()
        {
            return new List<Domain.Entities.Shop>();
        }
    }
}
