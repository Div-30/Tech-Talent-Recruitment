namespace Thursday_Gen_Quiz
{
    partial class ApplicationStatus
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
            this.statusBtn = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBtn
            // 
            this.statusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBtn.Location = new System.Drawing.Point(335, 177);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(123, 33);
            this.statusBtn.TabIndex = 35;
            this.statusBtn.Text = "Check Status";
            this.statusBtn.UseVisualStyleBackColor = false;
            this.statusBtn.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(274, 131);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(256, 29);
            this.emailBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = " My Application Status ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 179);
            this.dataGridView1.TabIndex = 36;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.IndianRed;
            this.withdrawBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(151, 436);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(187, 35);
            this.withdrawBtn.TabIndex = 37;
            this.withdrawBtn.Text = "Withdraw Application";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Salmon;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(521, 436);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(128, 33);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 469);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(81, 32);
            this.backBtn.TabIndex = 74;
            this.backBtn.Text = "<- Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ApplicationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationStatus";
            this.Text = "ApplicationStatus";
            this.Load += new System.EventHandler(this.ApplicationStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
    }
}