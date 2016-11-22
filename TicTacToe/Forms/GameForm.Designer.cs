namespace TicTacToe.Game.Forms
{
    using System.Drawing;
    using System.Windows.Forms;

    partial class GameForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boardImage = new System.Windows.Forms.PictureBox();
            this.newGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // boardImage
            // 
            this.boardImage.BackColor = System.Drawing.Color.Transparent;
            this.boardImage.Image = global::TicTacToe.Game.Properties.Resources.board;
            this.boardImage.Location = new System.Drawing.Point(175, 111);
            this.boardImage.Name = "boardImage";
            this.boardImage.Size = new System.Drawing.Size(420, 420);
            this.boardImage.TabIndex = 0;
            this.boardImage.TabStop = false;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(308, 48);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(101, 23);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.boardImage);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox boardImage;
        private Button newGameButton;
    }
}