using System.Collections.Generic;
using LightPoint.Domain.Entities;

namespace LightPoint.Data
{
    public interface IShopRepository
    {
        List<Shop> FindAllShops();
    }
}
