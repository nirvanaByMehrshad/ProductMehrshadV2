
namespace ProductMehrshadV2.Forms
{
    partial class EditCategoryFm
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
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategroyCodeBox = new System.Windows.Forms.TextBox();
            this.CreateCategoryBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "نام طبقه";
            // 
            // CategoryTitleBox
            // 
            this.CategoryTitleBox.Location = new System.Drawing.Point(154, 142);
            this.CategoryTitleBox.Name = "CategoryTitleBox";
            this.CategoryTitleBox.Size = new System.Drawing.Size(234, 20);
            this.CategoryTitleBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "کد طبقه";
            // 
            // CategroyCodeBox
            // 
            this.CategroyCodeBox.Location = new System.Drawing.Point(262, 99);
            this.CategroyCodeBox.Name = "CategroyCodeBox";
            this.CategroyCodeBox.Size = new System.Drawing.Size(126, 20);
            this.CategroyCodeBox.TabIndex = 8;
            // 
            // CreateCategoryBtn
            // 
            this.CreateCategoryBtn.Location = new System.Drawing.Point(362, 181);
            this.CreateCategoryBtn.Name = "CreateCategoryBtn";
            this.CreateCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateCategoryBtn.TabIndex = 7;
            this.CreateCategoryBtn.Text = "ویرایش طبقه";
            this.CreateCategoryBtn.UseVisualStyleBackColor = true;
            this.CreateCategoryBtn.Click += new System.EventHandler(this.CreateCategoryBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(154, 181);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EditCategoryFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryTitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategroyCodeBox);
            this.Controls.Add(this.CreateCategoryBtn);
            this.Controls.Add(this.Exit);
            this.Name = "EditCategoryFm";
            this.Text = "ویرایش طبقه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryTitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategroyCodeBox;
        private System.Windows.Forms.Button CreateCategoryBtn;
        private System.Windows.Forms.Button Exit;
    }
}