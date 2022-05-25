﻿using Comm.Business.Abstract;
using Comm.DataAccess.Abstract;
using Comm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Comm.Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
             _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _productRepository.GetAll(filter);
        }

        public IEnumerable<Product> GetApprovedProductsForPage(int page, int pageSize)
        {
            return _productRepository.GetApprovedProductsForPage(page,pageSize);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _productRepository.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productRepository.GetCountByCategory(category);
        }

        public IEnumerable<Product> GetFilteredProductsForPage(string searchString, int page, int pageSize)
        {
            return _productRepository.GetFilteredProductsForPage(searchString,page,pageSize);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public IEnumerable<Product> GetProductsByCategory(string category,int page,int pageSize)
        {
            return _productRepository.GetProductsByCategory(category, page,pageSize);
        }

     

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productRepository.Update(entity,categoryIds);
        }
    }
}