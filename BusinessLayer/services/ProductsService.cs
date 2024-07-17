using DataLayer.repositories;
using EntitiesLayer.entities;
using System.Collections.Generic;

namespace BusinessLayer.services
{
    public class ProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService()
        {
            _productsRepository = new ProductsRepository();
        }

        public List<Products> GetProducts()
        {
            return _productsRepository.GetAll();
        }

        public Products GetProductsById(int id)
        {
            return _productsRepository.GetById(id);
        }

        public void AddProducts(Products products)
        {
            _productsRepository.Add(products);
        }

        public void DeleteProducts(int id)
        {
            _productsRepository.Delete(id);
        }

        public void UpdateProducts(Products products)
        {
            _productsRepository.Update(products);
        }

        public List<Products> FindByName(string name)
        {
            return _productsRepository.FindByName(name);
        }
    }
}