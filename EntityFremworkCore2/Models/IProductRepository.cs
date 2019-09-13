using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFremworkCore2.Models
{
    public interface IProductRepository
    {


        Product GetById(int producid);

        IQueryable<Product> Products { get; }

        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void Delete(int id);

    }
}
