namespace ooop6
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
            this.buttoncircle = new System.Windows.Forms.Button();
            this.buttonsquare = new System.Windows.Forms.Button();
            this.buttontri = new System.Windows.Forms.Button();
            this.buttonsizeplus = new System.Windows.Forms.Button();
            this.buttonsizeminus = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonsel = new System.Windows.Forms.Button();
            this.buttoncol = new System.Windows.Forms.Button();
            this.checkBoxctrl = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncircle
            // 
            this.buttoncircle.Location = new System.Drawing.Point(53, 38);
            this.buttoncircle.Name = "buttoncircle";
            this.buttoncircle.Size = new System.Drawing.Size(85, 41);
            this.buttoncircle.TabIndex = 0;
            this.buttoncircle.Text = "Круг";
            this.buttoncircle.UseVisualStyleBackColor = true;
            this.buttoncircle.Click += new System.EventHandler(this.buttoncircle_Click);
            // 
            // buttonsquare
            // 
            this.buttonsquare.Location = new System.Drawing.Point(168, 38);
            this.buttonsquare.Name = "buttonsquare";
            this.buttonsquare.Size = new System.Drawing.Size(75, 41);
            this.buttonsquare.TabIndex = 1;
            this.buttonsquare.Text = "Квадрат";
            this.buttonsquare.UseVisualStyleBackColor = true;
            this.buttonsquare.Click += new System.EventHandler(this.buttonsquare_Click);
            // 
            // buttontri
            // 
            this.buttontri.Location = new System.Drawing.Point(264, 38);
            this.buttontri.Name = "buttontri";
            this.buttontri.Size = new System.Drawing.Size(109, 41);
            this.buttontri.TabIndex = 2;
            this.buttontri.Text = "Треугольник";
            this.buttontri.UseVisualStyleBackColor = true;
            this.buttontri.Click += new System.EventHandler(this.buttontri_Click);
            // 
            // buttonsizeplus
            // 
            this.buttonsizeplus.Location = new System.Drawing.Point(53, 85);
            this.buttonsizeplus.Name = "buttonsizeplus";
            this.buttonsizeplus.Size = new System.Drawing.Size(85, 23);
            this.buttonsizeplus.TabIndex = 3;
            this.buttonsizeplus.Text = "+";
            this.buttonsizeplus.UseVisualStyleBackColor = true;
            this.buttonsizeplus.Click += new System.EventHandler(this.buttonsizeplus_Click);
            // 
            // buttonsizeminus
            // 
            this.buttonsizeminus.Location = new System.Drawing.Point(168, 85);
            this.buttonsizeminus.Name = "buttonsizeminus";
            this.buttonsizeminus.Size = new System.Drawing.Size(75, 23);
            this.buttonsizeminus.TabIndex = 4;
            this.buttonsizeminus.Text = "-";
            this.buttonsizeminus.UseVisualStyleBackColor = true;
            this.buttonsizeminus.Click += new System.EventHandler(this.buttonsizeminus_Click);
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(53, 181);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(85, 23);
            this.buttondel.TabIndex = 5;
            this.buttondel.Text = "Удалить";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // buttonsel
            // 
            this.buttonsel.Location = new System.Drawing.Point(391, 38);
            this.buttonsel.Name = "buttonsel";
            this.buttonsel.Size = new System.Drawing.Size(88, 41);
            this.buttonsel.TabIndex = 6;
            this.buttonsel.Text = "Прямая";
            this.buttonsel.UseVisualStyleBackColor = true;
            this.buttonsel.Click += new System.EventHandler(this.buttonsel_Click);
            // 
            // buttoncol
            // 
            this.buttoncol.Location = new System.Drawing.Point(53, 126);
            this.buttoncol.Name = "buttoncol";
            this.buttoncol.Size = new System.Drawing.Size(85, 23);
            this.buttoncol.TabIndex = 7;
            this.buttoncol.Text = "Цвет";
            this.buttoncol.UseVisualStyleBackColor = true;
            this.buttoncol.Click += new System.EventHandler(this.buttoncol_Click);
            // 
            // checkBoxctrl
            // 
            this.checkBoxctrl.AutoSize = true;
            this.checkBoxctrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxctrl.Location = new System.Drawing.Point(168, 184);
            this.checkBoxctrl.Name = "checkBoxctrl";
            this.checkBoxctrl.Size = new System.Drawing.Size(49, 20);
            this.checkBoxctrl.TabIndex = 8;
            this.checkBoxctrl.TabStop = false;
            this.checkBoxctrl.Text = "cntrl";
            this.checkBoxctrl.UseVisualStyleBackColor = true;
            this.checkBoxctrl.CheckedChanged += new System.EventHandler(this.checkBoxctrl_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выделить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Убрать выделение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxctrl);
            this.Controls.Add(this.buttoncol);
            this.Controls.Add(this.buttonsel);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.buttonsizeminus);
            this.Controls.Add(this.buttonsizeplus);
            this.Controls.Add(this.buttontri);
            this.Controls.Add(this.buttonsquare);
            this.Controls.Add(this.buttoncircle);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncircle;
        private System.Windows.Forms.Button buttonsquare;
        private System.Windows.Forms.Button buttontri;
        private System.Windows.Forms.Button buttonsizeplus;
        private System.Windows.Forms.Button buttonsizeminus;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonsel;
        private System.Windows.Forms.Button buttoncol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxctrl;
    }
}

