namespace МСЧ52
{
    partial class FormFacilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacilities));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.listViewFacilities = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPatient = new System.Windows.Forms.Label();
            this.textBoxFacilitie = new System.Windows.Forms.TextBox();
            this.labelFacilitie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::МСЧ52.Properties.Resources.лого;
            this.pictureBox1.Location = new System.Drawing.Point(11, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDel.FlatAppearance.BorderSize = 2;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDel.Location = new System.Drawing.Point(468, 241);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(133, 48);
            this.buttonDel.TabIndex = 49;
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
            this.buttonAdd.Location = new System.Drawing.Point(189, 241);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 48);
            this.buttonAdd.TabIndex = 47;
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
            this.buttonEdit.Location = new System.Drawing.Point(329, 241);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEdit.Size = new System.Drawing.Size(133, 48);
            this.buttonEdit.TabIndex = 48;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(11, 31);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPatient.TabIndex = 46;
            this.comboBoxPatient.TabStop = false;
            // 
            // listViewFacilities
            // 
            this.listViewFacilities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFacilities.FullRowSelect = true;
            this.listViewFacilities.GridLines = true;
            this.listViewFacilities.HideSelection = false;
            this.listViewFacilities.Location = new System.Drawing.Point(123, 12);
            this.listViewFacilities.MultiSelect = false;
            this.listViewFacilities.Name = "listViewFacilities";
            this.listViewFacilities.Size = new System.Drawing.Size(478, 223);
            this.listViewFacilities.TabIndex = 45;
            this.listViewFacilities.TabStop = false;
            this.listViewFacilities.UseCompatibleStateImageBehavior = false;
            this.listViewFacilities.View = System.Windows.Forms.View.Details;
            this.listViewFacilities.SelectedIndexChanged += new System.EventHandler(this.listViewFacilities_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Пациент";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Льгота";
            this.columnHeader2.Width = 220;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatient.Location = new System.Drawing.Point(8, 12);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(65, 16);
            this.labelPatient.TabIndex = 44;
            this.labelPatient.Text = "Пациент";
            // 
            // textBoxFacilitie
            // 
            this.textBoxFacilitie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFacilitie.Location = new System.Drawing.Point(11, 74);
            this.textBoxFacilitie.Name = "textBoxFacilitie";
            this.textBoxFacilitie.Size = new System.Drawing.Size(100, 20);
            this.textBoxFacilitie.TabIndex = 51;
            this.textBoxFacilitie.TabStop = false;
            // 
            // labelFacilitie
            // 
            this.labelFacilitie.AutoSize = true;
            this.labelFacilitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFacilitie.Location = new System.Drawing.Point(8, 55);
            this.labelFacilitie.Name = "labelFacilitie";
            this.labelFacilitie.Size = new System.Drawing.Size(53, 16);
            this.labelFacilitie.TabIndex = 52;
            this.labelFacilitie.Text = "Льгота";
            // 
            // FormFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 300);
            this.Controls.Add(this.labelFacilitie);
            this.Controls.Add(this.textBoxFacilitie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.listViewFacilities);
            this.Controls.Add(this.labelPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacilities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Льготы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.ListView listViewFacilities;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.TextBox textBoxFacilitie;
        private System.Windows.Forms.Label labelFacilitie;
    }
}