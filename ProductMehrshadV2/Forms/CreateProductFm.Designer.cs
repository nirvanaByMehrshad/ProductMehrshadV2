namespace ProductMehrshadV2.Forms
{
    partial class CreateProductFm
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
            this.CategroyCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateProductBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام کالا ";
            // 
            // CategoryTitleBox
            // 
            this.CategoryTitleBox.Location = new System.Drawing.Point(120, 128);
            this.CategoryTitleBox.Name = "CategoryTitleBox";
            this.CategoryTitleBox.Size = new System.Drawing.Size(234, 20);
            this.CategoryTitleBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "کد کالا";
            // 
            // CategroyCodeBox
            // 
            this.CategroyCodeBox.Location = new System.Drawing.Point(228, 102);
            this.CategroyCodeBox.Name = "CategroyCodeBox";
            this.CategroyCodeBox.Size = new System.Drawing.Size(126, 20);
            this.CategroyCodeBox.TabIndex = 6;
            // 
            // CategroyCodeComboBox
            // 
            this.CategroyCodeComboBox.FormattingEnabled = true;
            this.CategroyCodeComboBox.Location = new System.Drawing.Point(162, 75);
            this.CategroyCodeComboBox.Name = "CategroyCodeComboBox";
            this.CategroyCodeComboBox.Size = new System.Drawing.Size(192, 21);
            this.CategroyCodeComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "کد طبقه";
            // 
            // CreateProductBtn
            // 
            this.CreateProductBtn.Location = new System.Drawing.Point(279, 154);
            this.CreateProductBtn.Name = "CreateProductBtn";
            this.CreateProductBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateProductBtn.TabIndex = 13;
            this.CreateProductBtn.Text = "ایجاد کالا ";
            this.CreateProductBtn.UseVisualStyleBackColor = true;
            this.CreateProductBtn.Click += new System.EventHandler(this.CreateProductBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(120, 154);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CreateProductFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.CreateProductBtn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategroyCodeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryTitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategroyCodeBox);
            this.Name = "CreateProductFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد کالا";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryTitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategroyCodeBox;
        private System.Windows.Forms.ComboBox CategroyCodeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateProductBtn;
        private System.Windows.Forms.Button Exit;
    }
}