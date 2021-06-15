
namespace TicTacToe
{
    partial class FormMain
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
            this.buttonTopLeft = new System.Windows.Forms.Button();
            this.buttonTopMiddle = new System.Windows.Forms.Button();
            this.buttonTopRight = new System.Windows.Forms.Button();
            this.buttonMiddleRight = new System.Windows.Forms.Button();
            this.buttonMiddleMiddle = new System.Windows.Forms.Button();
            this.buttonMiddleLeft = new System.Windows.Forms.Button();
            this.buttonBottomRight = new System.Windows.Forms.Button();
            this.buttonBottomMiddle = new System.Windows.Forms.Button();
            this.buttonBottomLeft = new System.Windows.Forms.Button();
            this.labelTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTopLeft
            // 
            this.buttonTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopLeft.Location = new System.Drawing.Point(12, 12);
            this.buttonTopLeft.Name = "buttonTopLeft";
            this.buttonTopLeft.Size = new System.Drawing.Size(80, 80);
            this.buttonTopLeft.TabIndex = 0;
            this.buttonTopLeft.UseVisualStyleBackColor = true;
            // 
            // buttonTopMiddle
            // 
            this.buttonTopMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonTopMiddle.Location = new System.Drawing.Point(98, 12);
            this.buttonTopMiddle.Name = "buttonTopMiddle";
            this.buttonTopMiddle.Size = new System.Drawing.Size(80, 80);
            this.buttonTopMiddle.TabIndex = 1;
            this.buttonTopMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonTopRight
            // 
            this.buttonTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonTopRight.Location = new System.Drawing.Point(184, 12);
            this.buttonTopRight.Name = "buttonTopRight";
            this.buttonTopRight.Size = new System.Drawing.Size(80, 80);
            this.buttonTopRight.TabIndex = 2;
            this.buttonTopRight.UseVisualStyleBackColor = true;
            // 
            // buttonMiddleRight
            // 
            this.buttonMiddleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonMiddleRight.Location = new System.Drawing.Point(184, 98);
            this.buttonMiddleRight.Name = "buttonMiddleRight";
            this.buttonMiddleRight.Size = new System.Drawing.Size(80, 80);
            this.buttonMiddleRight.TabIndex = 5;
            this.buttonMiddleRight.UseVisualStyleBackColor = true;
            // 
            // buttonMiddleMiddle
            // 
            this.buttonMiddleMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonMiddleMiddle.Location = new System.Drawing.Point(98, 98);
            this.buttonMiddleMiddle.Name = "buttonMiddleMiddle";
            this.buttonMiddleMiddle.Size = new System.Drawing.Size(80, 80);
            this.buttonMiddleMiddle.TabIndex = 4;
            this.buttonMiddleMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonMiddleLeft
            // 
            this.buttonMiddleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonMiddleLeft.Location = new System.Drawing.Point(12, 98);
            this.buttonMiddleLeft.Name = "buttonMiddleLeft";
            this.buttonMiddleLeft.Size = new System.Drawing.Size(80, 80);
            this.buttonMiddleLeft.TabIndex = 3;
            this.buttonMiddleLeft.UseVisualStyleBackColor = true;
            // 
            // buttonBottomRight
            // 
            this.buttonBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonBottomRight.Location = new System.Drawing.Point(184, 184);
            this.buttonBottomRight.Name = "buttonBottomRight";
            this.buttonBottomRight.Size = new System.Drawing.Size(80, 80);
            this.buttonBottomRight.TabIndex = 8;
            this.buttonBottomRight.UseVisualStyleBackColor = true;
            // 
            // buttonBottomMiddle
            // 
            this.buttonBottomMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonBottomMiddle.Location = new System.Drawing.Point(98, 184);
            this.buttonBottomMiddle.Name = "buttonBottomMiddle";
            this.buttonBottomMiddle.Size = new System.Drawing.Size(80, 80);
            this.buttonBottomMiddle.TabIndex = 7;
            this.buttonBottomMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonBottomLeft
            // 
            this.buttonBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonBottomLeft.Location = new System.Drawing.Point(12, 184);
            this.buttonBottomLeft.Name = "buttonBottomLeft";
            this.buttonBottomLeft.Size = new System.Drawing.Size(80, 80);
            this.buttonBottomLeft.TabIndex = 6;
            this.buttonBottomLeft.UseVisualStyleBackColor = true;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTurn.Location = new System.Drawing.Point(70, 286);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(129, 25);
            this.labelTurn.TabIndex = 9;
            this.labelTurn.Text = "It is X\'s turn!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 318);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.buttonBottomRight);
            this.Controls.Add(this.buttonBottomMiddle);
            this.Controls.Add(this.buttonBottomLeft);
            this.Controls.Add(this.buttonMiddleRight);
            this.Controls.Add(this.buttonMiddleMiddle);
            this.Controls.Add(this.buttonMiddleLeft);
            this.Controls.Add(this.buttonTopRight);
            this.Controls.Add(this.buttonTopMiddle);
            this.Controls.Add(this.buttonTopLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTopLeft;
        private System.Windows.Forms.Button buttonTopMiddle;
        private System.Windows.Forms.Button buttonTopRight;
        private System.Windows.Forms.Button buttonMiddleRight;
        private System.Windows.Forms.Button buttonMiddleMiddle;
        private System.Windows.Forms.Button buttonMiddleLeft;
        private System.Windows.Forms.Button buttonBottomRight;
        private System.Windows.Forms.Button buttonBottomMiddle;
        private System.Windows.Forms.Button buttonBottomLeft;
        private System.Windows.Forms.Label labelTurn;
    }
}

