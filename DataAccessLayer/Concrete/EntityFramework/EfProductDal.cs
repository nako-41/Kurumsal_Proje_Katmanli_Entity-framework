using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;
using System.Linq;


namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {


        ////////////////////////////
        #region code refactoring'den onceki hali,sadece IProductDal Hali
        //public void Add(Products entity)
        //{
        //    using (NorthwindDbContext db = new NorthwindDbContext())
        //    {
        //        var addedEntity = db.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        db.SaveChanges();
        //    }
        //}

        //public void Delete(Products entity)
        //{
        //    using (NorthwindDbContext db = new NorthwindDbContext())
        //    {
        //        var deleteddEntity = db.Entry(entity);
        //        deleteddEntity.State = EntityState.Deleted;
        //        db.SaveChanges();

        //    }
        //}

        //public Products Get(Expression<Func<Products, bool>> filter)
        //{
        //    using (NorthwindDbContext db = new NorthwindDbContext())
        //    {
        //        return db.Set<Products>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Products> GetAll(Expression<Func<Products, bool>> filter = null)
        //{
        //    using (NorthwindDbContext db = new NorthwindDbContext())
        //    {

        //        //filter null ise product tı listeleyip getir
        //        //degilse sarta gore data geitr 

        //        //if (filter==null)
        //        //{
        //        //  return db.products.ToList();
        //        //}
        //        //else
        //        //{
        //        //   return db.products.Where(filter).ToList();
        //        //}

        //        return filter == null
        //       ? db.Set<Products>().ToList()
        //       : db.Set<Products>().Where(filter).ToList();


        //    }
        //}

        //public void Update(Products entity)
        //{
        //    using (NorthwindDbContext db = new NorthwindDbContext())
        //    {
        //        var updateddEntity = db.Entry(entity);
        //        updateddEntity.State = EntityState.Modified;
        //        db.SaveChanges();

        //    }
        //}
        #endregion
        ////////////////////////////

        public List<ProductDetailDto> GetProductDetailse()
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                var result = from p in context.products
                             join c in context.categories
                             on p.CategoryID equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductID, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }


        }
    }
}
