using System.Collections.Generic;
using System.Reflection;
using EntitiesLayer.entities;

namespace DataLayer.repositories
{
    public interface IProductsRepository
    {
        List<Products> GetAll();
        Products GetById(int id);
        void Add(Products products);
        void Update(Products products);
        void Delete(int id);
        List<Products> FindByName(string name);
    }
}