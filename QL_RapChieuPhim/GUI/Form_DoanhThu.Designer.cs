namespace GUI
{
    partial class Form_DoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nbd = new System.Windows.Forms.DateTimePicker();
            this.txt_nkt = new System.Windows.Forms.DateTimePicker();
            this.dtg_dt = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label_tt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Doanh Thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(956, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // txt_nbd
            // 
            this.txt_nbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nbd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_nbd.Location = new System.Drawing.Point(397, 152);
            this.txt_nbd.Name = "txt_nbd";
            this.txt_nbd.Size = new System.Drawing.Size(283, 35);
            this.txt_nbd.TabIndex = 3;
            this.txt_nbd.ValueChanged += new System.EventHandler(this.txt_nbd_ValueChanged);
            // 
            // txt_nkt
            // 
            this.txt_nkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nkt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_nkt.Location = new System.Drawing.Point(1119, 152);
            this.txt_nkt.Name = "txt_nkt";
            this.txt_nkt.Size = new System.Drawing.Size(283, 35);
            this.txt_nkt.TabIndex = 4;
            // 
            // dtg_dt
            // 
            this.dtg_dt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dt.Location = new System.Drawing.Point(163, 227);
            this.dtg_dt.Name = "dtg_dt";
            this.dtg_dt.RowTemplate.Height = 28;
            this.dtg_dt.Size = new System.Drawing.Size(1489, 358);
            this.dtg_dt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label_tt
            // 
            this.label_tt.AutoSize = true;
            this.label_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tt.ForeColor = System.Drawing.Color.Red;
            this.label_tt.Location = new System.Drawing.Point(295, 633);
            this.label_tt.Name = "label_tt";
            this.label_tt.Size = new System.Drawing.Size(31, 29);
            this.label_tt.TabIndex = 7;
            this.label_tt.Text = "...";
            // 
            // Form_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1757, 729);
            this.Controls.Add(this.label_tt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtg_dt);
            this.Controls.Add(this.txt_nkt);
            this.Controls.Add(this.txt_nbd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_DoanhThu";
            this.Text = "Form_DoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_nbd;
        private System.Windows.Forms.DateTimePicker txt_nkt;
        private System.Windows.Forms.DataGridView dtg_dt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_tt;
    }
}