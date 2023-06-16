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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        List<User> users;
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (loginTB.Text != string.Empty && passwordTB.Text != string.Empty && repeatPasswordTB.Text != string.Empty)
            {
                if (!users.Any(x => x.Login.Equals(loginTB.Text)))
                {
                    if (passwordTB.Text.Equals(repeatPasswordTB.Text))
                    {
                        using (MyAppContext context = new MyAppContext())
                        {
                            context.Users.Add(new User(loginTB.Text, passwordTB.Text));
                            context.SaveChanges();
                            MessageBox.Show("Registration complete", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This login is already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            using (MyAppContext context = new MyAppContext())
            {
                users = context.Users.ToList();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
