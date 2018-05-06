using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Clinica.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Repository
{
     public class Repository<T> : IRepository<T> where T : class
    {
       private readonly IUnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Incluir(T entidade)
        {
            _unitOfWork.Contexto.Set<T>().Add(entidade);
        } 
        public void Excluir(T entidade)
        {
            T existing = _unitOfWork.Contexto.Set<T>().Find(entidade);
            if (existing != null) _unitOfWork.Contexto.Set<T>().Remove(existing);
        } 
        public IEnumerable<T> ObterTodos()
        {
            return _unitOfWork.Contexto.Set<T>().AsEnumerable<T>();
        } 
        public IEnumerable<T> Obter(Expression<Func<T, bool>> filtro)
        {
            return _unitOfWork.Contexto.Set<T>().Where(filtro).AsEnumerable<T>();
        } 
        public void Alterar(T entidade)
        {
            _unitOfWork.Contexto.Entry(entidade).State = EntityState.Modified;
            _unitOfWork.Contexto.Set<T>().Attach(entidade);
        }
    }
}