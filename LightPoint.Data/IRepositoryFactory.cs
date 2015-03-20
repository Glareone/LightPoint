

namespace LightPoint.Data
{
    public interface IRepositoryFactory
    {
        IShopRepository GetShopRepository();

        IGoodsRepository GetGoodsRepository();
    }
}
