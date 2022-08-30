﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var deleteddEntity = db.Entry(entity);
                deleteddEntity.State = EntityState.Deleted;
                db.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext db = new TContext())
            {

                //filter null ise product tı listeleyip getir
                //degilse sarta gore data geitr 

                if (filter == null)
                {
                    return db.Set<TEntity>().ToList();
                }
                else
                {
                    return db.Set<TEntity>().Where(filter).ToList();
                }

                // return filter == null
                //? db.Set<TEntity>().ToList()
                //: db.Set<TEntity>().Where(filter).ToList();


            }
        }

        public void Update(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var updateddEntity = db.Entry(entity);
                updateddEntity.State = EntityState.Modified;
                db.SaveChanges();

            }
        }



    }
}
