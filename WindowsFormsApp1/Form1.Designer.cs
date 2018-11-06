namespace WindowsFormsApp1
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.getResult = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.neck = new System.Windows.Forms.TextBox();
            this.waist = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.wantMore = new System.Windows.Forms.RadioButton();
            this.satisfy = new System.Windows.Forms.RadioButton();
            this.wantLess = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.valueTarget = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BJUbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.waterlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recLimitCal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.indexMassText = new System.Windows.Forms.Label();
            this.IMTlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colCal = new System.Windows.Forms.Label();
            this.groupPersonalData = new System.Windows.Forms.GroupBox();
            this.activeBox = new System.Windows.Forms.ComboBox();
            this.sexBox = new System.Windows.Forms.ComboBox();
            this.massBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMas = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupPersonalData.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 20);
            this.toolStripButton1.Text = "Главная";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(72, 429);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(75, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(671, 423);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.getResult);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupPersonalData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(227, 277);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(200, 35);
            this.getResult.TabIndex = 7;
            this.getResult.Text = "Расчитать";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.getResult_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(6, 324);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(636, 67);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.neck);
            this.groupBox7.Controls.Add(this.waist);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(442, 166);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 152);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // neck
            // 
            this.neck.Location = new System.Drawing.Point(126, 62);
            this.neck.Name = "neck";
            this.neck.Size = new System.Drawing.Size(33, 20);
            this.neck.TabIndex = 3;
            // 
            // waist
            // 
            this.waist.Location = new System.Drawing.Point(35, 62);
            this.waist.Name = "waist";
            this.waist.Size = new System.Drawing.Size(33, 20);
            this.waist.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Шея (см)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Приблизительно жира в организме :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Талия (см)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Определение процента жира";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.wantMore);
            this.groupBox6.Controls.Add(this.satisfy);
            this.groupBox6.Controls.Add(this.wantLess);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.valueTarget);
            this.groupBox6.Location = new System.Drawing.Point(6, 203);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 115);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // wantMore
            // 
            this.wantMore.AutoSize = true;
            this.wantMore.Location = new System.Drawing.Point(9, 92);
            this.wantMore.Name = "wantMore";
            this.wantMore.Size = new System.Drawing.Size(113, 17);
            this.wantMore.TabIndex = 15;
            this.wantMore.TabStop = true;
            this.wantMore.Text = "Хочу набрать вес";
            this.wantMore.UseVisualStyleBackColor = true;
            // 
            // satisfy
            // 
            this.satisfy.AutoSize = true;
            this.satisfy.Location = new System.Drawing.Point(9, 69);
            this.satisfy.Name = "satisfy";
            this.satisfy.Size = new System.Drawing.Size(156, 17);
            this.satisfy.TabIndex = 14;
            this.satisfy.TabStop = true;
            this.satisfy.Text = "Мой вес меня устраивает";
            this.satisfy.UseVisualStyleBackColor = true;
            // 
            // wantLess
            // 
            this.wantLess.AutoSize = true;
            this.wantLess.Location = new System.Drawing.Point(9, 46);
            this.wantLess.Name = "wantLess";
            this.wantLess.Size = new System.Drawing.Size(113, 17);
            this.wantLess.TabIndex = 13;
            this.wantLess.TabStop = true;
            this.wantLess.Text = "Хочу снизить вес";
            this.wantLess.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(57, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Цель (кг)";
            // 
            // valueTarget
            // 
            this.valueTarget.Location = new System.Drawing.Point(9, 19);
            this.valueTarget.Name = "valueTarget";
            this.valueTarget.Size = new System.Drawing.Size(37, 20);
            this.valueTarget.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BJUbutton);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.uBox);
            this.groupBox5.Controls.Add(this.bBox);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.jBox);
            this.groupBox5.Location = new System.Drawing.Point(227, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // BJUbutton
            // 
            this.BJUbutton.Location = new System.Drawing.Point(9, 71);
            this.BJUbutton.Name = "BJUbutton";
            this.BJUbutton.Size = new System.Drawing.Size(185, 23);
            this.BJUbutton.TabIndex = 11;
            this.BJUbutton.Text = "Задать норму БЖУ";
            this.BJUbutton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Лимит Б / Ж / У";
            // 
            // uBox
            // 
            this.uBox.Location = new System.Drawing.Point(143, 41);
            this.uBox.Name = "uBox";
            this.uBox.Size = new System.Drawing.Size(51, 20);
            this.uBox.TabIndex = 10;
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(9, 41);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(51, 20);
            this.bBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Лимит Б / Ж / У";
            // 
            // jBox
            // 
            this.jBox.Location = new System.Drawing.Point(75, 41);
            this.jBox.Name = "jBox";
            this.jBox.Size = new System.Drawing.Size(51, 20);
            this.jBox.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.waterlabel);
            this.groupBox4.Location = new System.Drawing.Point(442, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 74);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Норма чистой воды";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterlabel
            // 
            this.waterlabel.AllowDrop = true;
            this.waterlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.waterlabel.AutoSize = true;
            this.waterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterlabel.Location = new System.Drawing.Point(82, 16);
            this.waterlabel.Name = "waterlabel";
            this.waterlabel.Size = new System.Drawing.Size(41, 18);
            this.waterlabel.TabIndex = 0;
            this.waterlabel.Text = "- мл";
            this.waterlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.waterlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.recLimitCal);
            this.groupBox2.Location = new System.Drawing.Point(227, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рекомендуемый лимит";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recLimitCal
            // 
            this.recLimitCal.AllowDrop = true;
            this.recLimitCal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recLimitCal.AutoSize = true;
            this.recLimitCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recLimitCal.Location = new System.Drawing.Point(72, 16);
            this.recLimitCal.Name = "recLimitCal";
            this.recLimitCal.Size = new System.Drawing.Size(58, 18);
            this.recLimitCal.TabIndex = 0;
            this.recLimitCal.Text = "- Ккал";
            this.recLimitCal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recLimitCal.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.indexMassText);
            this.groupBox3.Controls.Add(this.IMTlabel);
            this.groupBox3.Location = new System.Drawing.Point(442, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // indexMassText
            // 
            this.indexMassText.AutoSize = true;
            this.indexMassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexMassText.Location = new System.Drawing.Point(43, 44);
            this.indexMassText.Name = "indexMassText";
            this.indexMassText.Size = new System.Drawing.Size(106, 15);
            this.indexMassText.TabIndex = 1;
            this.indexMassText.Text = "Нормальный вес";
            this.indexMassText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMTlabel
            // 
            this.IMTlabel.AllowDrop = true;
            this.IMTlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IMTlabel.AutoEllipsis = true;
            this.IMTlabel.AutoSize = true;
            this.IMTlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMTlabel.Location = new System.Drawing.Point(72, 17);
            this.IMTlabel.Name = "IMTlabel";
            this.IMTlabel.Size = new System.Drawing.Size(60, 18);
            this.IMTlabel.TabIndex = 0;
            this.IMTlabel.Text = "ИМТ: -";
            this.IMTlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colCal);
            this.groupBox1.Location = new System.Drawing.Point(227, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Суточная норма каллорий";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colCal
            // 
            this.colCal.AllowDrop = true;
            this.colCal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colCal.AutoSize = true;
            this.colCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colCal.Location = new System.Drawing.Point(68, 16);
            this.colCal.Name = "colCal";
            this.colCal.Size = new System.Drawing.Size(58, 18);
            this.colCal.TabIndex = 0;
            this.colCal.Text = "- Ккал";
            this.colCal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupPersonalData
            // 
            this.groupPersonalData.BackColor = System.Drawing.Color.Azure;
            this.groupPersonalData.Controls.Add(this.activeBox);
            this.groupPersonalData.Controls.Add(this.sexBox);
            this.groupPersonalData.Controls.Add(this.massBox);
            this.groupPersonalData.Controls.Add(this.heightBox);
            this.groupPersonalData.Controls.Add(this.ageBox);
            this.groupPersonalData.Controls.Add(this.nameBox);
            this.groupPersonalData.Controls.Add(this.label6);
            this.groupPersonalData.Controls.Add(this.labelMas);
            this.groupPersonalData.Controls.Add(this.labelHeight);
            this.groupPersonalData.Controls.Add(this.labelAge);
            this.groupPersonalData.Controls.Add(this.labelSex);
            this.groupPersonalData.Controls.Add(this.labelName);
            this.groupPersonalData.Location = new System.Drawing.Point(6, 6);
            this.groupPersonalData.Name = "groupPersonalData";
            this.groupPersonalData.Size = new System.Drawing.Size(206, 191);
            this.groupPersonalData.TabIndex = 0;
            this.groupPersonalData.TabStop = false;
            this.groupPersonalData.Text = "Данные пользователя";
            this.groupPersonalData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // activeBox
            // 
            this.activeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeBox.FormattingEnabled = true;
            this.activeBox.Location = new System.Drawing.Point(9, 157);
            this.activeBox.Name = "activeBox";
            this.activeBox.Size = new System.Drawing.Size(191, 21);
            this.activeBox.TabIndex = 12;
            // 
            // sexBox
            // 
            this.sexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sexBox.FormattingEnabled = true;
            this.sexBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sexBox.Location = new System.Drawing.Point(100, 41);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(100, 21);
            this.sexBox.TabIndex = 11;
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(100, 108);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(100, 20);
            this.massBox.TabIndex = 10;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(100, 86);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 9;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(100, 64);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Активность";
            // 
            // labelMas
            // 
            this.labelMas.AutoSize = true;
            this.labelMas.Location = new System.Drawing.Point(43, 111);
            this.labelMas.Name = "labelMas";
            this.labelMas.Size = new System.Drawing.Size(46, 13);
            this.labelMas.TabIndex = 4;
            this.labelMas.Text = "Вес (кг)";
            this.labelMas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(35, 89);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(54, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Рост (см)";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelHeight.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(43, 67);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Возраст";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(65, 44);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(27, 13);
            this.labelSex.TabIndex = 1;
            this.labelSex.Text = "Пол";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelSex.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(63, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "fMain";
            this.Text = "Form1";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupPersonalData.ResumeLayout(false);
            this.groupPersonalData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupPersonalData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMas;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.ComboBox activeBox;
        private System.Windows.Forms.ComboBox sexBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recLimitCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label colCal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label waterlabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label indexMassText;
        private System.Windows.Forms.Label IMTlabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BJUbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jBox;
        private System.Windows.Forms.RadioButton wantMore;
        private System.Windows.Forms.RadioButton satisfy;
        private System.Windows.Forms.RadioButton wantLess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox valueTarget;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox neck;
        private System.Windows.Forms.TextBox waist;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button getResult;
    }
}

