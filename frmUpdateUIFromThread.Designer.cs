namespace frmUpdateUIFromThread
{
    partial class frmUpdateUIFromThread
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
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.btnStartThreads = new System.Windows.Forms.Button();
            this.LbxTxtLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // numThreads
            // 
            this.numThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThreads.Location = new System.Drawing.Point(292, 19);
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(112, 29);
            this.numThreads.TabIndex = 0;
            // 
            // btnStartThreads
            // 
            this.btnStartThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartThreads.Location = new System.Drawing.Point(36, 12);
            this.btnStartThreads.Name = "btnStartThreads";
            this.btnStartThreads.Size = new System.Drawing.Size(219, 42);
            this.btnStartThreads.TabIndex = 1;
            this.btnStartThreads.Text = "Start ALl Threads";
            this.btnStartThreads.UseVisualStyleBackColor = true;
            this.btnStartThreads.Click += new System.EventHandler(this.btnStartThreads_Click);
            // 
            // LbxTxtLog
            // 
            this.LbxTxtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxTxtLog.FormattingEnabled = true;
            this.LbxTxtLog.ItemHeight = 24;
            this.LbxTxtLog.Location = new System.Drawing.Point(36, 73);
            this.LbxTxtLog.Name = "LbxTxtLog";
            this.LbxTxtLog.ScrollAlwaysVisible = true;
            this.LbxTxtLog.Size = new System.Drawing.Size(758, 748);
            this.LbxTxtLog.TabIndex = 3;
            // 
            // frmUpdateUIFromThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 841);
            this.Controls.Add(this.LbxTxtLog);
            this.Controls.Add(this.btnStartThreads);
            this.Controls.Add(this.numThreads);
            this.Name = "frmUpdateUIFromThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update UI from another thread";
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Button btnStartThreads;
        private System.Windows.Forms.ListBox LbxTxtLog;
    }
}

