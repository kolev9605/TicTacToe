namespace TicTacToe.Game.Forms
{
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
            this.oPicture = new System.Windows.Forms.PictureBox();
            this.xPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boardImage
            // 
            this.boardImage.Image = global::TicTacToe.Game.Properties.Resources.board;
            this.boardImage.Location = new System.Drawing.Point(175, 111);
            this.boardImage.Name = "boardImage";
            this.boardImage.Size = new System.Drawing.Size(420, 420);
            this.boardImage.TabIndex = 0;
            this.boardImage.TabStop = false;
            // 
            // oPicture
            // 
            this.oPicture.Image = global::TicTacToe.Game.Properties.Resources.o;
            this.oPicture.Location = new System.Drawing.Point(336, 430);
            this.oPicture.Name = "oPicture";
            this.oPicture.Size = new System.Drawing.Size(100, 101);
            this.oPicture.TabIndex = 1;
            this.oPicture.TabStop = false;
            // 
            // xPicture
            // 
            this.xPicture.Image = global::TicTacToe.Game.Properties.Resources.x;
            this.xPicture.Location = new System.Drawing.Point(485, 430);
            this.xPicture.Name = "xPicture";
            this.xPicture.Size = new System.Drawing.Size(100, 101);
            this.xPicture.TabIndex = 2;
            this.xPicture.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.xPicture);
            this.Controls.Add(this.oPicture);
            this.Controls.Add(this.boardImage);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPicture)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox boardImage;
        private System.Windows.Forms.PictureBox oPicture;
        private System.Windows.Forms.PictureBox xPicture;
    }
}