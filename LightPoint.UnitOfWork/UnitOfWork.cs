using LightPoint.UnitOfWork.Interfaces;
using System;

namespace LightPoint.UnitOfWork
{


    public static class UnitOfWork
    {
        private static IUnitOfWorkFactory _unitOfWorkFactory;

        private static IUnitOfWork _innerUnitOfWork;

        public static IUnitOfWork Start()
        {
            if (_innerUnitOfWork != null)
                throw new InvalidOperationException("You cannot start more than one unit of work at the same time.");

            _unitOfWorkFactory = Context.Current.UnitOfWorkFactory;
            _innerUnitOfWork = _unitOfWorkFactory.Create();
            return _innerUnitOfWork;
        }


        /// <summary>
        /// Get Current Unitofwork Implementor
        /// </summary>
        public static IUnitOfWork Current
        {
            get
            {
                if (_innerUnitOfWork == null)
                    throw new InvalidOperationException("You are not in a unit of work.");
                return _innerUnitOfWork;
            }
            private set
            {
                _innerUnitOfWork = value;
            }
        }

        /// <summary>
        /// is UoW started and not stoped
        /// </summary>
        public static bool IsStarted
        {
            get { return _innerUnitOfWork != null; }
        }
        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="unitofwork"></param>
        public static void DisposeUnitOfWork(IUnitOfWork unitofwork)
        {
            Current = null;
        }
    }
}
