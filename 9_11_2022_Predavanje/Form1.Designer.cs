namespace _9_11_2022_Predavanje
{
    partial class Form1
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
            this.lblReturnGame = new System.Windows.Forms.Label();
            this.btnShowGame = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.lblReturn2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReturnGame
            // 
            this.lblReturnGame.AutoSize = true;
            this.lblReturnGame.Location = new System.Drawing.Point(28, 80);
            this.lblReturnGame.Name = "lblReturnGame";
            this.lblReturnGame.Size = new System.Drawing.Size(0, 13);
            this.lblReturnGame.TabIndex = 0;
            // 
            // btnShowGame
            // 
            this.btnShowGame.Location = new System.Drawing.Point(54, 34);
            this.btnShowGame.Name = "btnShowGame";
            this.btnShowGame.Size = new System.Drawing.Size(75, 23);
            this.btnShowGame.TabIndex = 1;
            this.btnShowGame.Text = "Prikaži";
            this.btnShowGame.UseVisualStyleBackColor = true;
            this.btnShowGame.Click += new System.EventHandler(this.btnShowGame_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(308, 34);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(75, 23);
            this.btnShow2.TabIndex = 3;
            this.btnShow2.Text = "Prikaži";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // lblReturn2
            // 
            this.lblReturn2.AutoSize = true;
            this.lblReturn2.Location = new System.Drawing.Point(282, 80);
            this.lblReturn2.Name = "lblReturn2";
            this.lblReturn2.Size = new System.Drawing.Size(0, 13);
            this.lblReturn2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.lblReturn2);
            this.Controls.Add(this.btnShowGame);
            this.Controls.Add(this.lblReturnGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnGame;
        private System.Windows.Forms.Button btnShowGame;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Label lblReturn2;
    }
}

