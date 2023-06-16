using CoinStoreWF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinStoreWF
{
    public partial class CoinControl1 : UserControl
    {
        public CoinControl1()
        {
            InitializeComponent();
        }
        int LoginnedId;
        Coin coin;
        int TradeCoinId;

        public CoinControl1(int id, string name, string descriprion, double cost, string owner, int userId, int loginedId) : this()
        {
            this.nameL.Text = name;
            this.descriprionTB.Text = descriprion;
            this.costL.Text = cost.ToString();
            this.ownerL.Text = owner;
            coin = new Coin(id, name, descriprion, cost, userId);
            
            LoginnedId = loginedId;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            using (MyAppContext context = new MyAppContext())
            {

                if (context.Users.FirstOrDefault(x => x.Id == LoginnedId).Money >= coin.Price)
                {
                    var oldUser = context.Users.FirstOrDefault(x => x.Id == LoginnedId);
                    oldUser.Money -= coin.Price;
                    context.Users.Update(oldUser);

                    var oldCoin = context.Coins.FirstOrDefault(x => x.Id == coin.Id);
                    oldCoin.UserId = oldUser.Id;
                    context.Coins.Update(oldCoin);

                    context.Logs.Add(new Log(DateTime.Now, $"User ({oldUser.Login}) buyed coin {oldCoin.Name} for ({coin.Price})"));

                    context.SaveChanges();

                    buyBtn.Enabled = false;
                    tradeBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You can't buy this coin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void tradeBtn_Click(object sender, EventArgs e)
        {
            TradeForm tradeForm = new TradeForm(LoginnedId);
            if (tradeForm.ShowDialog() == DialogResult.OK)
            {
                TradeCoinId = tradeForm.CoinId;
                using (MyAppContext context = new MyAppContext())
                {                     
                    var coin1 = context.Coins.FirstOrDefault(x => x.Id.Equals(TradeCoinId));
                    coin1.UserId = coin.UserId;

                    var coin2 = context.Coins.FirstOrDefault(x => x.Id.Equals(coin.Id));
                    coin2.UserId = LoginnedId;

                    context.Logs.Add(new Log(DateTime.Now, $"User ({context.Users.FirstOrDefault(x => x.Id.Equals(LoginnedId)).Login}) traded coin" +
                        $" {coin1.Name} for {coin2.Name} with User ({context.Users.FirstOrDefault(x => x.Id.Equals(coin.UserId)).Login})"));

                    context.Update(coin1);
                    context.Update(coin2);

                    context.SaveChanges();

                    buyBtn.Enabled = false;
                    tradeBtn.Enabled = false;
                }


            }
        }
    }
}
