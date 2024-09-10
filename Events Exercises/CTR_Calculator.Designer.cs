namespace Events_Exercises
{
    partial class CTR_Calculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtbNumber1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNumber2 = new System.Windows.Forms.TextBox();
            this.txtbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button1.Location = new System.Drawing.Point(181, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbNumber1
            // 
            this.txtbNumber1.Location = new System.Drawing.Point(147, 41);
            this.txtbNumber1.Name = "txtbNumber1";
            this.txtbNumber1.Size = new System.Drawing.Size(194, 22);
            this.txtbNumber1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(360, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(4, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number2";
            // 
            // txtbNumber2
            // 
            this.txtbNumber2.Location = new System.Drawing.Point(147, 91);
            this.txtbNumber2.Name = "txtbNumber2";
            this.txtbNumber2.Size = new System.Drawing.Size(194, 22);
            this.txtbNumber2.TabIndex = 4;
            // 
            // txtbResult
            // 
            this.txtbResult.AutoSize = true;
            this.txtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtbResult.Location = new System.Drawing.Point(347, 151);
            this.txtbResult.Name = "txtbResult";
            this.txtbResult.Size = new System.Drawing.Size(0, 22);
            this.txtbResult.TabIndex = 6;
            // 
            // CTR_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNumber1);
            this.Controls.Add(this.button1);
            this.Name = "CTR_Calculator";
            this.Size = new System.Drawing.Size(463, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbNumber1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNumber2;
        private System.Windows.Forms.Label txtbResult;
    }
}
