using System.Collections.Generic;
using LightPoint.Domain.Entities;

namespace LightPoint.ASPMVC.Models
{
    public class ShopViewModels
    {
        public List<Shop> GetAllShops()
        {
            return Shop.GetAllShops();
        }
    }
}