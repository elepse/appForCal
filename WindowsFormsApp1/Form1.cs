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
using MetroFramework.Components;
using MetroFramework.Forms;


namespace WindowsFormsApp1
{
    public partial class fMain : MetroForm
    {
        public float recomendWater,recomendCal;
        public int age, mass,varWaist, varNeck, varHips, wantDoTarget, countPersonals;
        public double indexMass,bmr, coefficientActive, procentFat, heightInM, height, SR, MSJ;
        double recomendProteins, recomendFats, recomendCarbohydrates; // Белки Жиры Углеводы
        public string name;
        public const int varWantLess = 1, varSatisfy = 2, varWantMore = 3;
        public bool dataChanged = false;

        DataTable dtEatenDish = new DataTable();
        public fMain()
        {
            //начало программы
            InitializeComponent();
            sexBox.SelectedIndex = 0;
            activeBox.SelectedIndex = 0;

            //Заполнение данных из базы
            var db = new SQLiteConnection("DataBase.db");
            db.CreateTable<Person>();
            countPersonals = db.Table<Person>().Count();
            if (countPersonals > 0)
            {
                var person = db.Get<Person>(1);
                nameBox.Text = person.Name;
                sexBox.SelectedIndex = person.sex;
                ageBox.Text = Convert.ToString(person.age);
                heightBox.Text = Convert.ToString(person.height);
                massBox.Text = Convert.ToString(person.mass);
                activeBox.SelectedIndex = person.activeIndex;
                valueTarget.Text = Convert.ToString(person.target);
                wantDoTarget = person.wantDoTarget;
                if(person.waist != 0) { 
                waist.Text = Convert.ToString(person.waist);
                }
                if (person.hips != 0)
                {
                    hipsBox.Text = Convert.ToString(person.hips);
                }
                if (person.neck != 0)
                {
                    neck.Text = Convert.ToString(person.neck);
                }
                if (wantDoTarget == varWantLess)
                {
                    wantLess.Checked = true;
                }else if (wantDoTarget == varSatisfy) {
                    satisfy.Checked = true;
                }else if (wantDoTarget == varWantMore) {
                    wantMore.Checked = true;
                }
                resultFat_Click(null, null);
                getResult_Click(null, null);
            }
            db.Close();
            textBox1_TextChanged_1(null, null);

            // Генерация таблицы съеденого
            dtEatenDish.Columns.Add("Наименование");
            dtEatenDish.Columns.Add("Белки", typeof(int));
            dtEatenDish.Columns.Add("Жиры", typeof(int));
            dtEatenDish.Columns.Add("Углеводы", typeof(int));
            dtEatenDish.Columns.Add("Калл", typeof(int));
            // колонка с картинкой
            DataColumn imageColumn = new DataColumn("Удаление"); // Create the column.
            imageColumn.DataType = System.Type.GetType("System.Byte[]"); // Type byte[] to store image bytes.
            imageColumn.AllowDBNull = true;
            imageColumn.Caption = "Удаление";
            dtEatenDish.Columns.Add(imageColumn);

            var dgvEatenDish = eatenDishes;
            dgvEatenDish.AutoGenerateColumns = true;
            dgvEatenDish.DataSource = dtEatenDish; // добавление колонки в таблицу
            dgvEatenDish.Columns["Наименование"].Width = 280;
            dgvEatenDish.Columns["Белки"].Width = 60;
            dgvEatenDish.Columns["Жиры"].Width = 60;
            dgvEatenDish.Columns["Углеводы"].Width = 60;
            dgvEatenDish.Columns["Калл"].Width = 60;
            dgvEatenDish.Columns["Удаление"].Width = 60;
        }

        private void showSearchFoods(object sender, EventArgs e)
        {
            ChageRequestSearchFoods(null, null);
            resultSearchFoods.Visible = true;
            resultSearchFoods.BringToFront();
        }

