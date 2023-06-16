using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinStoreWF.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public double Money { get; set; }

        public List<Coin> Coins { get; set; }
        public User()
        {
            Id = 0;
            Login = string.Empty;
            Password = string.Empty;
            Coins = new List<Coin>();
        }
        public User(string login, string password)
        {
            Id = 0;
            Login = login;
            Password = password;
            Coins = new List<Coin>();
        }

    }
}
