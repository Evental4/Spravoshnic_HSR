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
            try
            { 
                InfotextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + pers.name + ".txt");
            }
            catch (Exception) { }
        }


        

        private void AddSelectBTN_Click(object sender, EventArgs e)
        {
            if(SelectForm.my_pers_list.ContainsKey(pers))
            {
                SelectForm.my_pers_list[pers]++;
            }
            else
            {
                SelectForm.my_pers_list.Add(pers, 1);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://honkai-star-rail.fandom.com/ru/wiki/%D0%91%D1%80%D0%BE%D0%BD%D1%8F");
        }
    }
}