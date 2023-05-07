using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public interface IProductDal : IEntityRepository<Product>, AsyncEntityRepository<Product>
    {
        //List<Product> GetAll();

        //List<Product> GetById(int id);

        //void Add(Product product);

        //void Update(Product product);
        
        //void Delete(Product product);
    }
}
