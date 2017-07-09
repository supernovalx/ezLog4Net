namespace Test.ezLog4Net
{
    partial class Main
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
            this.rtbLogMess = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnWarn = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLogMess
            // 
            this.rtbLogMess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogMess.Location = new System.Drawing.Point(12, 27);
            this.rtbLogMess.Name = "rtbLogMess";
            this.rtbLogMess.Size = new System.Drawing.Size(491, 85);
            this.rtbLogMess.TabIndex = 0;
            this.rtbLogMess.Text = "This is sample log message!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log message";
            // 
            // btnDebug
            // 
            this.btnDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebug.Location = new System.Drawing.Point(185, 130);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 2;
            this.btnDebug.Text = "DEBUG";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Location = new System.Drawing.Point(266, 130);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "INFO";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnWarn
            // 
            this.btnWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWarn.Location = new System.Drawing.Point(347, 130);
            this.btnWarn.Name = "btnWarn";
            this.btnWarn.Size = new System.Drawing.Size(75, 23);
            this.btnWarn.TabIndex = 4;
            this.btnWarn.Text = "WARN";
            this.btnWarn.UseVisualStyleBackColor = true;
            this.btnWarn.Click += new System.EventHandler(this.btnWarn_Click);
            // 
            // btnError
            // 
            this.btnError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnError.Location = new System.Drawing.Point(428, 130);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(75, 23);
            this.btnError.TabIndex = 5;
            this.btnError.Text = "ERROR";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowLog.Location = new System.Drawing.Point(12, 130);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(114, 23);
            this.btnShowLog.TabIndex = 6;
            this.btnShowLog.Text = "Show Log Console";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 165);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnWarn);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLogMess);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLogMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnWarn;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnShowLog;
    }
}

