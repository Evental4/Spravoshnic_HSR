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
                lbl3.Location = new Point(600, y+35);
                lbl3.Size = new Size(300, 30);
                Controls.Add(lbl3);
                #endregion

                #region в пати объекта
                Label lbl4 = new Label();
                lbl4.Text = "в пати - " + pers.path;
                lbl4.Location = new Point(600, y+70);
                lbl4.Size = new Size(300, 30);
                Controls.Add(lbl4);
                #endregion

                #region Rancs объекта
                Label lbl5 = new Label();
                lbl5.Text = "Rancs - " +pers.Rancs_pop;
                lbl5.Location = new Point(600, y+105);
                lbl5.Size = new Size(300, 30);
                Controls.Add(lbl5);
                #endregion

                y += 150;
            }
        }

        
    }
}
