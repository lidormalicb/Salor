namespace Salor_fixer
{
    partial class seller
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
            this.num = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר מוכר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם מוכר";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(58, 24);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(57, 22);
            this.num.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(57, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 22);
            this.name.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(223, 141);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(78, 30);
            this.add.TabIndex = 6;
            this.add.Text = "הוספה";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(57, 141);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(54, 30);
            this.delete.TabIndex = 7;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 196);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.name);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "seller";
            this.Text = "ניהול מוכרים";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
    }
}