using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFremworkCore2.Models
{
    public class EfProductRepostory : IProductRepository
    {
        private AplicationDbContext _context;
        public EfProductRepostory(AplicationDbContext context)
        {
            _context=context;
        }

        public IQueryable<Product> Products => _context.Products;

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
          var ururn=  _context.Products.Where(i => i.ProductId == id).FirstOrDefault();

            _context.Remove(ururn);
            _context.SaveChanges();

        }

        public Product GetById(int producid)
        {

            return _context.Products.Where(i => i.ProductId == producid).FirstOrDefault();

        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
