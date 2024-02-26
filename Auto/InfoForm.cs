using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class InfoForm : Form
    {
        Pers pers;
        public InfoForm(Pers _pers)
        {
            InitializeComponent();

            pers = _pers;

            Text = pers.name;
            label1.Text = pers.name;

            pictureBox1.Load("../../Pictures/" + pers.name + ".png");


            rolelabel.Text = pers.role;
            tiplabel.Text = pers.tip;
            pytelabel.Text = pers.pyte;
            #region tip
            if (pers.tip == "Физический")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Физический.png");
            }
            if (pers.tip == "Ветреной")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Ветреной.png");
            }
            if (pers.tip == "Леденой")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Леденой.png");
            }
            if (pers.tip == "Мнимый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Мнимый.png");
            }
            if (pers.tip == "Электрический")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Электрический.png");
            }
            if (pers.tip == "Огненый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Огненый.png");
            }
            if (pers.tip == "Квантовый")
            {
                TippictureBox.Load("../../Pictures/Тип_урона_Квантовый.png");
            }
            #endregion

            #region pyte
            if (pers.pyte == "Разрушение")
            {
                PytepictureBox.Load("../../Pictures/Путь_Разрушение.png");
            }
            if (pers.pyte == "Небытие")
            {
                PytepictureBox.Load("../../Pictures/Путь_Небытие.png");
            }
            if (pers.pyte == "Гармония")
            {
                PytepictureBox.Load("../../Pictures/Путь_Гармония.png");
            }
            if (pers.pyte == "Сохранение")
            {
                PytepictureBox.Load("../../Pictures/Путь_Сохранение.png");
            }
            if (pers.pyte == "Охота")
            {
                PytepictureBox.Load("../../Pictures/Путь_Охота.png");
            }
            if (pers.pyte == "Эрудикция")
            {
                PytepictureBox.Load("../../Pictures/Путь_Эрудикция.png");
            }
            if (pers.pyte == "Изобилие")
            {
                PytepictureBox.Load("../../Pictures/Путь_Изобилие.png");
            }
            #endregion

        }

        private void Selbutton_Click(object sender, EventArgs e)
        {
            SelectForm.my_pers_list.Add(pers);
        }
    }
}