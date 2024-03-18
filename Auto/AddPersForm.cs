using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class AddPersForm : Form
    {
        public AddPersForm()
        {
            InitializeComponent();
        }

        private void Sevebutton_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Pers.txt" ,
                                                      Environment.NewLine +
                                                      NameTextBox.Text + ", " +
                                                      RoleComboBox.Text + ", " +
                                                      TipComboBox.Text + ", " +
                                                      PythComboBox.Text + ", " +
                                                      HpTextBox.Text + ", " +
                                                      DefTextBox.Text + ", " +
                                                      AtcTextBox.Text + ", " +
                                                      SpidTextBox.Text + ", " +
                                                      RancsTextBox.Text + ", " +
                                                      WebTextBox.Text + ", ");
        }
    }
}
