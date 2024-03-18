using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            Text = "Регистрация нового пользователя";
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (PassTB.Text == RePassTB.Text)
            {
                File.AppendAllText("users.txt", NameTB.Text + ", " + FamilyTB.Text + ", " +
                                            LoginTB.Text + ", " + PassTB.Text + ", " + "0"+
                                            Environment.NewLine);
                MessageBox.Show("Регистрация пользователя прошла успешно");
                Close();
            }
            else MessageBox.Show("Пароли не совпадают");
            
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
