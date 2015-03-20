

namespace LightPoint.Data.SQL
{
    public class RepositoryFactory : IRepositoryFactory
    {

        /// <summary>
        /// Gets user repository
        /// </summary>
        /// <returns></returns>
        public IShopRepository GetShopRepository()
        {
            return new ShopRepository();
        }

        /// <summary>
        /// Gets bike repository
        /// </summary>
        /// <returns></returns>
        public IGoodsRepository GetGoodsRepository()
        {
            return new GoodsRepository();
        }
    }
}
