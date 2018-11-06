using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fMain : Form
    {
        public float height,age,mass;
        public double indexMass;
        public string name;

        public fMain()
        {
            InitializeComponent();
 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void getResult_Click(object sender, EventArgs e)
        {
            mass = Convert.ToInt32(massBox.Text);
            age = Convert.ToInt32(ageBox.Text);
            height = Convert.ToInt32(heightBox.Text);
            
            if (mass != 0 && height != 0)
            {
                height = height / 100;
                indexMass = (mass) / (height * height);
                indexMass = Math.Round(indexMass,2);
                IMTlabel.Text = "ИМТ:" + indexMass;
                if (indexMass < 16)
                {
                    indexMassText.Text = "Выраженный дефицит массы тела";
                } else if (indexMass >= 16 && indexMass < 18.5)
                {
                    indexMassText.Text = "Недостаточная масса тела";
                }else if (indexMass >= 18.5 && indexMass < 25)
                {
                    indexMassText.Text = "Нормальная масса тела";
                }else if (indexMass >= 25 && indexMass < 30)
                {
                    indexMassText.Text = "Избытачаня масс тела";
                }else if (indexMass >= 30 && indexMass < 35)
                {
                    indexMassText.Text = "Ожирение 1-ой степени";
                }else if (indexMass >= 35 && indexMass < 40)
                {
                    indexMassText.Text = "Ожирение 2-ой степени";
                }else if (indexMass >= 40)
                {
                    indexMassText.Text = "Ожирение 3-ой степени";
                }
            }
        }
    }
}
