using NSE.Core.Contracts;
using System;

namespace NSE.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAgregateRoot
    {

    }
}
