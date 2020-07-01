namespace МСЧ52
{
    partial class FormAveragings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAveragings));
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.labelPodrazdelenie = new System.Windows.Forms.Label();
            this.labelNazvOrg = new System.Windows.Forms.Label();
            this.textBoxPodrazdelenie = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxNazvOrg = new System.Windows.Forms.TextBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listViewAveragings = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.comboBoxPatient.Location = new System.Drawing.Point(9, 166);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(153, 21);
            this.comboBoxPatient.TabIndex = 74;
            this.comboBoxPatient.TabStop = false;
            // 
            // labelPodrazdelenie
            // 
            this.labelPodrazdelenie.AutoSize = true;
            this.labelPodrazdelenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPodrazdelenie.Location = new System.Drawing.Point(6, 101);
            this.labelPodrazdelenie.Name = "labelPodrazdelenie";
            this.labelPodrazdelenie.Size = new System.Drawing.Size(114, 16);
            this.labelPodrazdelenie.TabIndex = 63;
            this.labelPodrazdelenie.Text = "Подразделение";
            // 
            // labelNazvOrg
            // 
            this.labelNazvOrg.AutoSize = true;
            this.labelNazvOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNazvOrg.Location = new System.Drawing.Point(6, 55);
            this.labelNazvOrg.Name = "labelNazvOrg";
            this.labelNazvOrg.Size = new System.Drawing.Size(95, 16);
            this.labelNazvOrg.TabIndex = 62;
            this.labelNazvOrg.Text = "Организация";
            // 
            // textBoxPodrazdelenie
            // 
            this.textBoxPodrazdelenie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPodrazdelenie.ForeColor = System.Drawing.Color.Black;
            this.textBoxPodrazdelenie.Location = new System.Drawing.Point(9, 120);
            this.textBoxPodrazdelenie.Multiline = true;
            this.textBoxPodrazdelenie.Name = "textBoxPodrazdelenie";
            this.textBoxPodrazdelenie.Size = new System.Drawing.Size(153, 24);
            this.textBoxPodrazdelenie.TabIndex = 59;
            this.textBoxPodrazdelenie.TabStop = false;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCity.ForeColor = System.Drawing.Color.Black;
            this.textBoxCity.Location = new System.Drawing.Point(9, 28);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(153, 24);
            this.textBoxCity.TabIndex = 58;
            this.textBoxCity.TabStop = false;
            // 
            // textBoxNazvOrg
            // 
            this.textBoxNazvOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNazvOrg.ForeColor = System.Drawing.Color.Black;
            this.textBoxNazvOrg.Location = new System.Drawing.Point(9, 74);
            this.textBoxNazvOrg.Multiline = true;
            this.textBoxNazvOrg.Name = "textBoxNazvOrg";
            this.textBoxNazvOrg.Size = new System.Drawing.Size(153, 24);
            this.textBoxNazvOrg.TabIndex = 60;
            this.textBoxNazvOrg.TabStop = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Подразделение";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Организация";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Город";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(6, 147);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(65, 16);
            this.labelDate.TabIndex = 71;
            this.labelDate.Text = "Пациент";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDel.FlatAppearance.BorderSize = 2;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonDel.Location = new System.Drawing.Point(514, 342);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(133, 48);
            this.buttonDel.TabIndex = 69;
            this.buttonDel.TabStop = false;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonAdd.Location = new System.Drawing.Point(235, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 48);
            this.buttonAdd.TabIndex = 67;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonEdit.Location = new System.Drawing.Point(375, 342);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Size = new System.Drawing.Size(133, 48);
            this.buttonEdit.TabIndex = 68;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listViewAveragings
            // 
            this.listViewAveragings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAveragings.FullRowSelect = true;
            this.listViewAveragings.GridLines = true;
            this.listViewAveragings.HideSelection = false;
            this.listViewAveragings.Location = new System.Drawing.Point(168, 12);
            this.listViewAveragings.MultiSelect = false;
            this.listViewAveragings.Name = "listViewAveragings";
            this.listViewAveragings.Size = new System.Drawing.Size(478, 324);
            this.listViewAveragings.TabIndex = 65;
            this.listViewAveragings.TabStop = false;
            this.listViewAveragings.UseCompatibleStateImageBehavior = false;
            this.listViewAveragings.View = System.Windows.Forms.View.Details;
            this.listViewAveragings.SelectedIndexChanged += new System.EventHandler(this.listViewAveragings_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Пациент";
            this.columnHeader4.Width = 114;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(6, 9);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(47, 16);
            this.labelCity.TabIndex = 61;
            this.labelCity.Text = "Город";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::МСЧ52.Properties.Resources.лого;
            this.pictureBox1.Location = new System.Drawing.Point(12, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // FormAveragings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 401);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.labelPodrazdelenie);
            this.Controls.Add(this.labelNazvOrg);
            this.Controls.Add(this.textBoxPodrazdelenie);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxNazvOrg);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewAveragings);
            this.Controls.Add(this.labelCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAveragings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учреждения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label labelPodrazdelenie;
        private System.Windows.Forms.Label labelNazvOrg;
        private System.Windows.Forms.TextBox textBoxPodrazdelenie;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxNazvOrg;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListView listViewAveragings;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelCity;
    }
}