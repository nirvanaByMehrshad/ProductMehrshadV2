
namespace ProductMehrshadV2.Forms
{
    partial class CategoryListFm
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
            this.components = new System.ComponentModel.Container();
            this.CreateCategoryBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.intern2DataSetV = new ProductMehrshadV2.intern2DataSetV();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new ProductMehrshadV2.intern2DataSetVTableAdapters.CategoryTableAdapter();
            this.DeleteCategoryBtn = new System.Windows.Forms.Button();
            this.EditCategoryBtn = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSetV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCategoryBtn
            // 
            this.CreateCategoryBtn.Location = new System.Drawing.Point(334, 193);
            this.CreateCategoryBtn.Name = "CreateCategoryBtn";
            this.CreateCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateCategoryBtn.TabIndex = 3;
            this.CreateCategoryBtn.Text = "ایجاد طبقه";
            this.CreateCategoryBtn.UseVisualStyleBackColor = true;
            this.CreateCategoryBtn.Click += new System.EventHandler(this.CreateCategoryBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(253, 222);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(166, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // intern2DataSetV
            // 
            this.intern2DataSetV.DataSetName = "intern2DataSetV";
            this.intern2DataSetV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.intern2DataSetV;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteCategoryBtn
            // 
            this.DeleteCategoryBtn.Location = new System.Drawing.Point(166, 193);
            this.DeleteCategoryBtn.Name = "DeleteCategoryBtn";
            this.DeleteCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteCategoryBtn.TabIndex = 5;
            this.DeleteCategoryBtn.Text = "حذف طبقه";
            this.DeleteCategoryBtn.UseVisualStyleBackColor = true;
            this.DeleteCategoryBtn.Click += new System.EventHandler(this.DeleteCategoryBtn_Click);
            // 
            // EditCategoryBtn
            // 
            this.EditCategoryBtn.Location = new System.Drawing.Point(253, 193);
            this.EditCategoryBtn.Name = "EditCategoryBtn";
            this.EditCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.EditCategoryBtn.TabIndex = 6;
            this.EditCategoryBtn.Text = "ادیت طبقه";
            this.EditCategoryBtn.UseVisualStyleBackColor = true;
            this.EditCategoryBtn.Click += new System.EventHandler(this.EditCategoryBtn_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "نام طبقه";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد طبقه";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CategoryListFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 301);
            this.Controls.Add(this.EditCategoryBtn);
            this.Controls.Add(this.DeleteCategoryBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateCategoryBtn);
            this.Controls.Add(this.Exit);
            this.Name = "CategoryListFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryListFm";
            this.Load += new System.EventHandler(this.CategoryListFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSetV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateCategoryBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private intern2DataSetV intern2DataSetV;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private intern2DataSetVTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button DeleteCategoryBtn;
        private System.Windows.Forms.Button EditCategoryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
    }
}