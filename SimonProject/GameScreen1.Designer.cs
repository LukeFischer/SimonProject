namespace SimonProject
{
    partial class GameScreen1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(157, 163);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(140, 124);
            this.redButton.TabIndex = 0;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(157, 14);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(140, 139);
            this.greenButton.TabIndex = 1;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(18, 163);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(133, 124);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(18, 12);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(133, 143);
            this.blueButton.TabIndex = 3;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // GameScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Name = "GameScreen1";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.GameScreen1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
    }
}
