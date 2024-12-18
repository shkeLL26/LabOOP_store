using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    internal class Microelectronics : IProduct
    {
        public int ID { get; }
        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public Bitmap ProductImage { get; }

        public Microelectronics(int iD, string name, float price, string description, Bitmap productImage)
        {
            ID = iD;
            Name = name;
            Price = price;
            Description = description;
            ProductImage = productImage;
        }

        public static float operator +(float i1, Microelectronics i2)
        {
            return i1 + i2.Price;
        }
    }
}
