namespace FileAccessApp
{
    partial class NumFileTxt
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
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAverage
            // 
            this.btnAverage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAverage.FlatAppearance.BorderSize = 3;
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Location = new System.Drawing.Point(69, 21);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(259, 40);
            this.btnAverage.TabIndex = 0;
            this.btnAverage.Text = "Display Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSmallest
            // 
            this.btnSmallest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSmallest.FlatAppearance.BorderSize = 3;
            this.btnSmallest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmallest.Location = new System.Drawing.Point(69, 114);
            this.btnSmallest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(259, 40);
            this.btnSmallest.TabIndex = 1;
            this.btnSmallest.Text = "Display Smallest Value";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnLargest
            // 
            this.btnLargest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLargest.FlatAppearance.BorderSize = 3;
            this.btnLargest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLargest.Location = new System.Drawing.Point(69, 206);
            this.btnLargest.Margin = new System.Windows.Forms.Padding(4);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(259, 40);
            this.btnLargest.TabIndex = 2;
            this.btnLargest.Text = "Display Largest Value";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(65, 284);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 3;
            // 
            // NumFileTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(346, 294);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.btnSmallest);
            this.Controls.Add(this.btnAverage);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NumFileTxt";
            this.Text = "Numbers from File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFileAccess_FormClosing);
            this.Load += new System.EventHandler(this.FrmFileAccess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Label lblResult;
    }
}

