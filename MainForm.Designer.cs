namespace SQLi
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lbl_welcome = new System.Windows.Forms.Label();
            this.Lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(382, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // Lbl_welcome
            // 
            this.Lbl_welcome.AutoSize = true;
            this.Lbl_welcome.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_welcome.ForeColor = System.Drawing.Color.MistyRose;
            this.Lbl_welcome.Location = new System.Drawing.Point(71, 33);
            this.Lbl_welcome.Name = "Lbl_welcome";
            this.Lbl_welcome.Size = new System.Drawing.Size(390, 46);
            this.Lbl_welcome.TabIndex = 1;
            this.Lbl_welcome.Text = "Login Sucessfully";
            // 
            // Lbl_result
            // 
            this.Lbl_result.AutoSize = true;
            this.Lbl_result.Font = new System.Drawing.Font("Maiandra GD", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_result.ForeColor = System.Drawing.Color.MistyRose;
            this.Lbl_result.Location = new System.Drawing.Point(72, 156);
            this.Lbl_result.Name = "Lbl_result";
            this.Lbl_result.Size = new System.Drawing.Size(226, 40);
            this.Lbl_result.TabIndex = 2;
            this.Lbl_result.Text = "Querry Result:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(552, 471);
            this.Controls.Add(this.Lbl_result);
            this.Controls.Add(this.Lbl_welcome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "22110058 Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_welcome;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_result;
    }
}