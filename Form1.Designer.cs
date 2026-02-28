namespace Thursday_Gen_Quiz
{
    partial class MainDashboard
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
            this.StatusBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.applicationBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hrBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusBtn
            // 
            this.StatusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBtn.Location = new System.Drawing.Point(555, 163);
            this.StatusBtn.Name = "StatusBtn";
            this.StatusBtn.Size = new System.Drawing.Size(135, 31);
            this.StatusBtn.TabIndex = 18;
            this.StatusBtn.Text = "Application Status";
            this.StatusBtn.UseVisualStyleBackColor = false;
            this.StatusBtn.Click += new System.EventHandler(this.StatusBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Check My Application Status";
            // 
            // applicationBtn
            // 
            this.applicationBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.applicationBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationBtn.Location = new System.Drawing.Point(174, 159);
            this.applicationBtn.Name = "applicationBtn";
            this.applicationBtn.Size = new System.Drawing.Size(139, 39);
            this.applicationBtn.TabIndex = 16;
            this.applicationBtn.Text = "Application Form";
            this.applicationBtn.UseVisualStyleBackColor = false;
            this.applicationBtn.Click += new System.EventHandler(this.applicationBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apply for a Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Job Application Management System";
            // 
            // hrBtn
            // 
            this.hrBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hrBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrBtn.Location = new System.Drawing.Point(312, 287);
            this.hrBtn.Name = "hrBtn";
            this.hrBtn.Size = new System.Drawing.Size(126, 31);
            this.hrBtn.TabIndex = 20;
            this.hrBtn.Text = "HR Management";
            this.hrBtn.UseVisualStyleBackColor = false;
            this.hrBtn.Click += new System.EventHandler(this.hrBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "HR Management";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hrBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.applicationBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StatusBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applicationBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hrBtn;
        private System.Windows.Forms.Label label3;
    }
}

