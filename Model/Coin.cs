using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinStoreWF.Model
{
    internal class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

        public Coin()
        {
            Id = 0;
            Name = string.Empty;
            Description = string.Empty;
            Price = 0;
            UserId = 0;
        }
        public Coin(int id, string name, string description, double price, int userId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            UserId = userId;           

        }
    }
}
