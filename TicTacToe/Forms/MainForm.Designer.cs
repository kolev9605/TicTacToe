namespace TicTacToe.Game.Forms
{
    partial class MainForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            //TitleLabelConfiguration
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(120, 87);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(540, 69);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tic Tac Toe Game";

            //PlayButtonConfiguration
            this.playButton.Location = new System.Drawing.Point(302, 224);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(131, 39);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);

            //OptionsButtonConfiguration
            this.optionsButton.Location = new System.Drawing.Point(302, 269);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(131, 39);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);

            //QuitButtonConfiguration
            this.quitButton.Location = new System.Drawing.Point(302, 314);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(131, 39);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);

            //MainFormConfiguration
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(Constants.FormWidth, Constants.FormHeight);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.ResumeLayout(false);

            //PerformLayout
            this.PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button quitButton;
    }
}

