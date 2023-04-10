using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Finish";
            label3.Text = "Final";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "МЦК Лужники";
            label3.Text = "Особенности:\n\n Стенд питья \n\n Энергетические батончики ";
            pictureBox17.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Новодевичей монастырь";
            label3.Text = "Особенности:\n\n Стенд питья \n\n Энергетические батончики \n\n Туалет \n\nМедицинский пункт ";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "Метро Киевская";
            label3.Text = "Особенности:\n\n Стенд питья \n\nЭнергетические батончики \n\n Туалет ";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = "МИД";
            label3.Text = "Особенности:\n\n Стенд питья \n\n Энергетические батончики \n\n Туалет \n\nМедицинский пункт";

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = "Дистанция";
            label3.Text = "Вы прошли почти\n половину,\n не сдавайтесь ";


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = "Парк Горького";
            label3.Text = "Особенности:\n\n Стенд питья \n\n Энергетические батончики \n\n Туалет ";

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = "Здания РАН";
            label3.Text = "Особенности:\n\n Стенд питья \n\n Энергетические батончики \n\n Туалет ";

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label2.Text = "Метро Воробевы горы";
            label3.Text = "Особенности:\n\n Стенд питья \n\n Энергетические батончики \n\n Туалет \n\nМедицинский пункт ";

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Text = "Стадион Лужники";
            label3.Text = "Особенности:\n\n Стенд питья \n\nЭнергетические батончики \n\n Туалет \n\nМедицинский пункт ";

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Text = "Дистанция";
            label3.Text = "Начало трассы \n удачи! ";

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            label2.Text = "Дистанция";
            label3.Text = "Первые 5 км \n пройдены, \n поднажмите";

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
