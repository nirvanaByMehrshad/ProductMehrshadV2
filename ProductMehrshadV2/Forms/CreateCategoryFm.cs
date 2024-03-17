using DataLeyer.ViewModels;
using ServiceLeyer.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductMehrshadV2.Forms
{
    public partial class CreateCategoryFm : Form
    {
        private readonly ICategoryRepository _categoryRepo;
        public CreateCategoryFm( ICategoryRepository categoryRepository )
        {
            InitializeComponent();
            _categoryRepo = categoryRepository;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CreateCategoryBtn_Click(object sender, EventArgs e)
        {
            if(!IsAllDigits(CategroyCodeBox.Text.Replace(" ", "")) &&
                !CategoryLength(CategroyCodeBox.Text.Replace(" " ,"")))
            {
                var message = "کد باید عدد باشد و کمتر از 2 طول داشته باشد";
                MessageBox.Show(message);

                ClearTextBox();
            }
            else if (!TitleLength(CategoryTitleBox.Text))
            {
                var message = "طول نام باید بین 2 و 20 باشد";
                MessageBox.Show(message);

                ClearTextBox();
            }
            else if(_categoryRepo.IsCategoryCodeExist(Convert.ToInt32(CategroyCodeBox.Text.Replace(" ", ""))))
            {
                var message = "این کد برای طبقه موجود است ";
                MessageBox.Show(message);

                ClearTextBox();
            }
            else
            {
                var createCatgoryVm = new CreateCategoryVm()
                {
                    Code = Convert.ToInt32(CategroyCodeBox.Text.Replace(" ", "")),
                    Title = CategoryTitleBox.Text.ToLower()
                };

                // time to send
                _categoryRepo.CreateCategory(createCatgoryVm);

                ClearTextBox();
            }

        }


        // validation & clear 
        private void ClearTextBox()
        {
            CategoryTitleBox.Text = string.Empty;
            CategroyCodeBox.Text = string.Empty;
        }
        private bool CategoryLength(string code)
        {
            if(code.Length>0 && code.Length < 3)
            {
                return true;
            }

            return false; 
        }
        bool IsAllDigits(string s) => s.All(char.IsDigit);
        private bool TitleLength( string title)
        {
            if (CategoryTitleBox.Text.Length < 20 &&
                CategoryTitleBox.Text.Length > 1)
                return true;

            return false;
        }
    }
}
