using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;


namespace WindowsFormsApp1
{
    public partial class fMain : Form
    {
        public float heightInM,recomendWater,recomendCal;
        public int age, height, mass,varWaist, varNeck, varHips, wantDoTarget, countPersonals;
        public double indexMass,bmr, coefficientActive, procentFat;
        public string name;

        public fMain()
        {
            InitializeComponent();
            sexBox.SelectedIndex = 0;
            activeBox.SelectedIndex = 0;
            var db = new SQLiteConnection("DataBase.db");
            db.CreateTable<Person>();
            countPersonals = db.Table<Person>().Count();
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

        private void satisfy_CheckedChanged(object sender, EventArgs e)
        {
            if (satisfy.Checked)
            {
                valueTarget.Text = massBox.Text;
            }
            wantDoTarget = 2;
        }

        private void wantLess_CheckedChanged(object sender, EventArgs e)
        {
            wantDoTarget = 1;
        }

        private void wantMore_CheckedChanged(object sender, EventArgs e)
        {
            wantDoTarget = 3;
        }

        private void resultFat_Click(object sender, EventArgs e)
        {
            if (waist.Text != string.Empty)
            {
                varWaist = Convert.ToInt32(waist.Text);
            }
            else
            {
                warning.Text = "Вы не ввели объём талии";
            }
            if (neck.Text != string.Empty)
            {
                varNeck = Convert.ToInt32(neck.Text);
            }
            else
            {
                warning.Text = "Вы не ввели объём шеи";
            }
            if (sexBox.SelectedIndex == 1)
            {
                if (hipsBox.Text != string.Empty)
                {
                    varHips = Convert.ToInt32(hipsBox.Text);
                }
                else
                {
                    warning.Text = "Вы не ввели объём бёдер";
                }
            }
            //процент жира
            if (sexBox.SelectedIndex == 0)
            {
                procentFat = 86.010 * (Math.Log(varWaist - varNeck) / Math.Log(10)) - 70.041 * (Math.Log(height) / Math.Log(10)) + 30.30; //расчет для мужчины;
            }
            else
            {
                procentFat = 163.205 * (Math.Log(varWaist + varHips - varNeck) / Math.Log(10)) - 97.684 * (Math.Log(height) / Math.Log(10)) - 104.912; // расчет для женщины
            }
            procentFat = Math.Round(procentFat);
            fat.Text = procentFat + " %";
            if (sexBox.SelectedIndex == 0)
            {
                if (procentFat >= 2 && procentFat <= 5)
                {
                    fat.Text += " - Необходимый жир";
                }
                else if (procentFat >= 6 && procentFat <= 13)
                {
                    fat.Text += " - Атлетическое телосложение";
                }
                else if (procentFat >= 14 && procentFat <= 17)
                {
                    fat.Text += " - Спортивное телосложение";
                }
                else if (procentFat >= 18 && procentFat <= 25)
                {
                    fat.Text += " - Обычное телосложение";
                }
                else if (procentFat >= 26 && procentFat <= 35)
                {
                    fat.Text += " - Выше нормы";
                }
                else if (procentFat >= 36)
                {
                    fat.Text += " - Ожирение";
                }
            }
        }

        private void sexBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sexBox.SelectedIndex == 0)
            {
                hipsBox.Visible = false;
                hipsLabel.Visible = false;
            }else
            {
                hipsBox.Visible = true;
                hipsLabel.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            //Заполнение данных из базы
            var db = new SQLiteConnection("DataBase.db");
            if (countPersonals > 0)
            {
                var person = db.Get<Person>(0);
            }
            warning.Text = "";
            //Проверка на заполнение формы
            if (massBox.Text != String.Empty)
            {
                mass = Convert.ToInt32(massBox.Text);
            }
            else
            {
                warning.Text = "Вы не ввели ваш вес.";
            }

            if(ageBox.Text != string.Empty)
            {
                age = Convert.ToInt32(ageBox.Text);
            }
            else
            {
                warning.Text = "Вы не ввели ваш возраст";
            }

            if (heightBox.Text != string.Empty)
            {
                height = Convert.ToInt32(heightBox.Text);
            }
            else
            {
                warning.Text = "Вы не ввели ваш рост";
            }
            // расчёт активности
            switch (activeBox.SelectedIndex)
            {
                case 0:
                    coefficientActive = 1.2;
                    break;
                case 1:
                    coefficientActive = 1.38;
                    break;
                case 2:
                    coefficientActive = 1.46;
                    break;
                case 3:
                    coefficientActive = 1.55;
                    break;
                case 4:
                    coefficientActive = 1.64;
                    break;
                case 5:
                    coefficientActive = 1.73;
                    break;
                case 6:
                    coefficientActive = 1.9;
                    break;
            }
            // Расчёт MTI
            if (mass != 0 && height != 0)
            {
                heightInM = height / 100;
                indexMass = (mass) / (heightInM * heightInM);
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
            //Расчёт рекомендуемумой нормы каллорий.
            if (sexBox.Text != string.Empty)
            {
                if (sexBox.SelectedIndex == 0)
                {
                    bmr = ((9.99 * mass) + (6.25 * height) - (4.92 * age) + 5) * coefficientActive;
                }
                else
                {
                    bmr = ((9.99 * mass) + (6.25 * height) - (4.92 * age) - 161) * coefficientActive;
                }
                colCal.Text = Math.Round(bmr) + " калл";
            }
            if (sexBox.SelectedIndex == 0)
            {
                recomendWater = mass * 35;
                procentFat = 495 / (1.0324 - 0.1907*(Math.Log(varWaist - varNeck)) + 0.1545*(Math.Log(height))) - 450;
            }
            else
            {
                recomendWater = mass * 31;
            }
            waterlabel.Text = recomendWater + " мл";
            //Рекомендуемое число каллорий
            if (wantLess.Checked) { 
            recomendCal = (Convert.ToInt32(bmr) / 100) * 85;
            }else if (wantMore.Checked)
            {
                recomendCal = (Convert.ToInt32(bmr) / 100) * 115;
            }else if (satisfy.Checked)
            {
                valueTarget.Text = massBox.Text;
            }
            recLimitCal.Text = recomendCal + " ккал";
            //Работа с базой данных
            
            if (countPersonals == 0) { 
                var person = new Person
                {   
                        Id = 1,
                        Name = nameBox.Text,
                        sex = sexBox.SelectedIndex,
                        age = age,
                        height = height,
                        mass = mass,
                        activeIndex = activeBox.SelectedIndex,
                        target = Convert.ToInt32(valueTarget.Text),
                        wantDoTarget = wantDoTarget,
                        waist = varWaist,
                        neck = varNeck,
                        hips = varHips
                    };
                db.Insert(person);
            }
        }
    }
}
