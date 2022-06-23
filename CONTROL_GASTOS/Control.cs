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
using CONTROL_GASTOS.Models;
using Newtonsoft.Json;

namespace CONTROL_GASTOS
{
    public enum FormMode
    {
        Adding,
        Deleting,
        Updating,
        None //The form is totally unabled
    }
    public partial class Control : Form
    {
        int id = 0;//Expense to be deleted or modified
        FormMode mode = FormMode.None;
        public Control()
        {
            InitializeComponent();
            SetInitialState();
        }
        void GetCategories()
        {
            var json = string.Empty;
            var categoryList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoryList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }
            cmbCategory.DataSource = null;
            cmbCategory.DataSource = categoryList.FindAll(x => x.IsEnabled == true);
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
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
            var expenseList = ReadJson();
            return expenseList.Count() + 1;
        }
        void ClearFields()
        {
            txtAmount.Clear();
            lbID.Text = "-";
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            if (cmbConcept.Items.Count > 0) cmbConcept.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }
        void SetInitialState()
        {
            ClearFields();
            GetConcepts();
            GetCategories();
            gbData.Enabled = false;
            UnableButtons();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            GetExpenses();
            id = 0;
            mode = FormMode.None;
        }
        void GetExpenses()
        {
            var expenseList = ReadJson();
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = expenseList;
        }
        bool FieldsFilled()
        {
            return (!String.IsNullOrWhiteSpace(txtAmount.Text) && cmbConcept.Items.Count > 0 && cmbCategory.Items.Count > 0);
        }
        List<Expense> ReadJson()
        {
            var expenseList = new List<Expense>();
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\expenses.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                expenseList = JsonConvert.DeserializeObject<List<Expense>>(json);
            }
            return expenseList;
        }
        void WriteJson(List<Expense> expenseList)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\expenses.json";
            json = JsonConvert.SerializeObject(expenseList);
            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
        }
        void GetConcepts()
        {
            var json = string.Empty;
            var conceptList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }
            cmbConcept.DataSource = null;
            cmbConcept.DataSource = conceptList.FindAll(x => x.IsEnabled == true);
            cmbConcept.DisplayMember = "Name";
            cmbConcept.ValueMember = "Id";
        }
        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            var obj = new CategoryManagement();
            obj.ShowDialog();
        }

        private void btnConceptManagement_Click(object sender, EventArgs e)
        {
            var obj = new ConceptManagement();
            obj.ShowDialog();
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
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            if (dgvExpenses.Rows.Count > 0)
            {
                mode = FormMode.Updating;
                MessageBox.Show("Select a record to modify from the table", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("There are no records to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.Rows.Count > 0)
            {
                mode = FormMode.Deleting;
                MessageBox.Show("Select a record to delecte from the table", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("There are no records to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = FormMode.None;
            SetInitialState();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            var expenseList = ReadJson();
            var expense = new Expense();
            switch (mode)
            {
                case FormMode.Adding:
                    {
                        if (FieldsFilled())
                        {
                            expense = new Expense
                            {
                                Id = int.Parse(lbID.Text),
                                Amount = double.Parse(txtAmount.Text),
                                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                                ConceptID = Convert.ToInt32(cmbConcept.SelectedValue),
                                CreatedDate = dtpDate.Value
                            };
                            expenseList.Add(expense);
                            WriteJson(expenseList);
                            MessageBox.Show("Expense added", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (id != 0)
                        {
                            expenseList.Remove(expenseList.FirstOrDefault(x => x.Id == id));
                            WriteJson(expenseList);
                            MessageBox.Show("Expense deleted", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();
                        }
                        else
                        {
                            MessageBox.Show("You must select an expense first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                case FormMode.Updating:
                    {
                        if (id != 0)
                        {
                            expense = new Expense
                            {
                                Id = int.Parse(lbID.Text),
                                Amount = double.Parse(txtAmount.Text),
                                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                                ConceptID = Convert.ToInt32(cmbConcept.SelectedValue),
                                CreatedDate = dtpDate.Value,
                                ModifiedDate = DateTime.Now
                            };
                            expenseList.Remove(expenseList.FirstOrDefault(x => x.Id == id));
                            expenseList.Add(expense);
                            WriteJson(expenseList);
                            MessageBox.Show("Expense modified", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();
                        }
                        else
                        {
                            MessageBox.Show("You must select an expense first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Opción Inválida");
                        break;
                    }
            }
        }
        private void cmbConcept_Click(object sender, EventArgs e)
        {
            GetConcepts();
        }
        
        private void cmbCategory_Click(object sender, EventArgs e)
        {
            GetCategories();
        }
        private void dgvExpenses_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (mode == FormMode.Updating || mode == FormMode.Deleting)
            {
                if (MessageBox.Show("Do you wish to select the current expense?",
                    "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = int.Parse(dgvExpenses.CurrentRow.Cells[0].Value.ToString());
                    
                    var expense = ReadJson().FirstOrDefault(x => x.Id == id);
                    txtAmount.Text = expense.Amount.ToString();
                    cmbConcept.SelectedValue = expense.ConceptID;
                    cmbCategory.SelectedValue = expense.CategoryID;
                    lbID.Text = expense.Id.ToString();
                    if(mode == FormMode.Updating) gbData.Enabled = true;
                    UnableButtons();
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    MessageBox.Show("Press the Save button to complete the changes", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
