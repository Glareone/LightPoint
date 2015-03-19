

namespace LightPoint.Domain
{
    public sealed class Context
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Context"/> class
        /// </summary>
        private Context()
        {
        }

        /// <summary>
        /// Gets current execution context
        /// </summary>
        public static Context Current = new Context();

        /// <summary>
        /// Gets current <see cref="IUserService"/>
        /// </summary>
        public IShopService UserService { get; set; }
        public IGoodsService BikeService { get; set; }

    }
}
