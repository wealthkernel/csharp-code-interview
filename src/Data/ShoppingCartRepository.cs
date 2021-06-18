using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using WealthKernel.ShoppingCart.Models;

namespace WealthKernel.ShoppingCart.Data
{
    public class ShoppingCartRepository
    {
        private readonly ConcurrentDictionary<string,CartItem> _items;

        public ShoppingCartRepository()
        {
            _items = new ConcurrentDictionary<string, CartItem>();
        } 
            
        public void AddItem(CartItem item)
        {
            var added = _items.TryAdd(item.Id, item);
            
            if (!added)
            {
                throw new InvalidOperationException($"Item {item.Id} already exists!");
            }
        }

        public CartItem? GetItem(string id)
        {
            _items.TryGetValue(id, out var item);
            return item;
        }

        public IList<CartItem> SearchItems(string? id, string? name)
        {
            var itemsQueryable = _items.Values.AsQueryable();

            if (!string.IsNullOrEmpty(id))
            {
                return new[] { itemsQueryable.Single(item => item.Id == id) };
            }

            if (!string.IsNullOrEmpty(name))
            {
                itemsQueryable = itemsQueryable.Where(r => r.Name == name);
            }

            return itemsQueryable.ToArray();
        }
    }
}
