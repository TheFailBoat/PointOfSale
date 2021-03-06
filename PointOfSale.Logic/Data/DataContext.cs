﻿using System.Web.Mvc;
using PointOfSale.Data.Entities;
using PointOfSale.Entity;

namespace PointOfSale.Logic.Data
{
    public class DataContext
    {
        public IRepository<Bill> Bills { get { return GetRepository<Bill>(); } }
        public IRepository<Category> Categories { get { return GetRepository<Category>(); } }
        public IRepository<Item> Items { get { return GetRepository<Item>(); } }
        public IRepository<Table> Tables { get { return GetRepository<Table>(); } } 

        private IRepository<T> GetRepository<T>() where T : IEntity
        {
            return DependencyResolver.Current.GetService<IRepository<T>>();
        } 
    }
}
