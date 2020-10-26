namespace SimplexCalculator
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumVarDec = new System.Windows.Forms.TextBox();
            this.NumRest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumVarDec
            // 
            this.NumVarDec.Location = new System.Drawing.Point(412, 150);
            this.NumVarDec.Name = "NumVarDec";
            this.NumVarDec.Size = new System.Drawing.Size(100, 23);
            this.NumVarDec.TabIndex = 0;
            // 
            // NumRest
            // 
            this.NumRest.Location = new System.Drawing.Point(412, 200);
            this.NumRest.Name = "NumRest";
            this.NumRest.Size = new System.Drawing.Size(100, 23);
            this.NumRest.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o número de variáveis de decisão:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Informe o número de restrições:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(347, 271);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(100, 44);
            this.btnProx.TabIndex = 2;
            this.btnProx.Text = "Continuar";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumRest);
            this.Controls.Add(this.NumVarDec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProx;
        public System.Windows.Forms.TextBox NumVarDec;
        public System.Windows.Forms.TextBox NumRest;
    }
}