        private void hideSearchFoods(object sender, EventArgs e)
        {
            resultSearchFoods.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var dataBase = new SQLiteConnection("DataBase.db");
            dataBase.CreateTable<Product>();
            var products = dataBase.Table<Product>();
            DataTable dt = new DataTable();
            //создание колонок
            dt.Columns.Add("Наименование");
            dt.Columns.Add("Белки", typeof(int));
            dt.Columns.Add("Жиры", typeof(int));
            dt.Columns.Add("Углеводы", typeof(int));
            dt.Columns.Add("Калл", typeof(int));
            //Поиск продуктов, проверка на пустую строку
            if (SearchProducts.Text != string.Empty)
            {
                products = from s in products
                           where s.Name.StartsWith(SearchProducts.Text)
                           select s;
            }
               // работаем с кажой строкой массива
            foreach (var product in products)
            {
                var row = dt.NewRow();
                //заполнение колонок
                row["Наименование"] = product.Name;
                row["Белки"] = product.proteins;
                row["Жиры"] = product.fats;
                row["Углеводы"] = product.carbohydrates;
                row["Калл"] = product.calories;
                dt.Rows.Add(row);
            }
            var dgv = dataGridView1;
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = dt; // добавление колонки в таблицу
            dgv.Columns["Наименование"].Width = 300;
            dgv.Columns["Белки"].Width = 75;
            dgv.Columns["Жиры"].Width = 75;
            dgv.Columns["Углеводы"].Width = 75;
            dgv.Columns["Калл"].Width = 75;
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void newProductName_TextChanged(object sender, EventArgs e)
        {
            newProductCalories_TextChanged(null, null);
        }

        private void newProductProteins_TextChanged(object sender, EventArgs e)
        {
            newProductCalories_TextChanged(null, null);
        }

        private void newProductFats_TextChanged(object sender, EventArgs e)
        {
            newProductCalories_TextChanged(null, null);
        }

        private void newProductСarbohydrates_TextChanged(object sender, EventArgs e)
        {
            newProductCalories_TextChanged(null, null);
        }

        private void newProductCalories_TextChanged(object sender, EventArgs e)
        {
            if(newProductProteins.Text != string.Empty && newProductFats.Text != string.Empty && newProductСarbohydrates.Text != string.Empty)
            {
                int calories = (Convert.ToInt32(newProductProteins.Text) * 4) + (Convert.ToInt32(newProductFats.Text) * 8) + (Convert.ToInt32(newProductСarbohydrates.Text) * 4);
                newProductCalories.Text = Convert.ToString(calories);
            }
        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            //Создание нового продукта
            if (newProductName.Text != string.Empty && newProductProteins.Text != string.Empty && newProductFats.Text != string.Empty && newProductСarbohydrates.Text != string.Empty && newProductCalories.Text != string.Empty)
            {
                var db = new SQLiteConnection("DataBase.db");
                var product = new Product
                {
                    Id = 1,
                    Name = newProductName.Text,
                    proteins = Convert.ToInt32(newProductProteins.Text),
                    fats = Convert.ToInt32(newProductFats.Text),
                    carbohydrates = Convert.ToInt32(newProductСarbohydrates.Text),
                    calories = Convert.ToInt32(newProductCalories.Text)
                };
                db.Insert(product);
                db.Close();
                textBox1_TextChanged_1(null, null);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            hideSearchFoods(null, null);
        }

        private void inputSearchFood_Click(object sender, EventArgs e)
        {
            resultSearchFoods.Visible = true;
        }

        private void takeDish(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                var row = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[row];
                string value = Convert.ToString(selectedRow.Cells["Наименование"].Value);
                inputSearchFood.Text = value;
                resultSearchFoods.Visible = false;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
            getSumNutritionalValue(null, null);
        }

        // Удаление строки в съеденных блюдах
        private void deleteDish(object sender, DataGridViewCellEventArgs e) 
        {
            // Находим заголовок ячейки по которой кликнули
            var checkDelete = eatenDishes.Columns[eatenDishes.CurrentCell.ColumnIndex].HeaderText.ToString();
            if(checkDelete == "Удаление") // Если клик был по иконки удаление, удаляем строку
            {
                var deleteRow = eatenDishes.Columns[eatenDishes.CurrentCell.RowIndex];
                eatenDishes.Rows.RemoveAt(Convert.ToInt32(deleteRow.Index));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dataBase = new SQLiteConnection("DataBase.db");
            dataBase.CreateTable<Product>();
            
            var products = dataBase.Table<Product>();

            products = from s in products
                       where s.Name.Equals(inputSearchFood.Text)
                       select s;

            foreach (var product in products)
            {
                var row = dtEatenDish.NewRow();
                row["Наименование"] = product.Name;
                row["Белки"] = product.proteins;
                row["Жиры"] = product.fats;
                row["Углеводы"] = product.carbohydrates;
                row["Калл"] = product.calories;
                // картинка
                Image image = Image.FromFile("delete.png");
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] b = memoryStream.ToArray();
                row["Удаление"] = b;

                dtEatenDish.Rows.Add(row);
            }
            dataBase.Close();
            inputSearchFood.Text = string.Empty;
            getSumNutritionalValue(null, null);
        }

        private void getSumNutritionalValue(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //получаем пищевую ценность
            int proteins = 0, fats = 0, callories = 0, carbohydrates = 0;
            for (int i = 0; i < eatenDishes.RowCount - 1; i++)
            {
                proteins += Convert.ToInt32(eatenDishes[1, i].Value);
            }
            for (int i = 0; i < eatenDishes.RowCount - 1; i++)
            {
                fats += Convert.ToInt32(eatenDishes[2, i].Value);
            }
            for (int i = 0; i < eatenDishes.RowCount - 1; i++)
            {
                callories += Convert.ToInt32(eatenDishes[3, i].Value);
            }
            for (int i = 0; i < eatenDishes.RowCount - 1; i++)
            {
                carbohydrates += Convert.ToInt32(eatenDishes[4, i].Value);
            }
            
            // Заполняем наши дневные цели
            string normProteinsString = proteins.ToString() + " / " + Math.Round(recomendProteins),
            normFatsString = fats.ToString() + " / " + Math.Round(recomendFats),
            normCarbohydratesString = carbohydrates.ToString() + " / " + Math.Round(recomendCarbohydrates),
            normCalsString = callories.ToString() + " / " + recomendCal;
            // Закрашиваем на основе колличества
            if (proteins >= recomendProteins)
            {
                normProteins.Refresh();
                normProteins.CreateGraphics().FillRectangle(Brushes.Orange, normProteins.ClientRectangle);
                Graphics g = Graphics.FromHwnd(normProteins.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normProteinsString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normProteins.ClientRectangle, sf);
            }
            else
            {
                normProteins.Refresh();
                double procentProteins = recomendProteins / 100;
                procentProteins = Math.Round(proteins / procentProteins);
                normProteins.CreateGraphics().FillRectangle(Brushes.Orange, new Rectangle(0, 0, Convert.ToInt32(procentProteins), normProteins.ClientRectangle.Height));
                Graphics g = Graphics.FromHwnd(normProteins.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normProteinsString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normProteins.ClientRectangle,sf);
            }
            //Каллории
            if (callories >= recomendCal)
            {
                normCals.Refresh();
                normCals.CreateGraphics().FillRectangle(Brushes.Green, normCals.ClientRectangle);
                Graphics g = Graphics.FromHwnd(normCals.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normCalsString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normCals.ClientRectangle, sf);
            }
            else
            {
                normCals.Refresh();
                double procentCals = recomendCal / 100;
                procentCals = Math.Round(callories / procentCals);
                normCals.CreateGraphics().FillRectangle(Brushes.Green, new Rectangle(0, 0, Convert.ToInt32(procentCals), normCals.ClientRectangle.Height));
                Graphics g = Graphics.FromHwnd(normCals.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normCalsString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normCals.ClientRectangle, sf);
            }
            //Жиры
            if (fats >= recomendFats)
            {
                normFats.Refresh();
                normFats.CreateGraphics().FillRectangle(Brushes.Yellow, normFats.ClientRectangle);
                Graphics g = Graphics.FromHwnd(normFats.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normFatsString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normFats.ClientRectangle, sf);
            }
            else
            {
                normFats.Refresh();
                double procentFats = recomendFats / 100;
                procentFats = Math.Round(fats / procentFats);
                normFats.CreateGraphics().FillRectangle(Brushes.Yellow, new Rectangle(0, 0, Convert.ToInt32(procentFats), normFats.ClientRectangle.Height));
                Graphics g = Graphics.FromHwnd(normFats.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normFatsString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normFats.ClientRectangle, sf);
            }
            //Углеводы
            if (carbohydrates >= recomendCarbohydrates)
            {
                normCarbohydrates.Refresh();
                normCarbohydrates.CreateGraphics().FillRectangle(Brushes.OrangeRed, normCarbohydrates.ClientRectangle);
                Graphics g = Graphics.FromHwnd(normCarbohydrates.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normCarbohydratesString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normCarbohydrates.ClientRectangle, sf);
            }
            else
            {
                normCarbohydrates.Refresh();
                double procentCarbohydrates = recomendCarbohydrates / 100;
                procentCarbohydrates = Math.Round(carbohydrates / procentCarbohydrates);
                normCarbohydrates.CreateGraphics().FillRectangle(Brushes.OrangeRed, new Rectangle(0, 0, Convert.ToInt32(procentCarbohydrates), normCarbohydrates.ClientRectangle.Height));
                Graphics g = Graphics.FromHwnd(normCarbohydrates.Handle);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(normCarbohydratesString, new Font("Microsoft Sans Serif", 9), Brushes.Black, normCarbohydrates.ClientRectangle, sf);
            }
        }

        private void ChageRequestSearchFoods(object sender, EventArgs e)
        {
            var dataBase = new SQLiteConnection("DataBase.db");
            dataBase.CreateTable<Product>();
            var products = dataBase.Table<Product>();
            DataTable dtResultFoods = new DataTable();
            //создание колонок
            dtResultFoods.Columns.Add("Наименование");
            dtResultFoods.Columns.Add("Белки", typeof(int));
            dtResultFoods.Columns.Add("Жиры", typeof(int));
            dtResultFoods.Columns.Add("Углеводы", typeof(int));
            dtResultFoods.Columns.Add("Калл", typeof(int));
            
            //Поиск продуктов, проверка на пустую строку
            if (inputSearchFood.Text != string.Empty)
            {
                products = from s in products
                           where s.Name.StartsWith(inputSearchFood.Text)
                           select s;
            }
                // работаем с кажой строкой массива
                foreach (var product in products)
                {
                    var row = dtResultFoods.NewRow();
                    //заполнение колонок
                    row["Наименование"] = product.Name;
                    row["Белки"] = product.proteins;
                    row["Жиры"] = product.fats;
                    row["Углеводы"] = product.fats;
                    row["Калл"] = product.calories;
                    dtResultFoods.Rows.Add(row);
            }
            var dgv = dataGridView2;
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = dtResultFoods; // добавление колонки в таблицу
            dgv.Columns["Наименование"].Width = 250;
            dgv.Columns["Белки"].Width = 75;
            dgv.Columns["Жиры"].Width = 75;
            dgv.Columns["Углеводы"].Width = 75;
            dgv.Columns["Калл"].Width = 75;
            dataBase.Close();
        }

        private void IMTlabel_Click(object sender, EventArgs e)
        {

        }

        private void satisfy_CheckedChanged(object sender, EventArgs e)
        {
            if (satisfy.Checked)
            {
                valueTarget.Text = massBox.Text;
            }
            wantDoTarget = varSatisfy;
        }

        private void wantLess_CheckedChanged(object sender, EventArgs e)
        {
            wantDoTarget = varWantLess;
        }

        private void wantMore_CheckedChanged(object sender, EventArgs e)
        {
            wantDoTarget = varWantMore;
        }

        private void resultFat_Click(object sender, EventArgs e)
        {
            if(heightBox.Text != string.Empty)
            {
                height = Convert.ToInt32(heightBox.Text);
            }
            else
            {
                warning.Text = "Вы не ввели рост";
            }
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
                    MSJ = 88.362 + (13.397 * mass) + (4.799 * height) - (5.677 * age);
                    bmr = ((9.99 * mass) + (6.25 * height) - (4.92 * age) + 5) * coefficientActive;
                }
                else
                {
                    MSJ = 447.593 + (9.247 * mass) + (3.098 * height) - (4.330 * age);
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
            // БЖУ
            MSJ = MSJ * coefficientActive;
            SR = Math.Floor(bmr + MSJ) / 2;
            recomendProteins = (SR * 0.4) / 4;
            recomendFats = (SR * 0.2) / 9;
            recomendCarbohydrates = (SR * 0.4) / 4;
            bBox.Text = Convert.ToString(Math.Round(recomendProteins)); 
            jBox.Text = Convert.ToString(Math.Round(recomendFats)); 
            uBox.Text = Convert.ToString(Math.Round(recomendCarbohydrates)); 
            //Работа с базой данных
            var db = new SQLiteConnection("DataBase.db"); // подключение
            countPersonals = db.Table<Person>().Count(); // сколько строк в таблице в базе
            if (countPersonals != 0) {  
                // Обновляю данные
                var person = new Person
                {   
                        Id = 1,
                        Name = nameBox.Text,
                        sex = sexBox.SelectedIndex,
                        age = age,
                        height = Convert.ToInt32(height),
                        mass = mass,
                        activeIndex = activeBox.SelectedIndex,
                        target = Convert.ToInt32(valueTarget.Text),
                        wantDoTarget = wantDoTarget,
                        waist = varWaist,
                        neck = varNeck,
                        hips = varHips
                    };
                db.Update(person);
                db.Close();
            }
            else
            {
                // сохраняю пользователя
                var person = new Person
                {
                    Id = 1,
                    Name = nameBox.Text,
                    sex = sexBox.SelectedIndex,
                    age = age,
                    height = Convert.ToInt32(height),
                    mass = mass,
                    activeIndex = activeBox.SelectedIndex,
                    target = Convert.ToInt32(valueTarget.Text),
                    wantDoTarget = wantDoTarget,
                    waist = varWaist,
                    neck = varNeck,
                    hips = varHips
                };
                db.Insert(person);
                db.Close();
            }
        }
    }
}
