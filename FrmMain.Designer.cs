namespace WFA220603
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblNev = new System.Windows.Forms.Label();
            this.btnMeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(671, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Köszönj!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNev
            // 
            this.lblNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNev.Location = new System.Drawing.Point(12, 9);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(958, 521);
            this.lblNev.TabIndex = 1;
            this.lblNev.Text = "###";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMeg
            // 
            this.btnMeg.BackColor = System.Drawing.Color.Lime;
            this.btnMeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMeg.Location = new System.Drawing.Point(366, 533);
            this.btnMeg.Name = "btnMeg";
            this.btnMeg.Size = new System.Drawing.Size(299, 58);
            this.btnMeg.TabIndex = 0;
            this.btnMeg.Text = "MÉG!";
            this.btnMeg.UseVisualStyleBackColor = false;
            this.btnMeg.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.lblNev);
            this.Controls.Add(this.btnMeg);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Button btnMeg;
    }
}

