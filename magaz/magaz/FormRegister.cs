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
    public partial class FormRegister : Form
    {
        public event Action<User> dataEnter;
        bool logined = false;
        User account = null;
        public FormRegister(bool isLogined, User changingUser)
        {
            InitializeComponent();
            logined = isLogined;
            labelStory.Enabled = false;
            if (logined && changingUser != null)
            {
                account = changingUser;
                textBox1.Text = account.Login;
                textBox2.Text = account.Password;
                textBox1.Enabled = textBox2.Enabled = false;
                labelStory.Text = "История покупок";
                textBox3.Text = account.CardNumber;
                textBox4.Text = account.CVC;
                if (account.BuyingStory.Count() > 0) foreach (var story in account.BuyingStory) listBox1.Items.Add(story.Name);
            }
            else
            {
                buttonUnlogin.Enabled = false;
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!logined)
            {
                User registeredUser = new User(textBox1.Text, textBox2.Text);
                if (textBox3.Text.Length > 0 && textBox4.Text.Length > 0) registeredUser.AddCard(textBox3.Text, textBox4.Text);
                dataEnter?.Invoke(registeredUser);
                DialogResult = DialogResult.OK;
            }
            else
            {
                account.AddCard(textBox3.Text, textBox4.Text);
                dataEnter?.Invoke(account);
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonUnlogin_Click(object sender, EventArgs e)
        {
            dataEnter?.Invoke(null);
            DialogResult = DialogResult.OK;
        }
    }
}
