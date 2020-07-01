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
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
            ShowPatient();
            ShowDoctor();
        }
        void Date()
        {
            if (textBoxData.Text == "")
                textBoxData.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        void ShowDoctor()
        {
            comboBoxDoctor.Items.Clear();
            foreach (Doctors doctorsSet in Program.MCHSdb.Doctors)
            {
                string[] item = { doctorsSet.Id.ToString() + ".", doctorsSet.MiddleName
                + " " + doctorsSet.FirstName};
                comboBoxDoctor.Items.Add(string.Join(" ", item));
            }
        }
        private void listViewPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count == 1)
            {
                Pastients pastientsSet = listViewPatient.SelectedItems[0].Tag as Pastients;
                textBoxName.Text = pastientsSet.FirstName;
                textBoxSecondName.Text = pastientsSet.MiddleName;
                textBoxLastName.Text = pastientsSet.LastName;
                textBoxName.Text = pastientsSet.FirstName;
                comboBoxPol.SelectedItem = pastientsSet.Pol;
                textBoxData.Text = pastientsSet.Data.ToString();
                comboBoxDoctor.SelectedIndex = comboBoxDoctor.FindString(pastientsSet.IdDoctors.ToString());
                textBoxKarta.Text = pastientsSet.Karta;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSecondName.Text = "";
                textBoxLastName.Text = "";
                textBoxName.Text = "";
                comboBoxPol.SelectedItem = null;
                textBoxData.Text = "";
                comboBoxDoctor.SelectedItem = null;
                textBoxKarta.Text = "";
            }
        }
        void ShowPatient()
        {
            listViewPatient.Items.Clear();
            foreach (Pastients pastientset in Program.MCHSdb.Pastients)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pastientset.Id.ToString(), pastientset.FirstName,
                    pastientset.MiddleName, pastientset.LastName,
                    pastientset.Pol,pastientset.Data.ToString("dd.MM.yyyy"),
                    pastientset.Doctors.MiddleName+ " " +pastientset.Doctors.FirstName,
                    pastientset.Karta
                });
                item.Tag = pastientset;
                listViewPatient.Items.Add(item);
            }
            listViewPatient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Pastients pastientsSet = new Pastients();
                if (textBoxName.Text != "") { pastientsSet.FirstName = textBoxName.Text; }
                if (textBoxSecondName.Text != "") { pastientsSet.MiddleName = textBoxSecondName.Text; }
                if (textBoxLastName.Text != "") { pastientsSet.LastName = textBoxLastName.Text; }
                if (textBoxKarta.Text != "") { pastientsSet.Karta = textBoxKarta.Text; }
                if (comboBoxPol.SelectedItem != null) pastientsSet.Pol = comboBoxPol.SelectedItem.ToString();
                if (comboBoxDoctor.SelectedItem != null) pastientsSet.IdDoctors = Convert.ToInt32(comboBoxDoctor.SelectedItem.ToString().Split('.')[0]);
                if (textBoxData.Text != "") pastientsSet.Data = Convert.ToDateTime(textBoxData.Text);
                Program.MCHSdb.Pastients.Add(pastientsSet);
                Program.MCHSdb.SaveChanges();
                ShowPatient();
            }
            catch
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != "") && (textBoxSecondName.Text != "") && (textBoxLastName.Text != "") &&
                (textBoxKarta.Text != "") && (textBoxData.Text != "") &&
                (comboBoxPol.SelectedItem != null) && (comboBoxDoctor.SelectedItem != null))
            {
                if (listViewPatient.SelectedItems.Count == 1)
                {
                    Pastients pastientsSet = listViewPatient.SelectedItems[0].Tag as Pastients;
                    if (textBoxName.Text != "") { pastientsSet.FirstName = textBoxName.Text; }
                    if (textBoxSecondName.Text != "") { pastientsSet.MiddleName = textBoxSecondName.Text; }
                    if (textBoxLastName.Text != "") { pastientsSet.LastName = textBoxLastName.Text; }
                    if (textBoxKarta.Text != "") { pastientsSet.Karta = textBoxKarta.Text; }
                    if (comboBoxPol.SelectedItem != null) pastientsSet.Pol = comboBoxPol.SelectedItem.ToString();
                    if (comboBoxDoctor.SelectedItem != null) pastientsSet.IdDoctors = Convert.ToInt32(comboBoxDoctor.SelectedItem.ToString().Split('.')[0]);
                    if (textBoxData.Text != "") pastientsSet.Data.ToString();
                    ShowPatient();
                }
            }
            else
            { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPatient.SelectedItems.Count == 1)
                {
                    Pastients pastientsSet = listViewPatient.SelectedItems[0].Tag as Pastients;
                    Program.MCHSdb.Pastients.Remove(pastientsSet);
                    Program.MCHSdb.SaveChanges();
                                    ShowPatient();
                }
                textBoxName.Text = "";
                textBoxSecondName.Text = "";
                textBoxLastName.Text = "";
                textBoxKarta.Text = "";
                comboBoxPol.SelectedItem = null;
                comboBoxDoctor.SelectedItem = null;
                textBoxData.Text= "";
            }

            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Date();           
        }

    }
}