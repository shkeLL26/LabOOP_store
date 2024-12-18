using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    public interface IProduct
    {
        int ID { get; }
        string Name { get; }
        float Price { get; }
        string Description { get; }
        Bitmap ProductImage { get; }
    }
}
