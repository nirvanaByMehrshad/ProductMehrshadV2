using ServiceLeyer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMehrshadV2.Forms
{
    public partial class EditCategoryFm : Form
    {
        private readonly int _categoryID;
        private readonly ICategoryRepository _repository;
        public EditCategoryFm(ICategoryRepository repository , int categoryId )
        {
            InitializeComponent();
            _categoryID = categoryId;
            _repository = repository;
        }

        private void FillData()
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCategoryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
