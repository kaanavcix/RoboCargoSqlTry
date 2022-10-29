using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<Tentity, TContext> : IEntityRepositoryDal<Tentity> where Tentity : class, IEntity where TContext : DbContext, new()
        //eğer iki tane şeyi düzenelemk istersek where komutlarını kullancıaz


    {
        public void Add(Tentity entity)
        {
           using(TContext context = new TContext())
            {
                var addToData = context.Entry(entity);
                addToData.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using(TContext context = new TContext())
            {
                var deleteToData = context.Entry(entity);
                deleteToData.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> expression)
        {
           using(TContext context = new TContext())
            {
                return context.Set<Tentity>().FirstOrDefault(expression);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> expression=null)
        {
            using (TContext context = new TContext())
            {
                return expression == null ? context.Set<Tentity>().ToList() : context.Set<Tentity>().Where(expression).ToList();
            }
            {

            }        }

        public void Update(Tentity entity)
        {
            using (TContext context = new TContext())
            {
                var updateToData = context.Entry(entity);
                updateToData.State = EntityState.Modified;
                context.SaveChanges();

            }        }
    }
}
