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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        List<User> users;
        public int userId = 0;
        public double balance = 0;
        public string login = string.Empty;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (MyAppContext context = new MyAppContext())
            {
                users = context.Users.ToList();
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (loginTB.Text != string.Empty && passwordTB.Text != string.Empty)
            {
                if (users.FirstOrDefault(x => x.Login.Equals(loginTB.Text)) is User && users.FirstOrDefault(x => x.Login.Equals(loginTB.Text)) != null)
                {
                    User user = users.FirstOrDefault(x => x.Login.Equals(loginTB.Text));
                    if (user.Password.Equals(passwordTB.Text))
                    {

                        MessageBox.Show("Login successfull", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userId = user.Id;
                        login = user.Login;
                        balance = user.Money;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong login and/or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong login and/or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Need enter login and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
