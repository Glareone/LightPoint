using LightPoint.Domain.Entities;

namespace LightPoint.Domain.Services
{
    using System.Collections.Generic;

    public interface IShopService
    {
        List<Shop> FindAllShops();
    }
}
