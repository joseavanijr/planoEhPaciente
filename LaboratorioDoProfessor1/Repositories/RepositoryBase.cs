using LaboratorioDoProfessor1.Contexts;
using LaboratorioDoProfessor1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LaboratorioDoProfessor1.Repositories
{
    public abstract class RepositoryBase<TEntity>: IDisposable where TEntity:class
    {
        private readonly LabContext db;

        public RepositoryBase(LabContext db)
        {
            this.db = db;
        }

        public void Add(TEntity e)
        {
            db.Set<TEntity>().Add(e);
            db.SaveChanges();
        }

        public void Update(TEntity e)
        {
            db.Entry(e).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(TEntity e)
        {
            db.Set<TEntity>().Remove(e);
            db.SaveChanges();
        }

        public abstract IList<TEntity> FindAll();
        public abstract TEntity GetById(int id);

        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
