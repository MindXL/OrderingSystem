using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.forms.authentication
{
    public partial class Login : Form
    {
        private readonly Ex3DataContext db = new Ex3DataContext();

        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            if (account.Length == 0)
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            else if (account.Length > Constants.MAX_ACCOUNT_LENGTH)
            {
                MessageBox.Show("用户名的长度不应超过" + Constants.MAX_ACCOUNT_LENGTH);
                return;
            }
            else if (password.Length == 0)
            {
                MessageBox.Show("请输入密码");
                return;
            }
            else if (password.Length > Constants.MAX_PASSWORD_LENGTH)
            {
                MessageBox.Show("密码的长度不应超过" + Constants.MAX_PASSWORD_LENGTH);
                return;
            }

            var user = from u in db.User
                       where u.account == account && u.password == password
                       select u;
            if (user.Count() == 0)
            {
                MessageBox.Show("用户名或密码不正确！");
                return;
            }
            else
            {
                Globals.character = new Character(user.First().id, account, password);
                MessageBox.Show("欢迎登录！");
                this.Close();
            }
        }
    }
}