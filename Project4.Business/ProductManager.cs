using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Business
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal product)
        {
            _productDal = product;
        }


        public List<Product> GetAll()
        {
           // EFProductDal productDal = new EFProductDal();
            return _productDal.GetAll();
        }
    }
}