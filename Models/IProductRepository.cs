using Supermarket_mvp1._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Models
{
    internal interface IProductRepository
    {

        void Add(ProductModel productRepository);
        void Edit(ProductModel productRepository);
        void Delete(int productRepository);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string values);
    }
}
