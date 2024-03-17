namespace ProductMehrshadV2.Forms
{
    partial class CreateCategoryFm
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
            this.Exit = new System.Windows.Forms.Button();
            this.CreateCategoryBtn = new System.Windows.Forms.Button();
            this.CategroyCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryTitleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(72, 158);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CreateCategoryBtn
            // 
            this.CreateCategoryBtn.Location = new System.Drawing.Point(280, 158);
            this.CreateCategoryBtn.Name = "CreateCategoryBtn";
            this.CreateCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateCategoryBtn.TabIndex = 1;
            this.CreateCategoryBtn.Text = "ایجاد طبقه";
            this.CreateCategoryBtn.UseVisualStyleBackColor = true;
            this.CreateCategoryBtn.Click += new System.EventHandler(this.CreateCategoryBtn_Click);
            // 
            // CategroyCodeBox
            // 
            this.CategroyCodeBox.Location = new System.Drawing.Point(180, 76);
            this.CategroyCodeBox.Name = "CategroyCodeBox";
            this.CategroyCodeBox.Size = new System.Drawing.Size(126, 20);
            this.CategroyCodeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "کد طبقه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام طبقه";
            // 
            // CategoryTitleBox
            // 
            this.CategoryTitleBox.Location = new System.Drawing.Point(72, 119);
            this.CategoryTitleBox.Name = "CategoryTitleBox";
            this.CategoryTitleBox.Size = new System.Drawing.Size(234, 20);
            this.CategoryTitleBox.TabIndex = 4;
            // 
            // CreateCategoryFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryTitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategroyCodeBox);
            this.Controls.Add(this.CreateCategoryBtn);
            this.Controls.Add(this.Exit);
            this.Name = "CreateCategoryFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد طبقه ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button CreateCategoryBtn;
        private System.Windows.Forms.TextBox CategroyCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryTitleBox;
    }
}