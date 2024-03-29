﻿
namespace MotoApp3.Repositories
{
    using MotoApp3.Entities;
    public class GenericRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
    ;
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

    }
}