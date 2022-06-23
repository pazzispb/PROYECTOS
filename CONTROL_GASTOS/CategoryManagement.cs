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
    public partial class CategoryManagement : Form
    {
        FormMode mode = FormMode.None;
        int id = 0;// Category's Id to be deleted or modified
        public CategoryManagement()
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
            var categoryList = ReadJson();
            return categoryList.Count() + 1;
        }
        List<Category> ReadJson()
        {
            var json = string.Empty;
            var categoryList = new List<Category>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                categoryList = JsonConvert.DeserializeObject<List<Category>>(json);
            }
            return categoryList;
        }
        void WriteJson(List<Category> categoryList)
        {
            var json = string.Empty;
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            json = JsonConvert.SerializeObject(categoryList);
            var sw = new StreamWriter(pathFile, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
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
            GetCategories();
        }

        void GetCategories()
        {
            var categoryList = ReadJson();
            dgvCategory.DataSource = null;
            dgvCategory.DataSource = categoryList;
        }
        bool FieldsFilled()
        {
            return (!String.IsNullOrWhiteSpace(txtName.Text) || !String.IsNullOrWhiteSpace(txtDescription.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var categoryList = ReadJson();
            var category = new Category();
            switch (mode)
            {
                case FormMode.Adding:
                    {
                        if (FieldsFilled())
                        {
                            var categoryCount = categoryList.Count(x => x.Name.ToString().Trim().ToLower() == txtName.Text.Trim().ToLower());
                            if (categoryCount > 0)
                            {
                                MessageBox.Show("The category already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            }
                            category = new Category
                            {
                                Id = int.Parse(lbID.Text),
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                IsEnabled = chbIsVisible.Checked,
                                CreatedDate = DateTime.Now
                            };
                            categoryList.Add(category);
                            WriteJson(categoryList);
                            MessageBox.Show("Category added", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            categoryList.Remove(categoryList.FirstOrDefault(x => x.Id == id));
                            WriteJson(categoryList);
                            MessageBox.Show("Category deleted", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();
                        }
                        else
                        {
                            MessageBox.Show("You must select a category first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        break;
                    }
                case FormMode.Updating:
                    {
                        if (id != 0)
                        {
                            var categoryCount = categoryList.Count(x => (x.Name.ToString().Trim().ToLower() == txtName.Text.Trim().ToLower()) && (x.Id != int.Parse(lbID.Text)));
                            if (categoryCount > 0)
                            {
                                MessageBox.Show("The category already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            }
                            category = new Category
                            {
                                Id = int.Parse(lbID.Text),
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = categoryList.FirstOrDefault(x => x.Id == id).CreatedDate,
                                IsEnabled = chbIsVisible.Checked,
                                ModifiedDate = DateTime.Now
                            };
                            categoryList.Remove(categoryList.FirstOrDefault(x => x.Id == id));
                            categoryList.Add(category);
                            WriteJson(categoryList);
                            MessageBox.Show("Category modified", "NOTIFICATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetInitialState();
                        }
                        else
                        {
                            MessageBox.Show("You must select a category first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            if (dgvCategory.Rows.Count > 0)
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
            if (dgvCategory.Rows.Count > 0)
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

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (mode == FormMode.Updating || mode == FormMode.Deleting)
            {
                if (MessageBox.Show("Do you wish to select the current category?",
                    "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = int.Parse(dgvCategory.CurrentRow.Cells[0].Value.ToString());
                    var category = ReadJson().FirstOrDefault(x => x.Id == id);
                    txtDescription.Text = category.Description;
                    txtName.Text = category.Name;
                    lbID.Text = category.Id.ToString();
                    chbIsVisible.Checked = category.IsEnabled;
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
