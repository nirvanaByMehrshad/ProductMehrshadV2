namespace ProductMehrshadV2.Forms
{
    partial class HomeFm
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
            this.CreateCategoryBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.CreateProductBtn = new System.Windows.Forms.Button();
            this.CategoryListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateCategoryBtn
            // 
            this.CreateCategoryBtn.Location = new System.Drawing.Point(183, 141);
            this.CreateCategoryBtn.Name = "CreateCategoryBtn";
            this.CreateCategoryBtn.Size = new System.Drawing.Size(96, 23);
            this.CreateCategoryBtn.TabIndex = 3;
            this.CreateCategoryBtn.Text = "ایجاد طبقه";
            this.CreateCategoryBtn.UseVisualStyleBackColor = true;
            this.CreateCategoryBtn.Click += new System.EventHandler(this.CreateCategoryBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(183, 170);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CreateProductBtn
            // 
            this.CreateProductBtn.Location = new System.Drawing.Point(183, 112);
            this.CreateProductBtn.Name = "CreateProductBtn";
            this.CreateProductBtn.Size = new System.Drawing.Size(96, 23);
            this.CreateProductBtn.TabIndex = 4;
            this.CreateProductBtn.Text = "ایجاد کالا ";
            this.CreateProductBtn.UseVisualStyleBackColor = true;
            this.CreateProductBtn.Click += new System.EventHandler(this.CreateProductBtn_Click);
            // 
            // CategoryListBtn
            // 
            this.CategoryListBtn.Location = new System.Drawing.Point(183, 83);
            this.CategoryListBtn.Name = "CategoryListBtn";
            this.CategoryListBtn.Size = new System.Drawing.Size(96, 23);
            this.CategoryListBtn.TabIndex = 5;
            this.CategoryListBtn.Text = "لیست طبقه ها ";
            this.CategoryListBtn.UseVisualStyleBackColor = true;
            this.CategoryListBtn.Click += new System.EventHandler(this.CategoryListBtn_Click);
            // 
            // HomeFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 261);
            this.Controls.Add(this.CategoryListBtn);
            this.Controls.Add(this.CreateProductBtn);
            this.Controls.Add(this.CreateCategoryBtn);
            this.Controls.Add(this.Exit);
            this.Name = "HomeFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeFm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCategoryBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button CreateProductBtn;
        private System.Windows.Forms.Button CategoryListBtn;
    }
}