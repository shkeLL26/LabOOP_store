using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Other<T>: IProduct
    {
        public int ID { get; }
        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public Bitmap ProductImage { get; }
        public T Amount { get; }

        public Other(int iD, string name, float price, string description, Bitmap productImage, T ml)
        {
            ID = iD;
            Name = name;
            Price = price;
            Description = description;
            ProductImage = productImage;
            Amount = ml;
        }

    }
}
