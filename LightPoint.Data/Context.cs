using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightPoint.Data
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
        /// Gets current <see cref="IRepositoryFactory"/>
        /// </summary>
        public IRepositoryFactory RepositoryFactory { get; set; }
    }
