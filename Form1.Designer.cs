namespace SupervisorWebService
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getCallCounterStates = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.setSessionParameters = new System.Windows.Forms.Button();
            this.closeSession = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.getUserInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getColumnNames = new System.Windows.Forms.Button();
            this.getStatisticsUpdate = new System.Windows.Forms.Button();
            this.getStatistics = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.closeSession2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getCallCounterStates
            // 
            this.getCallCounterStates.Enabled = false;
            this.getCallCounterStates.Location = new System.Drawing.Point(181, 19);
            this.getCallCounterStates.Name = "getCallCounterStates";
            this.getCallCounterStates.Size = new System.Drawing.Size(124, 23);
            this.getCallCounterStates.TabIndex = 3;
            this.getCallCounterStates.Text = "getCallCounterStates";
            this.getCallCounterStates.UseVisualStyleBackColor = true;
            this.getCallCounterStates.Click += new System.EventHandler(this.getCallCounterStates_Click);
            // 
            // textOutput
            // 
            this.textOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutput.Location = new System.Drawing.Point(7, 189);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(624, 326);
            this.textOutput.TabIndex = 12;
            // 
            // setSessionParameters
            // 
            this.setSessionParameters.Location = new System.Drawing.Point(16, 19);
            this.setSessionParameters.Name = "setSessionParameters";
            this.setSessionParameters.Size = new System.Drawing.Size(135, 23);
            this.setSessionParameters.TabIndex = 2;
            this.setSessionParameters.Text = "setSessionParameters";
            this.setSessionParameters.UseVisualStyleBackColor = true;
            this.setSessionParameters.Click += new System.EventHandler(this.setSessionParameters_Click);
            // 
            // closeSession
            // 
            this.closeSession.Enabled = false;
            this.closeSession.Location = new System.Drawing.Point(329, 49);
            this.closeSession.Name = "closeSession";
            this.closeSession.Size = new System.Drawing.Size(114, 23);
            this.closeSession.TabIndex = 7;
            this.closeSession.Text = "closeSession";
            this.closeSession.UseVisualStyleBackColor = true;
            this.closeSession.Click += new System.EventHandler(this.closeSession_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(342, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(71, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 15);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(283, 15);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // getUserInfo
            // 
            this.getUserInfo.Location = new System.Drawing.Point(16, 19);
            this.getUserInfo.Name = "getUserInfo";
            this.getUserInfo.Size = new System.Drawing.Size(135, 22);
            this.getUserInfo.TabIndex = 8;
            this.getUserInfo.Text = "getUserInfo";
            this.getUserInfo.UseVisualStyleBackColor = true;
            this.getUserInfo.Click += new System.EventHandler(this.getUserInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getColumnNames);
            this.groupBox1.Controls.Add(this.getStatisticsUpdate);
            this.groupBox1.Controls.Add(this.getStatistics);
            this.groupBox1.Controls.Add(this.setSessionParameters);
            this.groupBox1.Controls.Add(this.getCallCounterStates);
            this.groupBox1.Controls.Add(this.closeSession);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supervisor Service";
            // 
            // getColumnNames
            // 
            this.getColumnNames.Enabled = false;
            this.getColumnNames.Location = new System.Drawing.Point(329, 19);
            this.getColumnNames.Name = "getColumnNames";
            this.getColumnNames.Size = new System.Drawing.Size(114, 23);
            this.getColumnNames.TabIndex = 4;
            this.getColumnNames.Text = "getColumnNames";
            this.getColumnNames.UseVisualStyleBackColor = true;
            this.getColumnNames.Click += new System.EventHandler(this.getColumnNames_Click);
            // 
            // getStatisticsUpdate
            // 
            this.getStatisticsUpdate.Enabled = false;
            this.getStatisticsUpdate.Location = new System.Drawing.Point(181, 49);
            this.getStatisticsUpdate.Name = "getStatisticsUpdate";
            this.getStatisticsUpdate.Size = new System.Drawing.Size(124, 23);
            this.getStatisticsUpdate.TabIndex = 6;
            this.getStatisticsUpdate.Text = "getStatisticsUpdate";
            this.getStatisticsUpdate.UseVisualStyleBackColor = true;
            this.getStatisticsUpdate.Click += new System.EventHandler(this.getStatisticsUpdate_Click);
            // 
            // getStatistics
            // 
            this.getStatistics.Enabled = false;
            this.getStatistics.Location = new System.Drawing.Point(16, 49);
            this.getStatistics.Name = "getStatistics";
            this.getStatistics.Size = new System.Drawing.Size(135, 23);
            this.getStatistics.TabIndex = 5;
            this.getStatistics.Text = "getStatistics";
            this.getStatistics.UseVisualStyleBackColor = true;
            this.getStatistics.Click += new System.EventHandler(this.getStatistics_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.closeSession2);
            this.groupBox2.Controls.Add(this.getUserInfo);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 52);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin Service";
            // 
            // closeSession2
            // 
            this.closeSession2.Enabled = false;
            this.closeSession2.Location = new System.Drawing.Point(329, 18);
            this.closeSession2.Name = "closeSession2";
            this.closeSession2.Size = new System.Drawing.Size(114, 23);
            this.closeSession2.TabIndex = 9;
            this.closeSession2.Text = "closeSession";
            this.closeSession2.UseVisualStyleBackColor = true;
            this.closeSession2.Click += new System.EventHandler(this.closeSession2_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(553, 149);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(69, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "clear log";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SupervisorWebService.Properties.Resources.five9_logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(487, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Five9 Supervisor / Admin API";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCallCounterStates;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button setSessionParameters;
        private System.Windows.Forms.Button closeSession;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button getUserInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button closeSession2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button getStatisticsUpdate;
        private System.Windows.Forms.Button getStatistics;
        private System.Windows.Forms.Button getColumnNames;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

