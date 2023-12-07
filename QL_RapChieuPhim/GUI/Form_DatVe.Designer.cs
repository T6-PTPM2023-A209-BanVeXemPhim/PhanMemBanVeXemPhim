namespace GUI
{
    partial class Form_DatVe
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
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Location = new System.Drawing.Point(12, 12);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.Size = new System.Drawing.Size(391, 278);
            this.dgvVe.TabIndex = 149;
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Location = new System.Drawing.Point(409, 12);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.Size = new System.Drawing.Size(587, 278);
            this.dgvLichChieu.TabIndex = 150;
            // 
            // Form_DatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 585);
            this.Controls.Add(this.dgvLichChieu);
            this.Controls.Add(this.dgvVe);
            this.Name = "Form_DatVe";
            this.Text = "Form_DatVe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.DataGridView dgvLichChieu;
    }
}