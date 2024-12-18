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
    public partial class FormCart : Form
    {
        private User account = null;
        private int selectedIndex = -1;
        public event Action<User> dataEnter;
        public FormCart(User recievedUser)
        {
            InitializeComponent();
            account = recievedUser;
            textBox1.Text = account.Login;
            buttonSBP.Enabled = buttunCard.Enabled = false;
            if (account.CurrentCart.Count() > 0 )
            {
                float sum = 0;
                foreach (IProduct product in account.CurrentCart)
                {
                    if (product is Microelectronics)
                    {
                        Microelectronics pr = product as Microelectronics;
                        sum = sum + pr;
                    }
                    else sum += product.Price;
                    listBox1.Items.Add(product.Name + " - " + product.Price.ToString() + "р.");
                }
                textBox2.Text = sum.ToString();
                buttonSBP.Enabled = buttunCard.Enabled = true;
            }
        }

        private void buttonSBP_Click(object sender, EventArgs e)
        {
            FormSBP formSBP = new FormSBP();
            formSBP.ShowDialog();
            if (account.CurrentCart.Count() > 0) foreach (IProduct product in account.CurrentCart) account.AddStory(product);
            account.CurrentCart.Clear();
            dataEnter?.Invoke(account);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttunCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(account.CardNumber) > 0 && int.Parse(account.CVC) > 0)
                    if (account.CurrentCart.Count() > 0) foreach (IProduct product in account.CurrentCart) account.AddStory(product);
                    account.CurrentCart.Clear();
                    dataEnter?.Invoke(account);
                    DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Нет сохранённой карты", "!!!", MessageBoxButtons.OK);
            }
        }
    }
}
