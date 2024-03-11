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
    public partial class SelectForm : Form
    {
        public static Dictionary<Pers, int> my_pers_list = new Dictionary<Pers, int>();

        public SelectForm()
        {
            InitializeComponent();

            Draw();
        }

        void Draw()
        {
            Controls.Clear();

            int y = 30;
            foreach (KeyValuePair<Pers, int> my_pers in my_pers_list)
            {
                Pers pers = my_pers.Key;

                #region Изображение объекта
                PictureBox pb = new PictureBox();
                pb.Image = pers.pic.Image;
                pb.Location = new Point(20, y);
                pb.Size = new Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region Название объекта
                Label lbl1 = new Label();
                lbl1.Text = "Персонаж - " + pers.name;
                lbl1.Location = new Point(245, y);
                lbl1.Size = new Size(300, 30);
                Controls.Add(lbl1);
                #endregion

                #region кнопка перехода на страницу объекта
                Button btn = new Button();
                btn.Location = new Point(245, y+100);
                btn.Size = new Size(130, 50);
                btn.Text = pers.name;
                btn.Click += new EventHandler(MainForm.Pers_Click);
                Controls.Add(btn);
                #endregion

                #region путь объекта
                Label lbl2 = new Label();
                lbl2.Text = "Путь - " + pers.pyte;
                lbl2.Location = new Point(600, y);
                lbl2.Size = new Size(300, 30);
                Controls.Add(lbl2);
                #endregion

                #region тип объекта
                Label lbl3 = new Label();
                lbl3.Text = "Тип урона - " + pers.tip;
                lbl3.Location = new Point(600, y + 35);
                lbl3.Size = new Size(300, 30);
                Controls.Add(lbl3);
                #endregion

                #region в пати объекта
                Label lbl4 = new Label();
                lbl4.Text = "в пати - " + pers.role;
                lbl4.Location = new Point(600, y + 70);
                lbl4.Size = new Size(300, 30);
                Controls.Add(lbl4);
                #endregion

                #region Rancs объекта
                Label lbl5 = new Label();
                lbl5.Text = "Rancs - " + pers.Rancs_pop;
                lbl5.Location = new Point(600, y + 105);
                lbl5.Size = new Size(300, 30);
                Controls.Add(lbl5);
                #endregion

                /*
                #region Статы артов
                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Location = new Point(900, y+ 100);
                numericUpDown1.Size = new System.Drawing.Size(300, 30);
                numericUpDown1.Value = new decimal();
                #endregion
                */

                #region кнопка удаления обЪекта
                Button btn1 = new Button();
                btn1.Location = new Point(900, y);
                btn1.Size = new Size(130, 50);
                btn1.Text = "Удалить";
                btn1.Click += new EventHandler(DeleteClik);
                Controls.Add(btn1);
                #endregion


                y += 200;
            }

        }

        void DeleteClik(object sender, EventArgs e)
        {
            int i = 0;
            Button btn = (Button)sender;
            Dictionary<Pers, int> my_pers = new Dictionary<Pers, int>();
            foreach (KeyValuePair<Pers, int> my_per in my_pers_list) 
            {
                Pers pers = my_per.Key;
                if(btn.Location == new Point(900, 30+200*i))
                {

                }
                else
                {
                    my_pers[my_per.Key] = my_per.Value;
                }
                i++;

            }
            my_pers_list = my_pers;
            Draw();
        }


    }
}
