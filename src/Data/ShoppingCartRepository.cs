using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using WealthKernel.ShoppingCart.Models;

namespace WealthKernel.ShoppingCart.Data
{
    public class ShoppingCartRepository
    {
        private readonly ConcurrentDictionary<string,CartItemInternal> _items;

        public ShoppingCartRepository()
        {
            _items = new ConcurrentDictionary<string, CartItemInternal>();
        } 
            
        public void AddItem(CartItemInternal item)
        {
            var added = _items.TryAdd(item.Id, item);
            
            if (!added)
            {
                throw new InvalidOperationException($"Item {item.Id} already exists!");
            }
        }

        public CartItemInternal? GetItem(string id)
        {
            _items.TryGetValue(id, out var item);
            return item;
        }

        public IList<CartItemInternal> SearchItems(string? id = null, string? name = null)
        {
            var itemsQueryable = _items.Values.AsQueryable();

            if (!string.IsNullOrEmpty(id))
            {
                itemsQueryable = itemsQueryable.Where(r => r.Id == id);
            }

            if (!string.IsNullOrEmpty(name))
            {
                itemsQueryable = itemsQueryable.Where(r => r.Name == name);
            }

            return itemsQueryable.ToArray();
        }
    }
}
