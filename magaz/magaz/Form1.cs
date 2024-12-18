using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace magaz
{
    public partial class Form1 : Form
    {
        private List<IProduct> productList = new List<IProduct>();
        private List<User> userList = new List<User>();
        private int selectedIndexTab = 0;
        private User account = null;
        public Form1()
        {
            InitializeComponent();
            SetStartProducts();
            ListViewFiller();
            buttonLogin.BackColor = Color.White;
            userList.Add(new User("123", "123"));
        }

        private void SetStartProducts()
        {
            productList.Add(new Microelectronics(1, "Arduino Nano", 140, "Arduino-совместимая плата на базе ATmega328. Функционально похожа на плату " +
                "Arduino Uno, но отличается меньшим размером, отсутствием гнезда внешнего питания и применяется разъем USB Type-C.",
                Properties.Resources.nano));
            productList.Add(new Microelectronics(2, "ESP-32S", 400, "ESP-32S CP2102 отладочная плата WiFi + Bluetooth (ESP-WROOM-32).",
                Properties.Resources.esp));
            productList.Add(new Tools(3, "GVDA GD300", 6000, "Набор электрического паяльника GVDA, инструмент для ремонта, мощность 65 Вт, " +
                "умные портативные наконечники для паяльника.",
                Properties.Resources.gvda));
            productList.Add(new Other<float>(4, "ТАГС", 160, "Флюс для пайки \"ТАГС\", 30 мл.",
                Properties.Resources.tags, 0.03f));
            productList.Add(new Other<int>(5, "Коврик для пайки", 500, "Коврик силиконовый термостойкий для пайки (320x230mm).",
                Properties.Resources.kovrik, 1));
            productList.Add(new Other<float>(6, "Ацетон", 746, "Обезжиривание поверхностей, удаление лакокрасочных покрытий.",
                Properties.Resources.act, 1f));
        }

        private void ListViewFiller()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(150, 150);
            for (int i = 0; i < 6; i++)
            {
                ListViewItem AddingItem = new ListViewItem();
                imageList.Images.Add(productList[i].ProductImage);
                AddingItem.Text = productList[i].ID + " " + productList[i].Name + " " + productList[i].Price.ToString() + "р.";
                switch (selectedIndexTab)
                {
                    case 0:
                        if (productList[i] is Microelectronics)
                        {
                            listView1.LargeImageList = imageList;
                            AddingItem.ImageIndex = i;
                            listView1.Items.Add(AddingItem);
                        }
                        break;
                    case 1:
                        if (productList[i] is Tools)
                        {
                            listView2.LargeImageList = imageList;
                            AddingItem.ImageIndex = i;
                            listView2.Items.Add(AddingItem);
                        }
                        break;
                    case 2:
                        if (productList[i] is Other<int> || productList[i] is Other<float>)
                        {
                            listView3.LargeImageList = imageList;
                            AddingItem.ImageIndex = i;
                            listView3.Items.Add(AddingItem);
                        }
                        break;
                    case 3:
                        {
                            listView4.LargeImageList = imageList;
                            AddingItem.ImageIndex = i;
                            listView4.Items.Add(AddingItem);
                        }
                        break;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectedIndexTab)
            {
                case 0:
                    listView1.Items.Clear();
                    break;
                case 1:
                    listView2.Items.Clear();
                    break;
                case 2:
                    listView3.Items.Clear();
                    break;
                case 3:
                    listView4.Items.Clear();
                    break;
            }
            selectedIndexTab = tabControl1.SelectedIndex;
            ListViewFiller();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexProduct;
            System.Windows.Forms.ListView listViewObject;
            if (sender == listView1) listViewObject = listView1;
            else if (sender == listView2) listViewObject = listView2;
            else if (sender == listView3) listViewObject = listView3;
            else listViewObject = listView4;
            if (listViewObject.SelectedIndices.Count > 0)
            {
                selectedIndexProduct = listViewObject.SelectedIndices[0];
                for (int i = 0; i < 6; i++)
                {
                    if (productList[i].ID.ToString() == listViewObject.Items[selectedIndexProduct].Text[0].ToString())
                    {
                        if (account == null)
                        {
                            FormProductDialog productDialog = new FormProductDialog(productList[i], false);
                            productDialog.dataEnter += AddToCart;
                            productDialog.ShowDialog();
                        }
                        else
                        {
                            FormProductDialog productDialog = new FormProductDialog(productList[i], true);
                            productDialog.dataEnter += AddToCart;
                            productDialog.ShowDialog();
                        }
                        break;
                    }
                }
            }
        }

        private void AddToCart(IProduct recievedProduct)
        {
            if (recievedProduct != null) account.AddToCart(recievedProduct);
            else MessageBox.Show("Сначала авторизуйтесь", "!!!", MessageBoxButtons.OK);
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                FormCart cart = new FormCart(account);
                cart.dataEnter += UserChanger;
                cart.ShowDialog();
            }
            else MessageBox.Show("Сначала авторизуйтесь", "!!!", MessageBoxButtons.OK);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                FormLogin loginer = new FormLogin(userList);
                loginer.dataEnter += AccessChanger;
                loginer.ShowDialog();
            }
            else
            {
                FormRegister register = new FormRegister(true, account);
                register.dataEnter += UserChanger;
                register.ShowDialog();
            }
        }

        private void UserChanger(User newUser)
        {
            if (newUser == null)
            {
                buttonLogin.Text = "Вход";
                buttonLogin.BackColor = Color.White;
                account = null;
                return;
            }
            userList.Remove(account);
            account = newUser;
            userList.Add(account);
        }

        private void AccessChanger(bool isNew, User newUser)
        {
            if (isNew)
            {
                userList.Add(newUser);
                return;
            }
            account = newUser;
            buttonLogin.Text = newUser.Login;
            buttonLogin.BackColor = Color.Green;
        }
    }
}
