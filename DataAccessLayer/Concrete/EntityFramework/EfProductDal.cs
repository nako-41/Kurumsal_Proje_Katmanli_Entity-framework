﻿using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {

        public void Add(Products entity)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                var addedEntity = db.Entry(entity);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(Products entity)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                var deleteddEntity = db.Entry(entity);
                deleteddEntity.State = EntityState.Deleted;
                db.SaveChanges();

            }
        }

        public Products Get(Expression<Func<Products, bool>> filter)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                return db.Set<Products>().SingleOrDefault(filter);
            }
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> filter = null)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {

                //filter null ise product tı listeleyip getir
                //degilse sarta gore data geitr 

                //if (filter==null)
                //{
                //  return db.products.ToList();
                //}
                //else
                //{
                //   return db.products.Where(filter).ToList();
                //}

                     return filter == null
                    ? db.Set<Products>().ToList()
                    : db.Set<Products>().Where(filter).ToList();
                

            }
        }

        public void Update(Products entity)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                var updateddEntity = db.Entry(entity);
                updateddEntity.State = EntityState.Modified;
                db.SaveChanges();

            }
        }
    }
}