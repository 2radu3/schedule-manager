namespace Project
{
    partial class FormAfisareOrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgOrarPopup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrarPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgOrarPopup
            // 
            this.dvgOrarPopup.AllowUserToAddRows = false;
            this.dvgOrarPopup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgOrarPopup.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dvgOrarPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgOrarPopup.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvgOrarPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgOrarPopup.Location = new System.Drawing.Point(0, 0);
            this.dvgOrarPopup.Name = "dvgOrarPopup";
            this.dvgOrarPopup.RowHeadersVisible = false;
            this.dvgOrarPopup.Size = new System.Drawing.Size(800, 450);
            this.dvgOrarPopup.TabIndex = 0;
            // 
            // FormAfisareOrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgOrarPopup);
            this.Name = "FormAfisareOrar";
            this.Text = "FormAfisareOrar";
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrarPopup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgOrarPopup;
    }
}