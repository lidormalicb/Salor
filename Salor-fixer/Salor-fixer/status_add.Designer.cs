namespace Salor_fixer
{
    partial class status_add
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
            this.status_txt = new System.Windows.Forms.TextBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precent_txt = new System.Windows.Forms.TextBox();
            this.precent_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(65, 54);
            this.status_txt.Name = "status_txt";
            this.status_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status_txt.Size = new System.Drawing.Size(196, 22);
            this.status_txt.TabIndex = 14;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(267, 57);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status_lbl.Size = new System.Drawing.Size(44, 17);
            this.status_lbl.TabIndex = 13;
            this.status_lbl.Text = "סטטוס";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Aquamarine;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(12, 109);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(93, 41);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "עדכן";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "הוספה ועריכה של סטטוס מעבדה";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(5, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(317, 75);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "מספר";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "אחוז";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "מצב";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // precent_txt
            // 
            this.precent_txt.Location = new System.Drawing.Point(191, 81);
            this.precent_txt.Name = "precent_txt";
            this.precent_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.precent_txt.Size = new System.Drawing.Size(70, 22);
            this.precent_txt.TabIndex = 17;
            // 
            // precent_lbl
            // 
            this.precent_lbl.AutoSize = true;
            this.precent_lbl.Location = new System.Drawing.Point(65, 84);
            this.precent_lbl.Name = "precent_lbl";
            this.precent_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.precent_lbl.Size = new System.Drawing.Size(120, 17);
            this.precent_lbl.TabIndex = 16;
            this.precent_lbl.Text = "אחוז מתהליך התיקון";
            // 
            // status_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 253);
            this.Controls.Add(this.precent_txt);
            this.Controls.Add(this.precent_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label1);
            this.Name = "status_add";
            this.Text = "status_add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox precent_txt;
        private System.Windows.Forms.Label precent_lbl;
    }
}