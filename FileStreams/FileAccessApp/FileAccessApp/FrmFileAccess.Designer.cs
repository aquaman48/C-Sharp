namespace FileAccessApp
{
    partial class FrmFileAccess
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDisplayUsers = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(47, 227);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 3;
            // 
            // btnDisplayUsers
            // 
            this.btnDisplayUsers.Location = new System.Drawing.Point(51, 13);
            this.btnDisplayUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayUsers.Name = "btnDisplayUsers";
            this.btnDisplayUsers.Size = new System.Drawing.Size(188, 32);
            this.btnDisplayUsers.TabIndex = 4;
            this.btnDisplayUsers.Text = "Display Users";
            this.btnDisplayUsers.UseVisualStyleBackColor = true;
            this.btnDisplayUsers.Click += new System.EventHandler(this.btnDisplayUsers_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(36, 75);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results.Size = new System.Drawing.Size(221, 125);
            this.results.TabIndex = 5;
            this.results.Visible = false;
            // 
            // FrmFileAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(312, 285);
            this.Controls.Add(this.results);
            this.Controls.Add(this.btnDisplayUsers);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFileAccess";
            this.Text = "File Access App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFileAccess_FormClosing);
            this.Load += new System.EventHandler(this.FrmFileAccess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDisplayUsers;
        private System.Windows.Forms.TextBox results;
    }
}

