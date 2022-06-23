using CONTROL_GASTOS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_GASTOS
{
    public partial class ConceptManagement : Form
    {
        FormMode mode = FormMode.None;
        int id = 0;// Concept's Id to be deleted or modified
        public ConceptManagement()
        {
            InitializeComponent();
            SetInitialState();
        }
        void UnableButtons()
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
        }
        int GetNextID()
        {
            var conceptList = ReadJson();
            return conceptList.Count() + 1;
        }
        void ClearFields()
        {
            txtName.Clear();
            txtDescription.Clear();
            lbID.Text = "-";
            chbIsVisible.Checked = false;
        }
        void SetInitialState()
        {
            ClearFields();
            gbData.Enabled = false;
            UnableButtons();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            GetConcepts();
            id = 0;
            mode = FormMode.None;
        }
        List<Concept> ReadJson()
        {
            var json = string.Empty;
            var conceptList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }
            return conceptList;
        }
        void WriteJson(List<Concept> conceptList)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            json = JsonConvert.SerializeObject(conceptList);
            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
        }
        void GetConcepts()
        {
            var conceptList = ReadJson();
            dgvConcept.DataSource = null;
            dgvConcept.DataSource = conceptList;
        }
        bool FieldsFilled()
        {
            return (!String.IsNullOrWhiteSpace(txtName.Text) || !String.IsNullOrWhiteSpace(txtDescription.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var conceptList = ReadJson();
            var concept = new Concept();
            switch (mode)
            {
                case FormMode.Adding:
                    {
                        if (FieldsFilled())
                        {
                            var conceptCount = conceptList.Count(x => x.Name.ToString().Trim().ToLower() == txtName.Text.Trim().ToLower());
                            if (conceptCount > 0)
                            {
                                MessageBox.Show("The concept already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            }
                            concept = new Concept
                            {
                                Id = int.Parse(lbID.Text),
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                IsEnabled = chbIsVisible.Checked,
                                CreatedDate = DateTime.Now
                            };
                            conceptList.Add(concept);
                            WriteJson(conceptList);
                            MessageBox.Show("Concept added", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();

                        }
                        else
                        {
                            MessageBox.Show("You must fill every field", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                case FormMode.Deleting:
                    {
                        if(id != 0)
                        {
                            conceptList.Remove(conceptList.FirstOrDefault(x => x.Id == id));
                            WriteJson(conceptList);
                            MessageBox.Show("Concept deleted", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();
                        }
                        else
                        {
                            MessageBox.Show("You must select a concept first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                case FormMode.Updating:
                    {
                        if (id != 0)
                        {
                            var conceptCount = conceptList.Count(x => (x.Name.ToString().Trim().ToLower() == txtName.Text.Trim().ToLower()) && (x.Id != int.Parse(lbID.Text)));
                            if (conceptCount > 0)
                            {
                                MessageBox.Show("The concept already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            }
                            concept = new Concept
                            {
                                Id = int.Parse(lbID.Text),
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = conceptList.FirstOrDefault(x => x.Id == id).CreatedDate,
                                IsEnabled = chbIsVisible.Checked,
                                ModifiedDate = DateTime.Now
                            };
                            conceptList.Remove(conceptList.FirstOrDefault(x => x.Id == id));
                            conceptList.Add(concept);
                            WriteJson(conceptList);
                            MessageBox.Show("Concept modified", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();
                        }
                        else
                        {
                            MessageBox.Show("You must select a concept first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Invalid Option");
                        break;
                    }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = FormMode.None;
            SetInitialState();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvConcept.Rows.Count > 0)
            {
                mode = FormMode.Deleting;
                MessageBox.Show("Select a record to delete from the table", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("There are no records to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvConcept.Rows.Count > 0)
            {
                mode = FormMode.Updating;
                MessageBox.Show("Select a record to modify from the table", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("There are no records to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = FormMode.Adding;
            gbData.Enabled = true;
            UnableButtons();
            lbID.Text = GetNextID().ToString();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void dgvConcept_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (mode == FormMode.Updating || mode == FormMode.Deleting)
            {
                if (MessageBox.Show("Do you wish to select the current concept?",
                    "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = int.Parse(dgvConcept.CurrentRow.Cells[0].Value.ToString());
                    var concept = ReadJson().FirstOrDefault(x => x.Id == id);
                    txtDescription.Text = concept.Description;
                    txtName.Text = concept.Name;
                    lbID.Text = concept.Id.ToString();
                    chbIsVisible.Checked = concept.IsEnabled;
                    if (mode == FormMode.Updating) gbData.Enabled = true;
                    UnableButtons();
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    MessageBox.Show("Press the Save button to complete the changes", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}