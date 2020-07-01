using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МСЧ52
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            ShowStaff();
            ShowRegions();
        }
        void ShowRegions()
        {
            comboBoxRegion.Items.Clear();
            foreach (Uchastok uchastokset in Program.MCHSdb.Uchastok)
            {
                string[] item = { uchastokset.Id.ToString() + ". Участок № ", uchastokset.Number.ToString()};
                comboBoxRegion.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count == 1)
            {
                Doctors doctorsSet = listViewStaff.SelectedItems[0].Tag as Doctors;
                textBoxName.Text = doctorsSet.FirstName;
                textBoxSecondName.Text = doctorsSet.MiddleName;
                textBoxLastName.Text = doctorsSet.LastName;
                textBoxSpestialnost.Text = doctorsSet.Spestialnost;
                comboBoxRegion.SelectedIndex = comboBoxRegion.FindString(doctorsSet.Uchastok.Number.ToString());
            }
            else
            {
                textBoxName.Text = "";
                textBoxSecondName.Text = "";
                textBoxLastName.Text = "";
                textBoxSpestialnost.Text = "";
                comboBoxRegion.SelectedItem = null;
            }
        }
        void ShowStaff()
        {
            listViewStaff.Items.Clear();
            foreach (Doctors doctorSet in Program.MCHSdb.Doctors)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    doctorSet.Id.ToString(), doctorSet.FirstName,
                    doctorSet.MiddleName, doctorSet.LastName,
                    doctorSet.Spestialnost, doctorSet.Uchastok.Number.ToString()
                });
                item.Tag = doctorSet;
                listViewStaff.Items.Add(item);
            }
            listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Doctors doctorSet = new Doctors();
                if (textBoxName.Text != "") { doctorSet.FirstName = textBoxName.Text; }
                if (textBoxSecondName.Text != "") { doctorSet.MiddleName = textBoxSecondName.Text; }
                if (textBoxLastName.Text != "") { doctorSet.LastName = textBoxLastName.Text; }
                if (textBoxSpestialnost.Text!="") { doctorSet.Spestialnost = textBoxSpestialnost.Text; }
                if (comboBoxRegion.SelectedItem != null) { doctorSet.IdUchastok = Convert.ToInt32(comboBoxRegion.SelectedItem.ToString().Split('.')[0]); }
                Program.MCHSdb.Doctors.Add(doctorSet);
                Program.MCHSdb.SaveChanges();
                ShowStaff();
            }
            catch
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSecondName.Text != "" && textBoxLastName.Text != ""
                && textBoxSpestialnost.Text!="" && comboBoxRegion.SelectedItem != null)
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    Doctors doctorSet = listViewStaff.SelectedItems[0].Tag as Doctors;
                    doctorSet.FirstName = textBoxName.Text;
                    doctorSet.MiddleName = textBoxSecondName.Text;
                    doctorSet.LastName = textBoxLastName.Text;
                    doctorSet.Spestialnost = textBoxSpestialnost.Text;
                    doctorSet.IdUchastok = Convert.ToInt32(comboBoxRegion.SelectedItem.ToString().Split('.')[0]);
                    Program.MCHSdb.SaveChanges();
                    ShowStaff();
                }
            }
            else
            { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    Doctors doctorSet = listViewStaff.SelectedItems[0].Tag as Doctors;
                    Program.MCHSdb.Doctors.Remove(doctorSet);
                    Program.MCHSdb.SaveChanges();
                    ShowStaff();
                }
                textBoxName.Text = "";
                textBoxSecondName.Text = "";
                textBoxLastName.Text = "";
                textBoxSpestialnost.Text = "";
                comboBoxRegion.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}