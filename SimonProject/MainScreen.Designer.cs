namespace SimonProject
{
    partial class MainScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Lime;
            this.startButton.Location = new System.Drawing.Point(14, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(82, 73);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "New Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Lime;
            this.exitButton.Location = new System.Drawing.Point(208, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 73);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.Location = new System.Drawing.Point(162, 97);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(125, 94);
            this.greenLabel.TabIndex = 2;
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(11, 97);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(131, 94);
            this.blueLabel.TabIndex = 3;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.Location = new System.Drawing.Point(14, 204);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(128, 87);
            this.yellowLabel.TabIndex = 4;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(162, 204);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(121, 87);
            this.redLabel.TabIndex = 5;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(300, 300);
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label redLabel;
    }
}
