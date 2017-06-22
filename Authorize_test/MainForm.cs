using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
namespace Authorize_test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            User user = userRepository.GetUser(login.Text);
            if (user.Password==password.Text)
            {
                label3.Text = user.First_name + " " + user.Last_name;
            } else
            {
                label3.Text = "Error! Login or password incorrect";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            User user = new User();
            user.Login = login.Text;
            user.Password = password.Text;
            user.First_name = user.Login + "_first_name";
            user.Last_name = user.Login + "_last_name";
            if (userRepository.SaveUser(user) == 0)
            {
                label3.Text = "User add";
            }
            else
            {
                label3.Text = "Error! User exist!";
            };
        }
    }
}
