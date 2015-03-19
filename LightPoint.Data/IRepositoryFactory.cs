

namespace LightPoint.Data
{
    public interface IRepositoryFactory
    {
        /// <summary>
        /// Gets user repository
        /// </summary>
        /// <returns></returns>
        IShopRepository GetShopRepository();

        IGoodsRepository GetGoodsRepository();
    }
}
