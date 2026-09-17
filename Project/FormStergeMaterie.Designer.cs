namespace Project
{
    partial class FormStergeMaterie
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
            this.cmbStergeMaterie = new System.Windows.Forms.ComboBox();
            this.btnStergeMaterie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStergeMaterie
            // 
            this.cmbStergeMaterie.FormattingEnabled = true;
            this.cmbStergeMaterie.Location = new System.Drawing.Point(13, 13);
            this.cmbStergeMaterie.Name = "cmbStergeMaterie";
            this.cmbStergeMaterie.Size = new System.Drawing.Size(121, 21);
            this.cmbStergeMaterie.TabIndex = 0;
            // 
            // btnStergeMaterie
            // 
            this.btnStergeMaterie.Location = new System.Drawing.Point(13, 51);
            this.btnStergeMaterie.Name = "btnStergeMaterie";
            this.btnStergeMaterie.Size = new System.Drawing.Size(75, 23);
            this.btnStergeMaterie.TabIndex = 1;
            this.btnStergeMaterie.Text = "Sterge";
            this.btnStergeMaterie.UseVisualStyleBackColor = true;
            // 
            // FormStergeMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 135);
            this.Controls.Add(this.btnStergeMaterie);
            this.Controls.Add(this.cmbStergeMaterie);
            this.Name = "FormStergeMaterie";
            this.Text = "FormStergeMaterie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStergeMaterie;
        private System.Windows.Forms.Button btnStergeMaterie;
    }
}