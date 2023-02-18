namespace PresentationLayer
{
    partial class frmMainMenu
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
            this.lblGameWelcome = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblsetname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameWelcome
            // 
            this.lblGameWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGameWelcome.Location = new System.Drawing.Point(62, 39);
            this.lblGameWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGameWelcome.Name = "lblGameWelcome";
            this.lblGameWelcome.Size = new System.Drawing.Size(443, 29);
            this.lblGameWelcome.TabIndex = 0;
            this.lblGameWelcome.Text = "Welcome to Number Crunchers!";
            this.lblGameWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(65, 94);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(130, 42);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(65, 141);
            this.btnRules.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(130, 42);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(65, 189);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(130, 42);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(65, 236);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(130, 42);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHighScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(342, 94);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(146, 62);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "High Score: \r\nScoreHolder: ";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(202, 108);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtPlayerName.MaxLength = 10;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(104, 20);
            this.txtPlayerName.TabIndex = 6;
            // 
            // lblsetname
            // 
            this.lblsetname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblsetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsetname.Location = new System.Drawing.Point(115, 68);
            this.lblsetname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblsetname.Name = "lblsetname";
            this.lblsetname.Size = new System.Drawing.Size(339, 16);
            this.lblsetname.TabIndex = 7;
            this.lblsetname.Text = "Enter your name next to the play button and hit start to begin!";
            this.lblsetname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.lblsetname);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblGameWelcome);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmMainMenu";
            this.Text = "Number Crunchers";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameWelcome;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblsetname;
    }
}

