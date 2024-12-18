using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magaz
{
    public partial class FormProductDialog : Form
    {
        IProduct product;
        bool isLogined = false;
        public event Action<IProduct> dataEnter;
        public FormProductDialog(IProduct recievedProduct, bool recievedFlag)
        {
            InitializeComponent();
            product = recievedProduct;
            isLogined = recievedFlag;
            panel1.BackgroundImage = product.ProductImage;
            textBox1.Text = product.Name;
            textBox2.Text = product.Price.ToString();
            textBox3.Text = product.Description;
            if (product is Other<float>)
            {
                Other<float> other = product as Other<float>;
                label3.Text = "Литры";
                textBox4.Text = other.Amount.ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (isLogined) dataEnter?.Invoke(product);
            else dataEnter?.Invoke(null);
            DialogResult = DialogResult.OK;
        }
    }
}
