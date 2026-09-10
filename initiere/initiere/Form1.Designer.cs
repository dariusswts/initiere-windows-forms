namespace initiere
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
            this.andrei = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.txtNr1 = new System.Windows.Forms.TextBox();
            this.txtNr2 = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // andrei
            // 
            this.andrei.Location = new System.Drawing.Point(363, 75);
            this.andrei.Name = "andrei";
            this.andrei.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.andrei.Size = new System.Drawing.Size(83, 35);
            this.andrei.TabIndex = 0;
            this.andrei.Text = "click";
            this.andrei.UseVisualStyleBackColor = true;
            this.andrei.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(342, 247);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(422, 151);
            this.start.TabIndex = 1;
            this.start.Text = "button1";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // txtNr1
            // 
            this.txtNr1.Location = new System.Drawing.Point(24, 82);
            this.txtNr1.Name = "txtNr1";
            this.txtNr1.Size = new System.Drawing.Size(100, 20);
            this.txtNr1.TabIndex = 2;
            // 
            // txtNr2
            // 
            this.txtNr2.Location = new System.Drawing.Point(215, 82);
            this.txtNr2.Name = "txtNr2";
            this.txtNr2.Size = new System.Drawing.Size(100, 20);
            this.txtNr2.TabIndex = 3;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(159, 86);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(13, 13);
            this.lblOp.TabIndex = 4;
            this.lblOp.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtNr2);
            this.Controls.Add(this.txtNr1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.andrei);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button andrei;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox txtNr1;
        private System.Windows.Forms.TextBox txtNr2;
        private System.Windows.Forms.Label lblOp;
    }
}

