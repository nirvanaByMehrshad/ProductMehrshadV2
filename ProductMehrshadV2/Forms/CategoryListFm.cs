using DataLeyer.MyDbContext;
using ServiceLeyer.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductMehrshadV2.Forms
{
    public partial class CategoryListFm : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryListFm( ICategoryRepository categoryRepository )
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            dataGridView1.DataSource = _categoryRepository.GetDataTest();
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellDoubleClick += DataGrid_selectedRows;
            dataGridView1.KeyDown += DataGeid_KeyDown ;
        }

        private void DataGeid_KeyDown(object sender , KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(dataGridView1.Rows.Count > 0)
                {
                    var myObject = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as Category ;
                    _categoryRepository.DeleteCategory(myObject.CategoryID);
                }
            }
        }
        // selected and active row
        private void DataGrid_selectedRows( object sender , EventArgs e)
        {
            int rowOfIndex = dataGridView1.CurrentCell.RowIndex;
        }
        // edit with double click
        private void dataGridView1_CellDoubleClick( object sender , DataGridViewCellEventArgs e)
        {
            // edit with double click 
            if(e.RowIndex >= 0)
            {
                var myObject = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as Category;
                var dataId = myObject.CategoryID;

                // edit here
            }
        }
        private int GetIdSelecetd()
        {
            var myObject = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem as Category;
            return myObject.CategoryID;
        }
        private bool IsCategoryHasRelation( int categoryId)
        {
            return _categoryRepository.IsCategoryHasrepation(categoryId);
        }
        private void CreateCategoryBtn_Click(object sender, EventArgs e)
        {
            var createCategory = new CreateCategoryFm(_categoryRepository);
            createCategory.ShowDialog();

            RefreshForm();
        }
        private void RefreshForm()
        {
            this.categoryTableAdapter.Fill(this.intern2DataSetV.Category);
        }
        private void CategoryListFm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intern2DataSetV.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.intern2DataSetV.Category);

        }
        private void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {
            if (!_categoryRepository.IsCategoryCodeExist(GetIdSelecetd()))
            {
                var message = "این داده و ایدی موجد نیست است";
                MessageBox.Show(message);
            }
            else
            {
                // time to delete
                var categoryID = GetIdSelecetd();
                if (IsCategoryHasRelation(categoryID))
                {
                    var message = "داده کلید خارجی است";
                    MessageBox.Show(message);
                }
                else
                {
                    _categoryRepository.DeleteCategory(categoryID);

                    var isDeleted = _categoryRepository.IsCategoryCodeExist(categoryID);
                    if(isDeleted == true)
                    {
                        var message = "مشکلی وجود دارد، دوباره تلاش کنید";
                        MessageBox.Show(message);

                        RefreshForm();
                    }
                    else
                    {
                        var message = "داده حذف شد";
                        MessageBox.Show(message);

                        RefreshForm();
                    }
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
