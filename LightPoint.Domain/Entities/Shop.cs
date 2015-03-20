using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightPoint.Domain.Services;

namespace LightPoint.Domain.Entities
{


    public class Shop
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime WorkingStartTime { get; set; }

        public DateTime WorkingEndTime { get; set; }

        public static List<Shop> GetAllShops()
        {
            return ServiceLocator.ServiceLocator.Resolve<IShopService>().FindAllShops();
        }

    }
}
