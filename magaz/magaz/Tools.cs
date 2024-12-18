using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Tools : IProduct
    {
        public int ID { get; }
        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public Bitmap ProductImage { get; }

        public Tools(int iD, string name, float price, string description, Bitmap productImage)
        {
            ID = iD;
            Name = name;
            Price = price;
            Description = description;
            ProductImage = productImage;
        }
    }
}
