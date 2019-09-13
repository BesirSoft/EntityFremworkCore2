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
    }
}
