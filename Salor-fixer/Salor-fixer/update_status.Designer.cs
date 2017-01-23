namespace Salor_fixer
{
    partial class update_status
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_status));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.lachoch = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.ComboBox();
            this.infostatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDBfix_phoneDataSet = new Salor_fixer.allDBfix_phoneDataSet();
            this.info_statusTableAdapter = new Salor_fixer.allDBfix_phoneDataSetTableAdapters.info_statusTableAdapter();
            this.time_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imei = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.infostatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDBfix_phoneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "עדכון סטטוס מכשיר במעבדה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "לקוח";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "מכשיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "סטטוס";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Aquamarine;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(11, 153);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(70, 33);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "עדכן";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // lachoch
            // 
            this.lachoch.FormattingEnabled = true;
            this.lachoch.Location = new System.Drawing.Point(68, 41);
            this.lachoch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lachoch.Name = "lachoch";
            this.lachoch.Size = new System.Drawing.Size(125, 21);
            this.lachoch.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.FormattingEnabled = true;
            this.phone.Location = new System.Drawing.Point(68, 65);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(125, 21);
            this.phone.TabIndex = 6;
            // 
            // info
            // 
            this.info.DataSource = this.infostatusBindingSource;
            this.info.DisplayMember = "info";
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(88, 114);
            this.info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(105, 21);
            this.info.TabIndex = 7;
            this.info.ValueMember = "Id_status";
            // 
            // infostatusBindingSource
            // 
            this.infostatusBindingSource.DataMember = "info_status";
            this.infostatusBindingSource.DataSource = this.allDBfix_phoneDataSet;
            // 
            // allDBfix_phoneDataSet
            // 
            this.allDBfix_phoneDataSet.DataSetName = "allDBfix_phoneDataSet";
            this.allDBfix_phoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // info_statusTableAdapter
            // 
            this.info_statusTableAdapter.ClearBeforeFill = true;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.time_lbl.ForeColor = System.Drawing.Color.Blue;
            this.time_lbl.Location = new System.Drawing.Point(193, 145);
            this.time_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(43, 29);
            this.time_lbl.TabIndex = 8;
            this.time_lbl.Text = "זמן";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "IMEI";
            // 
            // imei
            // 
            this.imei.Location = new System.Drawing.Point(68, 90);
            this.imei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imei.Name = "imei";
            this.imei.Size = new System.Drawing.Size(125, 20);
            this.imei.TabIndex = 10;
            // 
            // update_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 194);
            this.Controls.Add(this.imei);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.info);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lachoch);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "update_status";
            this.Text = "update_status";
            this.Load += new System.EventHandler(this.update_status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infostatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDBfix_phoneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox lachoch;
        private System.Windows.Forms.ComboBox phone;
        private System.Windows.Forms.ComboBox info;
        private allDBfix_phoneDataSet allDBfix_phoneDataSet;
        private System.Windows.Forms.BindingSource infostatusBindingSource;
        private allDBfix_phoneDataSetTableAdapters.info_statusTableAdapter info_statusTableAdapter;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imei;
    }
}