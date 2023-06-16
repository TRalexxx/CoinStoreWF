using CoinStoreWF.Model;
using Microsoft.VisualBasic.Logging;
using System.Text;

namespace CoinStoreWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isLogin = false;
        int userId = 0;

        private void logInBtn_Click(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    isLogin = true;
                    userId = loginForm.userId;
                    loginAsL.Text = $"Login as: {loginForm.login}";
                    balanceL.Text = $"Balance: {loginForm.balance}";
                }
            }


        }

        List<User> users;
        List<Coin> coins;
        List<Model.Log> logs;
        User user;

        int locX = 5;
        int locY = 5;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            coinPanel.Size = new Size(this.Width - 38, this.Height - 107);
        }

        private void refreshStoreBtn_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                coinPanel.Controls.Clear();
                locX = 5;
                locY = 5;
                using (MyAppContext context = new MyAppContext())
                {
                    users = context.Users.ToList();
                    coins = context.Coins.ToList();

                    for (int i = 0; i < coins.Count; i++)
                    {
                        if (coins[i].UserId != userId)
                        {
                            CoinControl1 coinControl1 = new CoinControl1(coins[i].Id, coins[i].Name, coins[i].Description, coins[i].Price,
                                users.FirstOrDefault(x => x.Id.Equals(coins[i].UserId)).Login, coins[i].UserId, userId);
                            if (locX + coinControl1.Width + 5 <= coinPanel.Width)
                            {
                                coinControl1.Location = new Point(locX, locY);
                                locX += coinControl1.Width + 5;
                            }
                            else
                            {
                                locX = 5;

                                locY += coinControl1.Height + 5;
                                coinControl1.Location = new Point(locX, locY);
                                locX += coinControl1.Width + 5;


                            }
                            coinPanel.Controls.Add(coinControl1);
                        }
                    }
                    balanceL.Text = $"Balance: {users.FirstOrDefault(x => x.Id == userId).Money}";
                }
            }
        }

        private void saveLogsBtn_Click(object sender, EventArgs e)
        {
            using(MyAppContext context = new MyAppContext())
            {                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt (*.txt)|*.txt";
                if(saveFileDialog.ShowDialog()==DialogResult.OK)
                {                    
                    string fileName = saveFileDialog.FileName;
                    if(fileName != null)
                    {
                        logs = context.Logs.ToList();
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in logs)
                        {
                            sb.Append(item.ToString());
                            sb.Append(Environment.NewLine);
                        }
                        File.WriteAllText(fileName, sb.ToString());
                    }
                }
                else if(saveFileDialog.ShowDialog()==DialogResult.Cancel)
                {
                    return;
                }
                
            }

        }
    }
}