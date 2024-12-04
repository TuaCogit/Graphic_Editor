namespace K1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clearFigure = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.T2 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.Button();
            this.ot1 = new System.Windows.Forms.Button();
            this.ot2 = new System.Windows.Forms.Button();
            this.F1 = new System.Windows.Forms.Button();
            this.F2 = new System.Windows.Forms.Button();
            this.F3 = new System.Windows.Forms.Button();
            this.F4 = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vibor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearFigure
            // 
            this.clearFigure.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clearFigure.Enabled = false;
            this.clearFigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearFigure.Location = new System.Drawing.Point(555, 614);
            this.clearFigure.Name = "clearFigure";
            this.clearFigure.Size = new System.Drawing.Size(146, 43);
            this.clearFigure.TabIndex = 6;
            this.clearFigure.Tag = "";
            this.clearFigure.Text = "Удалить фигуру";
            this.toolTip1.SetToolTip(this.clearFigure, "Удаление выбранной фигуры");
            this.clearFigure.UseVisualStyleBackColor = false;
            this.clearFigure.Click += new System.EventHandler(this.clearFigure_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Location = new System.Drawing.Point(728, 612);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(146, 45);
            this.clear.TabIndex = 7;
            this.clear.Text = "Очистить все";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 533);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.F1);
            this.groupBox1.Controls.Add(this.F2);
            this.groupBox1.Controls.Add(this.F3);
            this.groupBox1.Controls.Add(this.F4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(922, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Примитивы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ms);
            this.groupBox2.Controls.Add(this.ot1);
            this.groupBox2.Controls.Add(this.ot2);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(922, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 191);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Геометрические преобразования";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.T2);
            this.groupBox3.Controls.Add(this.T1);
            this.groupBox3.Location = new System.Drawing.Point(922, 561);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 93);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ТМО";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(922, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 84);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Размеры фигур";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Масштабирование:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 604);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 31);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Направления движения мыши");
            // 
            // T2
            // 
            this.T2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T2.BackgroundImage")));
            this.T2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T2.Location = new System.Drawing.Point(79, 21);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(67, 63);
            this.T2.TabIndex = 5;
            this.T2.Tag = "6";
            this.toolTip1.SetToolTip(this.T2, "Симметрическая разность");
            this.T2.UseVisualStyleBackColor = true;
            this.T2.Click += new System.EventHandler(this.button_Click);
            // 
            // T1
            // 
            this.T1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T1.BackgroundImage")));
            this.T1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T1.Location = new System.Drawing.Point(6, 21);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(67, 63);
            this.T1.TabIndex = 4;
            this.T1.Tag = "5";
            this.toolTip1.SetToolTip(this.T1, "Разность ");
            this.T1.UseVisualStyleBackColor = true;
            this.T1.Click += new System.EventHandler(this.button_Click);
            // 
            // ms
            // 
            this.ms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ms.BackgroundImage")));
            this.ms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ms.Location = new System.Drawing.Point(6, 117);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(67, 63);
            this.ms.TabIndex = 10;
            this.ms.Tag = "8";
            this.toolTip1.SetToolTip(this.ms, "Масштабирование по Х");
            this.ms.UseVisualStyleBackColor = true;
            this.ms.Click += new System.EventHandler(this.button_Click);
            // 
            // ot1
            // 
            this.ot1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ot1.BackgroundImage")));
            this.ot1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ot1.Location = new System.Drawing.Point(6, 48);
            this.ot1.Name = "ot1";
            this.ot1.Size = new System.Drawing.Size(67, 63);
            this.ot1.TabIndex = 8;
            this.ot1.Tag = "7";
            this.toolTip1.SetToolTip(this.ot1, "Отражение относительно центра фигуры");
            this.ot1.UseVisualStyleBackColor = true;
            this.ot1.Click += new System.EventHandler(this.button_Click);
            // 
            // ot2
            // 
            this.ot2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ot2.BackgroundImage")));
            this.ot2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ot2.Location = new System.Drawing.Point(79, 48);
            this.ot2.Name = "ot2";
            this.ot2.Size = new System.Drawing.Size(67, 63);
            this.ot2.TabIndex = 9;
            this.ot2.Tag = "9";
            this.toolTip1.SetToolTip(this.ot2, "Отражение относительно прямой общего положения");
            this.ot2.UseVisualStyleBackColor = true;
            this.ot2.Click += new System.EventHandler(this.button_Click);
            // 
            // F1
            // 
            this.F1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F1.BackgroundImage")));
            this.F1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.F1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.F1.Location = new System.Drawing.Point(6, 21);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(67, 63);
            this.F1.TabIndex = 0;
            this.F1.Tag = "1";
            this.toolTip1.SetToolTip(this.F1, "Линия");
            this.F1.UseVisualStyleBackColor = true;
            this.F1.Click += new System.EventHandler(this.button_Click);
            // 
            // F2
            // 
            this.F2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F2.BackgroundImage")));
            this.F2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.F2.Location = new System.Drawing.Point(79, 21);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(67, 63);
            this.F2.TabIndex = 1;
            this.F2.Tag = "2";
            this.toolTip1.SetToolTip(this.F2, "Кривая Эрмита");
            this.F2.UseVisualStyleBackColor = true;
            this.F2.Click += new System.EventHandler(this.button_Click);
            // 
            // F3
            // 
            this.F3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F3.BackgroundImage")));
            this.F3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.F3.Location = new System.Drawing.Point(6, 90);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(67, 63);
            this.F3.TabIndex = 2;
            this.F3.Tag = "3";
            this.toolTip1.SetToolTip(this.F3, "Параллелограмм");
            this.F3.UseVisualStyleBackColor = true;
            this.F3.Click += new System.EventHandler(this.button_Click);
            // 
            // F4
            // 
            this.F4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("F4.BackgroundImage")));
            this.F4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.F4.Location = new System.Drawing.Point(79, 90);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(67, 63);
            this.F4.TabIndex = 3;
            this.F4.Tag = "4";
            this.toolTip1.SetToolTip(this.F4, "Стрелка");
            this.F4.UseVisualStyleBackColor = true;
            this.F4.Click += new System.EventHandler(this.button_Click);
            // 
            // color
            // 
            this.color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("color.BackgroundImage")));
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color.Location = new System.Drawing.Point(1001, 35);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(67, 63);
            this.color.TabIndex = 13;
            this.toolTip1.SetToolTip(this.color, "Выбор цвета");
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(874, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // vibor
            // 
            this.vibor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vibor.BackgroundImage")));
            this.vibor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vibor.Location = new System.Drawing.Point(928, 35);
            this.vibor.Name = "vibor";
            this.vibor.Size = new System.Drawing.Size(67, 63);
            this.vibor.TabIndex = 11;
            this.vibor.Tag = "10";
            this.toolTip1.SetToolTip(this.vibor, "Выбрать фигуру");
            this.vibor.UseVisualStyleBackColor = true;
            this.vibor.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1102, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vibor);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearFigure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.toolTip1.SetToolTip(this, "Выбрать цвет");
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F1;
        private System.Windows.Forms.Button F2;
        private System.Windows.Forms.Button F3;
        private System.Windows.Forms.Button F4;
        private System.Windows.Forms.Button T1;
        private System.Windows.Forms.Button T2;
        private System.Windows.Forms.Button clearFigure;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button ot1;
        private System.Windows.Forms.Button ot2;
        private System.Windows.Forms.Button ms;
        private System.Windows.Forms.Button vibor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

