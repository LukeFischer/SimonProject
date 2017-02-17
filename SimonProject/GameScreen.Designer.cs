namespace SimonProject
{
    partial class GameScreen
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
            this.bluebutton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bluebutton
            // 
            this.bluebutton.BackColor = System.Drawing.Color.Blue;
            this.bluebutton.Location = new System.Drawing.Point(15, 17);
            this.bluebutton.Name = "bluebutton";
            this.bluebutton.Size = new System.Drawing.Size(130, 134);
            this.bluebutton.TabIndex = 0;
            this.bluebutton.UseVisualStyleBackColor = false;
            this.bluebutton.Click += new System.EventHandler(this.bluebutton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(151, 17);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(137, 134);
            this.greenButton.TabIndex = 1;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(15, 157);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(130, 140);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(151, 157);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(137, 140);
            this.redButton.TabIndex = 3;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.bluebutton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(300, 300);
            // this.Load += new System.EventHandler(this.ComputerTurn);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bluebutton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button redButton;
    }
}
