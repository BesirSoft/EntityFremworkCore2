using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFremworkCore2.Models
{
    public class FakProductRepository : IProductRepository
    {
        public IQueryable<Product> Products =>  new List<Product>() {


              new Product(){ProductId=1, Name="samsung1", Price=2001, Category ="Telfon1"},
              new Product(){ProductId=2, Name="samsung2", Price=2002, Category ="Telfon2"},
              new Product(){ProductId=3, Name="samsung3", Price=2003, Category ="Telfon3"},
              new Product(){ProductId=4, Name="samsung4", Price=2004, Category ="Telfon4"},
              new Product(){ProductId=5, Name="samsung5", Price=2005, Category ="Telfon5"}


        }.AsQueryable();

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int producid)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
