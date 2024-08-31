using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VastBook.DataAccess.Data;
using VastBook.DataAccess.Repository.IRepository;
using VastBook.Models;

namespace VastBook.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
