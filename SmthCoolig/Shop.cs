using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmthCoolig
{
    public class Shop
    {
        private string _name;
        private Types _type;
        private List<Products> _products;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _name = value;
            }
        }

        public Types TypeOfShop
        {
            get
            {
                return _type;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Types), value))
                {
                    throw new ArgumentException("Invalid shop type");
                }
                _type = value;
            }
        }
        public Shop(string name, Types type, Products[] products)
        {
            Name = name;
            TypeOfShop = type;
            _products = new List<Products>(products);
        }
        public void AddProduct(Products product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Product cannot be null");
            }
            _products.Add(product);
        }
        public void SellProduct(Products product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Product cannot be null");
            }
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero");
            }
            if (!_products.Contains(product))
            {
                throw new ArgumentException("Product not found in the shop");
            }
            if (product.Quantity < quantity)
            {
                throw new InvalidOperationException("Not enough stock to sell the requested quantity");
            }
            product.Quantity -= quantity;
        }
    }
}
