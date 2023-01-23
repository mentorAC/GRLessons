namespace Les24
{
    partial class ManagerDir
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
            this.tbCreate = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCreate
            // 
            this.tbCreate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCreate.Location = new System.Drawing.Point(12, 68);
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Size = new System.Drawing.Size(211, 50);
            this.tbCreate.TabIndex = 0;
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCreate.Location = new System.Drawing.Point(229, 12);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(131, 106);
            this.bCreate.TabIndex = 1;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(211, 50);
            this.numericUpDown1.TabIndex = 2;
            // 
            // tbDelete
            // 
            this.tbDelete.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDelete.Location = new System.Drawing.Point(453, 12);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(211, 50);
            this.tbDelete.TabIndex = 3;
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDelete.Location = new System.Drawing.Point(453, 68);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(211, 50);
            this.bDelete.TabIndex = 4;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // ManagerDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbCreate);
            this.Name = "ManagerDir";
            this.Text = "ManagerDir";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbCreate;
        private Button bCreate;
        private NumericUpDown numericUpDown1;
        private TextBox tbDelete;
        private Button bDelete;
    }
}