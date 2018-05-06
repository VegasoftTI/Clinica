using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> ObterTodos();
        IEnumerable<T> Obter(Expression<Func<T, bool>> filtro);
        void Incluir(T entidade);
        void Excluir(T entidade);
        void Alterar(T entidade);
      }
}