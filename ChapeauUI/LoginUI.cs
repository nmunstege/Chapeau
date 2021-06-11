using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class LoginUI : Form
    {
        User CurrentUser { get; set;}

        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            User user = userService.UserLogin(txtUsername.Text,int.Parse(txtPassword.Text));
            if (user!= null)
            {
               
                 if(user.Type=="Waiter")
                {
                    // new TableOverviewUI (Order);
                   // new OrderingUI (new Order(1, 1, 0, ));
                }
                else if(user.Type=="cook")
                {
                    new KitchenUI(CurrentUser);
                }
                else if (user.Type == "Bartender")
                {

                }
            }
            else
            {
                MessageBox.Show("The username or password are incorrect!!");
            }

        }
    }
}
