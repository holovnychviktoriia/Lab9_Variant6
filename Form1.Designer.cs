namespace Lab9_Variant6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMath = new System.Windows.Forms.RadioButton();
            this.rbPhysics = new System.Windows.Forms.RadioButton();
            this.rbProg = new System.Windows.Forms.RadioButton();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProg);
            this.groupBox1.Controls.Add(this.rbPhysics);
            this.groupBox1.Controls.Add(this.rbMath);
            this.groupBox1.Location = new System.Drawing.Point(135, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть предмет";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbMath
            // 
            this.rbMath.AutoSize = true;
            this.rbMath.Location = new System.Drawing.Point(7, 20);
            this.rbMath.Name = "rbMath";
            this.rbMath.Size = new System.Drawing.Size(88, 17);
            this.rbMath.TabIndex = 0;
            this.rbMath.TabStop = true;
            this.rbMath.Text = "Математика";
            this.rbMath.UseVisualStyleBackColor = true;
            // 
            // rbPhysics
            // 
            this.rbPhysics.AutoSize = true;
            this.rbPhysics.Location = new System.Drawing.Point(7, 44);
            this.rbPhysics.Name = "rbPhysics";
            this.rbPhysics.Size = new System.Drawing.Size(62, 17);
            this.rbPhysics.TabIndex = 1;
            this.rbPhysics.TabStop = true;
            this.rbPhysics.Text = "Фізика";
            this.rbPhysics.UseVisualStyleBackColor = true;
            // 
            // rbProg
            // 
            this.rbProg.AutoSize = true;
            this.rbProg.Location = new System.Drawing.Point(7, 68);
            this.rbProg.Name = "rbProg";
            this.rbProg.Size = new System.Drawing.Size(105, 17);
            this.rbProg.TabIndex = 2;
            this.rbProg.TabStop = true;
            this.rbProg.Text = "Програмування";
            this.rbProg.UseVisualStyleBackColor = true;
            // 
            // checkBoxFile
            // 
            this.checkBoxFile.AutoSize = true;
            this.checkBoxFile.Location = new System.Drawing.Point(133, 205);
            this.checkBoxFile.Name = "checkBoxFile";
            this.checkBoxFile.Size = new System.Drawing.Size(143, 17);
            this.checkBoxFile.TabIndex = 1;
            this.checkBoxFile.Text = "Зчитати оцінку з файлу";
            this.checkBoxFile.UseVisualStyleBackColor = true;
            this.checkBoxFile.CheckedChanged += new System.EventHandler(this.checkBoxFile_CheckedChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(130, 244);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(118, 13);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Введіть оцінку (0-100):";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(133, 261);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(216, 20);
            this.textBoxGrade.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(133, 326);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(216, 135);
            this.labelResult.TabIndex = 4;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(133, 287);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(216, 36);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Перевірити";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.checkBoxFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Успішність студента";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProg;
        private System.Windows.Forms.RadioButton rbPhysics;
        private System.Windows.Forms.RadioButton rbMath;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheck;
    }
}

