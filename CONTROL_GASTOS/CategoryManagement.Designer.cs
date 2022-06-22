namespace CONTROL_GASTOS
{
    partial class CategoryManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chbIsVisible = new System.Windows.Forms.CheckBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(194, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categories Management";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtDescription);
            this.gbData.Controls.Add(this.txtName);
            this.gbData.Controls.Add(this.chbIsVisible);
            this.gbData.Controls.Add(this.lbID);
            this.gbData.Controls.Add(this.label6);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gbData.Location = new System.Drawing.Point(9, 53);
            this.gbData.Margin = new System.Windows.Forms.Padding(2);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(2);
            this.gbData.Size = new System.Drawing.Size(347, 178);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Enter the category\'s information";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 103);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 58);
            this.txtDescription.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 64);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 30);
            this.txtName.TabIndex = 16;
            // 
            // chbIsVisible
            // 
            this.chbIsVisible.AutoSize = true;
            this.chbIsVisible.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.chbIsVisible.Location = new System.Drawing.Point(23, 28);
            this.chbIsVisible.Margin = new System.Windows.Forms.Padding(2);
            this.chbIsVisible.Name = "chbIsVisible";
            this.chbIsVisible.Size = new System.Drawing.Size(123, 28);
            this.chbIsVisible.TabIndex = 15;
            this.chbIsVisible.Text = "Is it visible?";
            this.chbIsVisible.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(198, 28);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(15, 24);
            this.lbID.TabIndex = 13;
            this.lbID.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(174, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(378, 58);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(264, 168);
            this.dgvCategory.TabIndex = 11;
            this.dgvCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategory_RowHeaderMouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(545, 249);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 36);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(285, 249);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 36);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(155, 249);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 36);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(415, 249);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(25, 249);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 36);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 297);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.dgvCategory);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories Management";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbIsVisible;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
    }
}