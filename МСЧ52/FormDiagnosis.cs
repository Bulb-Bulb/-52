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
    public partial class FormDiagnosis : Form
    {
        public FormDiagnosis()
        {
            InitializeComponent();
            ShowPatient();
            ShowDiagnosis();
        }
        void ShowPatient()
        {
            comboBoxPatient.Items.Clear();
            foreach (Pastients pastientsSet in Program.MCHSdb.Pastients)
            {
                string[] item = { pastientsSet.Id.ToString() + ".", pastientsSet.MiddleName
                +" " + pastientsSet.FirstName +" " + pastientsSet.LastName};
                comboBoxPatient.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDiagnosis.SelectedItems.Count == 1)
            {
                Diagnosis DiagnosisSet = listViewDiagnosis.SelectedItems[0].Tag as Diagnosis;
                textBoxDiagnos.Text = DiagnosisSet.Name;
                comboBoxPatient.SelectedIndex = comboBoxPatient.FindString(DiagnosisSet.IdPastients.ToString());
            }
            else
            {
                textBoxDiagnos.Text = "";
                comboBoxPatient.SelectedItem = null;
            }
        }
        void ShowDiagnosis()
        {
            listViewDiagnosis.Items.Clear();
            foreach (Diagnosis DiagnosisSet in Program.MCHSdb.Diagnosis)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    DiagnosisSet.Id.ToString(), DiagnosisSet.Pastients.MiddleName+" "
                    +DiagnosisSet.Pastients.FirstName +" " +DiagnosisSet.Pastients.LastName,
                    DiagnosisSet.Name
                });
                item.Tag = DiagnosisSet;
                listViewDiagnosis.Items.Add(item);
            }
            listViewDiagnosis.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnosis DiagnosisSet = new Diagnosis();
                if (textBoxDiagnos.Text != "") { DiagnosisSet.Name = textBoxDiagnos.Text; }
                if (comboBoxPatient.SelectedItem != null) { DiagnosisSet.IdPastients = Convert.ToInt32(comboBoxPatient.SelectedItem.ToString().Split('.')[0]); }
                Program.MCHSdb.Diagnosis.Add(DiagnosisSet);
                Program.MCHSdb.SaveChanges();
                ShowDiagnosis();
            }
            catch
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((textBoxDiagnos.Text != "") && (comboBoxPatient.SelectedItem != null))
            {
                if (listViewDiagnosis.SelectedItems.Count == 1)
                {
                    Diagnosis DiagnosisSet = listViewDiagnosis.SelectedItems[0].Tag as Diagnosis;
                    if (textBoxDiagnos.Text != "") { DiagnosisSet.Name = textBoxDiagnos.Text; }
                    if (comboBoxPatient.SelectedItem != null) { DiagnosisSet.IdPastients = Convert.ToInt32(comboBoxPatient.SelectedItem.ToString().Split('.')[0]); }
                    Program.MCHSdb.SaveChanges();
                    ShowDiagnosis();
                }
            }
            else
            { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDiagnosis.SelectedItems.Count == 1)
                {
                    Diagnosis DiagnosisSet = listViewDiagnosis.SelectedItems[0].Tag as Diagnosis;
                    Program.MCHSdb.Diagnosis.Remove(DiagnosisSet);
                    Program.MCHSdb.SaveChanges();
                    ShowDiagnosis();
                }
                textBoxDiagnos.Text = "";
                comboBoxPatient.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
