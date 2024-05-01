using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "youhok" || txtpassword.Text == "youhok")
            {
                Home Obj = new Home();
                Obj.Show();
                this.Hide();
            }
            else if(txtUserName.Text == "" || txtpassword.Text=="")
            {
                MessageBox.Show("Need Information");
            }
        }
    }
}
