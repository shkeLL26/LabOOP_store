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
    public partial class FormLogin : Form
    {
        private List<User> userList = new List<User>();
        public event Action<bool, User> dataEnter;
        public FormLogin(List<User> recievedList)
        {
            InitializeComponent();
            userList = recievedList;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            foreach (User user in userList)
            {
                if (user.Login == textBox1.Text && user.Password == textBox2.Text)
                {
                    dataEnter?.Invoke(false, user);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister registration = new FormRegister(false, null);
            registration.dataEnter += NewUserSetter;
            registration.ShowDialog();
        }

        private void NewUserSetter(User newUser)
        {
            User registeredUser = newUser;
            dataEnter?.Invoke(true, registeredUser);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
