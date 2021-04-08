namespace StoreList
{
    partial class ItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBoxName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CheckBoxName
            // 
            this.CheckBoxName.AutoSize = true;
            this.CheckBoxName.Location = new System.Drawing.Point(12, 22);
            this.CheckBoxName.Name = "CheckBoxName";
            this.CheckBoxName.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxName.TabIndex = 0;
            this.CheckBoxName.Text = "checkBox1";
            this.CheckBoxName.UseVisualStyleBackColor = true;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckBoxName);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(628, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxName;
    }
}
