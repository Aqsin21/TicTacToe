
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private Label lblResultMessage;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewGame = new Button();
            lblResMessage = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(318, 145);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(116, 55);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game ";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblResMessage
            // 
            lblResMessage.AutoSize = true;
            lblResMessage.Location = new Point(353, 522);
            lblResMessage.Name = "lblResMessage";
            lblResMessage.Size = new Size(50, 20);
            lblResMessage.TabIndex = 1;
            lblResMessage.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblResMessage);
            Controls.Add(btnNewGame);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnNewGame;
        private Label lblResMessage;
    }
}
