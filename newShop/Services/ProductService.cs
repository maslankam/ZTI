﻿using Microsoft.EntityFrameworkCore;
using newShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newShop.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _db;
        public ProductService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Product GetProduct(int productId)
        {
            Product obj = new Product();
            return _db.Products.FirstOrDefault(u => u.Id == productId);
        }

        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        public bool CreateProduct(Product objProduct)
        {
            _db.Products.Add(objProduct);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateProduct(Product objProduct)
        {
            var ExistingProduct = _db.Products.FirstOrDefault(u => u.Id == objProduct.Id);
            if (ExistingProduct != null)
            {
                if (objProduct.Image == null)
                {
                    objProduct.Image = ExistingProduct.Image;
                }
                _db.Products.Update(objProduct);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteProduct(Product objProduct)
        {
            var ExistingProduct = _db.Products.FirstOrDefault(u => u.Id == objProduct.Id);
            if (ExistingProduct != null)
            {
                _db.Products.Remove(ExistingProduct);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
