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
    public partial class TradeForm : Form
    {
        public TradeForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        int UserId;
        public int CoinId = 0;
        List<Coin> Coins;
        List<Coin> CoinsList = new List<Coin>();

        private void TradeForm_Load(object sender, EventArgs e)
        {
            using (MyAppContext context = new MyAppContext())
            {
                Coins = context.Coins.ToList();
                CoinsList = (from c in Coins where c.UserId == UserId select c).ToList();
                for (int i = 0; i < Coins.Count; i++)
                {
                    if (Coins[i].UserId == UserId)
                    {
                        coinsCB.Items.Add(Coins[i].Name);
                    }
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (coinsCB.Items.Count > 0)
            {

                CoinId = CoinsList[coinsCB.SelectedIndex].Id;
                DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
