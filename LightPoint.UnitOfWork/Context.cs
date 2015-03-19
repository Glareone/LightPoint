using LightPoint.UnitOfWork.Interfaces;

namespace LightPoint.UnitOfWork
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
        /// Gets current UnitofWorkFactories
        /// </summary>
        public IUnitOfWorkFactory UnitOfWorkFactory { get; set; }
    }
}
