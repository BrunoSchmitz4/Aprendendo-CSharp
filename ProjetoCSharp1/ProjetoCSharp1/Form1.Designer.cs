namespace ProjetoCSharp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Somar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(12, 38);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Subtrair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dividir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Multiplicar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(141, 12);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 6;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(141, 38);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 7;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(269, 12);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 8;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(269, 38);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 9;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(394, 12);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 20);
            this.txt7.TabIndex = 10;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(394, 38);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(100, 20);
            this.txt8.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 318);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt8;
    }
}

