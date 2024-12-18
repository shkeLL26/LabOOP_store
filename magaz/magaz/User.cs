using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public List<IProduct> BuyingStory { get; }
        public List<IProduct> CurrentCart { get; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            BuyingStory = new List<IProduct>();
            CurrentCart = new List<IProduct>();
        }

        public void AddStory(IProduct product)
        {
            BuyingStory.Add(product);
        }

        public void AddToCart(IProduct product)
        {
            CurrentCart.Add(product);
        }

        public void ClearTheCart()
        {
            CurrentCart.Clear();
        }

        public void AddCard(string card, string code) 
        {
            CardNumber = card;
            CVC = code;
        }
    }
}
