namespace TicTacToe.Game.Forms
{
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
            this.firstCellPictureBox = new System.Windows.Forms.PictureBox();
            this.secondCellPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdCellPictureBox = new System.Windows.Forms.PictureBox();
            this.fourthCellPictureBox = new System.Windows.Forms.PictureBox();
            this.fifthCellPictureBox = new System.Windows.Forms.PictureBox();
            this.sixthCellPictureBox = new System.Windows.Forms.PictureBox();
            this.seventhCellPictureBox = new System.Windows.Forms.PictureBox();
            this.eighthCellPictureBox = new System.Windows.Forms.PictureBox();
            this.ninthCellPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seventhCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eighthCellPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninthCellPictureBox)).BeginInit();
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
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameButton.Location = new System.Drawing.Point(124, 33);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(220, 47);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // firstCellPictureBox
            // 
            this.firstCellPictureBox.Location = new System.Drawing.Point(185, 122);
            this.firstCellPictureBox.Name = "firstCellPictureBox";
            this.firstCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.firstCellPictureBox.TabIndex = 2;
            this.firstCellPictureBox.TabStop = false;
            this.firstCellPictureBox.Click += new System.EventHandler(this.firstCellPictureBox_Click);
            // 
            // secondCellPictureBox
            // 
            this.secondCellPictureBox.Location = new System.Drawing.Point(341, 122);
            this.secondCellPictureBox.Name = "secondCellPictureBox";
            this.secondCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.secondCellPictureBox.TabIndex = 3;
            this.secondCellPictureBox.TabStop = false;
            this.secondCellPictureBox.Click += new System.EventHandler(this.secondCellPictureBox_Click);
            // 
            // thirdCellPictureBox
            // 
            this.thirdCellPictureBox.Location = new System.Drawing.Point(490, 122);
            this.thirdCellPictureBox.Name = "thirdCellPictureBox";
            this.thirdCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.thirdCellPictureBox.TabIndex = 4;
            this.thirdCellPictureBox.TabStop = false;
            this.thirdCellPictureBox.Click += new System.EventHandler(this.thirdCellPictureBox_Click);
            // 
            // fourthCellPictureBox
            // 
            this.fourthCellPictureBox.Location = new System.Drawing.Point(185, 269);
            this.fourthCellPictureBox.Name = "fourthCellPictureBox";
            this.fourthCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.fourthCellPictureBox.TabIndex = 5;
            this.fourthCellPictureBox.TabStop = false;
            this.fourthCellPictureBox.Click += new System.EventHandler(this.fourthCellPictureBox_Click);
            // 
            // fifthCellPictureBox
            // 
            this.fifthCellPictureBox.Location = new System.Drawing.Point(341, 269);
            this.fifthCellPictureBox.Name = "fifthCellPictureBox";
            this.fifthCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.fifthCellPictureBox.TabIndex = 6;
            this.fifthCellPictureBox.TabStop = false;
            this.fifthCellPictureBox.Click += new System.EventHandler(this.fifthCellPictureBox_Click);
            // 
            // sixthCellPictureBox
            // 
            this.sixthCellPictureBox.Location = new System.Drawing.Point(490, 269);
            this.sixthCellPictureBox.Name = "sixthCellPictureBox";
            this.sixthCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.sixthCellPictureBox.TabIndex = 7;
            this.sixthCellPictureBox.TabStop = false;
            this.sixthCellPictureBox.Click += new System.EventHandler(this.sixthCellPictureBox_Click);
            // 
            // seventhCellPictureBox
            // 
            this.seventhCellPictureBox.Location = new System.Drawing.Point(185, 423);
            this.seventhCellPictureBox.Name = "seventhCellPictureBox";
            this.seventhCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.seventhCellPictureBox.TabIndex = 8;
            this.seventhCellPictureBox.TabStop = false;
            this.seventhCellPictureBox.Click += new System.EventHandler(this.seventhCellPictureBox_Click);
            // 
            // eighthCellPictureBox
            // 
            this.eighthCellPictureBox.Location = new System.Drawing.Point(341, 423);
            this.eighthCellPictureBox.Name = "eighthCellPictureBox";
            this.eighthCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.eighthCellPictureBox.TabIndex = 9;
            this.eighthCellPictureBox.TabStop = false;
            this.eighthCellPictureBox.Click += new System.EventHandler(this.eighthCellPictureBox_Click);
            // 
            // ninthCellPictureBox
            // 
            this.ninthCellPictureBox.Location = new System.Drawing.Point(490, 423);
            this.ninthCellPictureBox.Name = "ninthCellPictureBox";
            this.ninthCellPictureBox.Size = new System.Drawing.Size(100, 101);
            this.ninthCellPictureBox.TabIndex = 10;
            this.ninthCellPictureBox.TabStop = false;
            this.ninthCellPictureBox.Click += new System.EventHandler(this.ninthCellPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(445, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(220, 47);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back to main menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ninthCellPictureBox);
            this.Controls.Add(this.eighthCellPictureBox);
            this.Controls.Add(this.seventhCellPictureBox);
            this.Controls.Add(this.sixthCellPictureBox);
            this.Controls.Add(this.fifthCellPictureBox);
            this.Controls.Add(this.fourthCellPictureBox);
            this.Controls.Add(this.thirdCellPictureBox);
            this.Controls.Add(this.secondCellPictureBox);
            this.Controls.Add(this.firstCellPictureBox);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.boardImage);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.boardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seventhCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eighthCellPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ninthCellPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox boardImage;
        private Button newGameButton;
        private PictureBox firstCellPictureBox;
        private PictureBox secondCellPictureBox;
        private PictureBox thirdCellPictureBox;
        private PictureBox fourthCellPictureBox;
        private PictureBox fifthCellPictureBox;
        private PictureBox sixthCellPictureBox;
        private PictureBox seventhCellPictureBox;
        private PictureBox eighthCellPictureBox;
        private PictureBox ninthCellPictureBox;
        private Button backButton;
    }
}