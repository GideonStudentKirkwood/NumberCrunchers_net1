namespace PresentationLayer
{
    partial class frmPlay
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameText = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.numPlayerAnswer = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConfrim = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.SystemColors.Menu;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(168, 25);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(112, 34);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score :";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGameText
            // 
            this.lblGameText.BackColor = System.Drawing.SystemColors.Menu;
            this.lblGameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameText.Location = new System.Drawing.Point(168, 74);
            this.lblGameText.Name = "lblGameText";
            this.lblGameText.Size = new System.Drawing.Size(238, 34);
            this.lblGameText.TabIndex = 2;
            this.lblGameText.Text = "Game text Place holder text";
            this.lblGameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquation
            // 
            this.lblEquation.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.Location = new System.Drawing.Point(168, 108);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(238, 34);
            this.lblEquation.TabIndex = 3;
            this.lblEquation.Text = "Example Equation x+y=0";
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.BackColor = System.Drawing.SystemColors.Menu;
            this.lblAnswerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerText.Location = new System.Drawing.Point(168, 184);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(130, 25);
            this.lblAnswerText.TabIndex = 4;
            this.lblAnswerText.Text = "Whats the answer?";
            this.lblAnswerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPlayerAnswer
            // 
            this.numPlayerAnswer.Location = new System.Drawing.Point(303, 189);
            this.numPlayerAnswer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPlayerAnswer.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numPlayerAnswer.Name = "numPlayerAnswer";
            this.numPlayerAnswer.Size = new System.Drawing.Size(102, 20);
            this.numPlayerAnswer.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(168, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save for Later";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfrim.Location = new System.Drawing.Point(285, 244);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(120, 29);
            this.btnConfrim.TabIndex = 7;
            this.btnConfrim.Text = "Confirm";
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfrim_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(286, 25);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(120, 34);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player :";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnConfrim);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPlayerAnswer);
            this.Controls.Add(this.lblAnswerText);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.lblGameText);
            this.Controls.Add(this.lblScore);
            this.Name = "frmPlay";
            this.Text = "Number Crunchers";
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameText;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.NumericUpDown numPlayerAnswer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConfrim;
        private System.Windows.Forms.Label lblPlayerName;
    }
}