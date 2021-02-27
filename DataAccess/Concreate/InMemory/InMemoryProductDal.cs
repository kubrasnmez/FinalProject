using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Concreate.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //referans tip

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock = 3},
                new Product{ ProductId=2, CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock = 5},
                new Product{ ProductId=3, CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock = 7},
                new Product{ ProductId=4, CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock = 1},
                new Product{ ProductId=5, CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock = 4},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //LINQ olmasaydı listeyi tek tek dolaşıp şartı bulmak
            //=> lambda
            Product productToDelete;
            /*
            foreach (var p in _products)
            {
                if(product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }
            */
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
