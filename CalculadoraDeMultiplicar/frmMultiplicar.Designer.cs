namespace CalculadoraDeMultiplicar
{
    partial class frmMultiplicar
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
            this.lblRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(116, 138);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Resultado:";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(84, 86);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(64, 25);
            this.btnSomar.TabIndex = 18;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Número 2:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(119, 48);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(59, 20);
            this.txtN2.TabIndex = 16;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(119, 22);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(59, 20);
            this.txtN1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Número 1:";
            // 
            // frmMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "frmMultiplicar";
            this.Text = "Multiplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
    }
}

