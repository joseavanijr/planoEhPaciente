using LaboratorioDoProfessor1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LaboratorioDoProfessor1.Services
{
    public class ServiceBase<TEntity> : IDisposable where TEntity : class
    {
        private readonly RepositoryBase<TEntity> repositorio;

        public ServiceBase(RepositoryBase<TEntity> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Dispose()
        {
            repositorio.Dispose();
        }

        public void Adicionar(TEntity obj)
        {
            repositorio.Add(obj);
        }

        public void Alterar(TEntity obj)
        {
            repositorio.Update(obj);
        }

        public void Apagar(TEntity obj)
        {
            repositorio.Delete(obj);
        }

        public IList<TEntity> BuscarTodos()
        {
            return repositorio.FindAll();
        }

        public TEntity BuscarPorId(int id)
        {
            return repositorio.GetById(id);
        }

    }
}
