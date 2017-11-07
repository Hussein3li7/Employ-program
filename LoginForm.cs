using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLoign_Click(object sender, EventArgs e)
        {
            /////////////// Chech User And Password ////////////////////////////
            if (tbUser.Text == "Des3Losh" && tbPass.Text == "1234")
            {
                this.Hide();
                MyForm myForm = new MyForm();
                myForm.Show();
            }
            else
            {
                MessageBox.Show("The User Name or Password is not valid.");
            }
        }
    }
}
