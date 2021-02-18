using Net5.AttributesAndClasses.ConsoleClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Repositories
{
    public class ProductRespository
    {
        public List<Product> _products { get; set; }
        public void Insert(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            _products.Remove(product);
        }

        public void Update(Product oldProduct, Product newProduct)
        {
            _products.Remove(oldProduct);
            _products.Add(newProduct);
        }

        public List<Product> List(){
            return _products;
        }
    }
}
