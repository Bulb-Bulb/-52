namespace МСЧ52
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonRegion = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonPatients = new System.Windows.Forms.Button();
            this.buttonDiagnosis = new System.Windows.Forms.Button();
            this.buttonFacilities = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAveragings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegion
            // 
            this.buttonRegion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRegion.FlatAppearance.BorderSize = 2;
            this.buttonRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegion.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegion.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonRegion.Location = new System.Drawing.Point(251, 40);
            this.buttonRegion.Name = "buttonRegion";
            this.buttonRegion.Size = new System.Drawing.Size(195, 46);
            this.buttonRegion.TabIndex = 1;
            this.buttonRegion.TabStop = false;
            this.buttonRegion.Text = "Участки";
            this.buttonRegion.UseVisualStyleBackColor = false;
            this.buttonRegion.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStaff.FlatAppearance.BorderSize = 2;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonStaff.Location = new System.Drawing.Point(454, 40);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(195, 46);
            this.buttonStaff.TabIndex = 2;
            this.buttonStaff.TabStop = false;
            this.buttonStaff.Text = "Сотрудники";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonPatients
            // 
            this.buttonPatients.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPatients.FlatAppearance.BorderSize = 2;
            this.buttonPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatients.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatients.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonPatients.Location = new System.Drawing.Point(251, 92);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(195, 46);
            this.buttonPatients.TabIndex = 3;
            this.buttonPatients.TabStop = false;
            this.buttonPatients.Text = "Прием пациентов";
            this.buttonPatients.UseVisualStyleBackColor = false;
            this.buttonPatients.Click += new System.EventHandler(this.buttonDepartment_Click);
            // 
            // buttonDiagnosis
            // 
            this.buttonDiagnosis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDiagnosis.FlatAppearance.BorderSize = 2;
            this.buttonDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagnosis.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiagnosis.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDiagnosis.Location = new System.Drawing.Point(454, 92);
            this.buttonDiagnosis.Name = "buttonDiagnosis";
            this.buttonDiagnosis.Size = new System.Drawing.Size(195, 46);
            this.buttonDiagnosis.TabIndex = 4;
            this.buttonDiagnosis.TabStop = false;
            this.buttonDiagnosis.Text = "Диагнозы";
            this.buttonDiagnosis.UseVisualStyleBackColor = false;
            this.buttonDiagnosis.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonFacilities
            // 
            this.buttonFacilities.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFacilities.FlatAppearance.BorderSize = 2;
            this.buttonFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacilities.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacilities.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonFacilities.Location = new System.Drawing.Point(253, 144);
            this.buttonFacilities.Name = "buttonFacilities";
            this.buttonFacilities.Size = new System.Drawing.Size(195, 46);
            this.buttonFacilities.TabIndex = 5;
            this.buttonFacilities.TabStop = false;
            this.buttonFacilities.Text = "Льготы";
            this.buttonFacilities.UseVisualStyleBackColor = false;
            this.buttonFacilities.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonExit.Location = new System.Drawing.Point(251, 205);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(396, 46);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Выход ";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(8, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(165, 18);
            this.labelHello.TabIndex = 8;
            this.labelHello.Text = "Добро пожаловать,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::МСЧ52.Properties.Resources.лого;
            this.pictureBox1.Location = new System.Drawing.Point(11, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAveragings
            // 
            this.buttonAveragings.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAveragings.FlatAppearance.BorderSize = 2;
            this.buttonAveragings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAveragings.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAveragings.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonAveragings.Location = new System.Drawing.Point(454, 144);
            this.buttonAveragings.Name = "buttonAveragings";
            this.buttonAveragings.Size = new System.Drawing.Size(195, 46);
            this.buttonAveragings.TabIndex = 10;
            this.buttonAveragings.TabStop = false;
            this.buttonAveragings.Text = "Учреждения";
            this.buttonAveragings.UseVisualStyleBackColor = false;
            this.buttonAveragings.Click += new System.EventHandler(this.buttonAveragings_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 288);
            this.Controls.Add(this.buttonAveragings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFacilities);
            this.Controls.Add(this.buttonDiagnosis);
            this.Controls.Add(this.buttonPatients);
            this.Controls.Add(this.buttonStaff);
            this.Controls.Add(this.buttonRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegion;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Button buttonDiagnosis;
        private System.Windows.Forms.Button buttonFacilities;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAveragings;
    }
}

