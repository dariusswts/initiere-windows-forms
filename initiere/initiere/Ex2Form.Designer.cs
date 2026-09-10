namespace initiere
{
    partial class Ex2Form
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
            this.lblProba = new System.Windows.Forms.Label();
            this.btnMare = new System.Windows.Forms.Button();
            this.btnRosu = new System.Windows.Forms.Button();
            this.btnAscunde = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProba
            // 
            this.lblProba.AutoSize = true;
            this.lblProba.Location = new System.Drawing.Point(400, 76);
            this.lblProba.Name = "lblProba";
            this.lblProba.Size = new System.Drawing.Size(45, 13);
            this.lblProba.TabIndex = 0;
            this.lblProba.Text = "lblProba";
            // 
            // btnMare
            // 
            this.btnMare.Location = new System.Drawing.Point(258, 190);
            this.btnMare.Name = "btnMare";
            this.btnMare.Size = new System.Drawing.Size(75, 23);
            this.btnMare.TabIndex = 1;
            this.btnMare.Text = "btnMare";
            this.btnMare.UseVisualStyleBackColor = true;
            this.btnMare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRosu
            // 
            this.btnRosu.Location = new System.Drawing.Point(339, 190);
            this.btnRosu.Name = "btnRosu";
            this.btnRosu.Size = new System.Drawing.Size(75, 23);
            this.btnRosu.TabIndex = 2;
            this.btnRosu.Text = "btnRosu";
            this.btnRosu.UseVisualStyleBackColor = true;
            this.btnRosu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAscunde
            // 
            this.btnAscunde.Location = new System.Drawing.Point(430, 190);
            this.btnAscunde.Name = "btnAscunde";
            this.btnAscunde.Size = new System.Drawing.Size(75, 23);
            this.btnAscunde.TabIndex = 3;
            this.btnAscunde.Text = "btnAscunde";
            this.btnAscunde.UseVisualStyleBackColor = true;
            this.btnAscunde.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(511, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ex2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAscunde);
            this.Controls.Add(this.btnRosu);
            this.Controls.Add(this.btnMare);
            this.Controls.Add(this.lblProba);
            this.Name = "Ex2Form";
            this.Text = "Ex2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProba;
        private System.Windows.Forms.Button btnMare;
        private System.Windows.Forms.Button btnRosu;
        private System.Windows.Forms.Button btnAscunde;
        private System.Windows.Forms.Button btnReset;
    }
}