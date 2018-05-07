using System;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Repository.Interfaces
{
   
    public interface IUnitOfWork : IDisposable
    {
        DbContext Contexto { get;  }
        void Commit();
        object GetRepository<T>();
    }
}