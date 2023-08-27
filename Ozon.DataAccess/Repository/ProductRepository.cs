using Ozon.DataAccess.Data;
using Ozon.DataAccess.Repository.IRepository;
using Ozon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ozon.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base (db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
           _db.Products.Update(obj);
        }
    }
}
