namespace TicTacToe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputP1 = new System.Windows.Forms.TextBox();
            this.inputP2 = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = global::TicTacToe.Properties.Resources.chalkboard_background_29_free_pdf_jpg_vector_eps_ai_format_chalk_board_background;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Image = global::TicTacToe.Properties.Resources.chalkboard_background_29_free_pdf_jpg_vector_eps_ai_format_chalk_board_background;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Two Name:";
            // 
            // inputP1
            // 
            this.inputP1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.inputP1.Location = new System.Drawing.Point(197, 9);
            this.inputP1.Name = "inputP1";
            this.inputP1.Size = new System.Drawing.Size(141, 33);
            this.inputP1.TabIndex = 2;
            // 
            // inputP2
            // 
            this.inputP2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.inputP2.Location = new System.Drawing.Point(197, 55);
            this.inputP2.Name = "inputP2";
            this.inputP2.Size = new System.Drawing.Size(141, 33);
            this.inputP2.TabIndex = 3;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPlay.Image = global::TicTacToe.Properties.Resources.chalkboard_background_29_free_pdf_jpg_vector_eps_ai_format_chalk_board_background;
            this.buttonPlay.Location = new System.Drawing.Point(46, 99);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(267, 36);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.buttonPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.chalkboard_background_29_free_pdf_jpg_vector_eps_ai_format_chalk_board_background;
            this.ClientSize = new System.Drawing.Size(350, 136);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.inputP2);
            this.Controls.Add(this.inputP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(366, 175);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 175);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputP1;
        private System.Windows.Forms.TextBox inputP2;
        private System.Windows.Forms.Button buttonPlay;
    }
}