namespace PresentationLayer
{
    partial class frmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.lblRulesText = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRulesText
            // 
            this.lblRulesText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRulesText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRulesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesText.Location = new System.Drawing.Point(112, 28);
            this.lblRulesText.Name = "lblRulesText";
            this.lblRulesText.Size = new System.Drawing.Size(353, 221);
            this.lblRulesText.TabIndex = 0;
            this.lblRulesText.Text = resources.GetString("lblRulesText.Text");
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(112, 252);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 38);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblRulesText);
            this.Name = "frmRules";
            this.Text = "Number Crunchers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRulesText;
        private System.Windows.Forms.Button btnReturn;
    }
}