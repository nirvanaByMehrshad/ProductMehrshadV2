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
    public partial class HomeFm : Form
    {
        public HomeFm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateCategoryBtn_Click(object sender, EventArgs e)
        {
            var createCatFm = new CreateCategoryFm( new CatgeoryRepository() );
            createCatFm.ShowDialog();
        }
        private void CreateProductBtn_Click(object sender, EventArgs e)
        {
            var createProductFm = new CreateProductFm();
            createProductFm.ShowDialog(); 
        }
        private void CategoryListBtn_Click(object sender, EventArgs e)
        {
            var categoryList = new CategoryListFm(new CatgeoryRepository());
            categoryList.ShowDialog();
        }
    }
}
