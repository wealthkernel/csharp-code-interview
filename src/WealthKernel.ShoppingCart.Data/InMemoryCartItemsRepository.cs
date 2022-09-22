using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using WealthKernel.ShoppingCart.Data.Models;

namespace WealthKernel.ShoppingCart.Data
{
    public class InMemoryCartItemsRepository
    {
        private readonly ConcurrentDictionary<string, CartItem> _items;

        public InMemoryCartItemsRepository()
        {
            _items = new ConcurrentDictionary<string, CartItem>();
        }

        public void AddCartItem(CartItem item)
        {
            var added = _items.TryAdd(item.Id, item);

            if (!added)
            {
                throw new InvalidOperationException($"Item {item.Id} already exists!");
            }
        }

        public CartItem? GetCartItem(string id)
        {
            _items.TryGetValue(id, out var item);
            return item;
        }

        public IList<CartItem> SearchCartItems(string? name = null)
        {
            var itemsQueryable = _items.Values.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                itemsQueryable = itemsQueryable.Where(r => r.Name == name);
            }

            return itemsQueryable.ToArray();
        }
    }
}
