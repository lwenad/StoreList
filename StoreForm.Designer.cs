namespace StoreList
{
    partial class StoreForm
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
            this.GroupBoxVegetables = new System.Windows.Forms.GroupBox();
            this.DataGridViewVegetable = new System.Windows.Forms.DataGridView();
            this.GroupBoxResult = new System.Windows.Forms.GroupBox();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.ButtonGenerateList = new System.Windows.Forms.Button();
            this.GroupBoxVegetables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVegetable)).BeginInit();
            this.GroupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxVegetables
            // 
            this.GroupBoxVegetables.Controls.Add(this.DataGridViewVegetable);
            this.GroupBoxVegetables.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxVegetables.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxVegetables.Name = "GroupBoxVegetables";
            this.GroupBoxVegetables.Size = new System.Drawing.Size(582, 567);
            this.GroupBoxVegetables.TabIndex = 0;
            this.GroupBoxVegetables.TabStop = false;
            this.GroupBoxVegetables.Text = "Groceries";
            // 
            // DataGridViewVegetable
            // 
            this.DataGridViewVegetable.AllowUserToAddRows = false;
            this.DataGridViewVegetable.AllowUserToDeleteRows = false;
            this.DataGridViewVegetable.AllowUserToOrderColumns = true;
            this.DataGridViewVegetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVegetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewVegetable.Location = new System.Drawing.Point(3, 16);
            this.DataGridViewVegetable.Name = "DataGridViewVegetable";
            this.DataGridViewVegetable.Size = new System.Drawing.Size(576, 548);
            this.DataGridViewVegetable.TabIndex = 0;
            // 
            // GroupBoxResult
            // 
            this.GroupBoxResult.Controls.Add(this.ItemTextBox);
            this.GroupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxResult.Location = new System.Drawing.Point(0, 590);
            this.GroupBoxResult.Name = "GroupBoxResult";
            this.GroupBoxResult.Size = new System.Drawing.Size(582, 55);
            this.GroupBoxResult.TabIndex = 1;
            this.GroupBoxResult.TabStop = false;
            this.GroupBoxResult.Text = "List";
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTextBox.Location = new System.Drawing.Point(3, 16);
            this.ItemTextBox.Multiline = true;
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(576, 36);
            this.ItemTextBox.TabIndex = 0;
            // 
            // ButtonGenerateList
            // 
            this.ButtonGenerateList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonGenerateList.ForeColor = System.Drawing.Color.Red;
            this.ButtonGenerateList.Location = new System.Drawing.Point(0, 567);
            this.ButtonGenerateList.Name = "ButtonGenerateList";
            this.ButtonGenerateList.Size = new System.Drawing.Size(582, 23);
            this.ButtonGenerateList.TabIndex = 2;
            this.ButtonGenerateList.Text = "Click to generate List";
            this.ButtonGenerateList.UseVisualStyleBackColor = true;
            this.ButtonGenerateList.Click += new System.EventHandler(this.ButtonGenerateList_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 645);
            this.Controls.Add(this.GroupBoxResult);
            this.Controls.Add(this.ButtonGenerateList);
            this.Controls.Add(this.GroupBoxVegetables);
            this.Name = "StoreForm";
            this.Text = "Grocery List Gen v1.0";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.GroupBoxVegetables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVegetable)).EndInit();
            this.GroupBoxResult.ResumeLayout(false);
            this.GroupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxVegetables;
        private System.Windows.Forms.DataGridView DataGridViewVegetable;
        private System.Windows.Forms.GroupBox GroupBoxResult;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Button ButtonGenerateList;
    }
}

