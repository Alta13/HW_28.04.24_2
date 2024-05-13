namespace HW_28._04._24_2
{
    partial class Form1
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
            this.tbxReadFile = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxReadFile
            // 
            this.tbxReadFile.Location = new System.Drawing.Point(1, 1);
            this.tbxReadFile.Multiline = true;
            this.tbxReadFile.Name = "tbxReadFile";
            this.tbxReadFile.Size = new System.Drawing.Size(798, 311);
            this.tbxReadFile.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 334);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(356, 69);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Загрузить файл";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(403, 334);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(346, 69);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать файл";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbxReadFile);
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReadFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnEdit;
    }
}