namespace CalculadoraTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nmero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Somar = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero: ";
            // 
            // Nmero1
            // 
            this.Nmero1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmero1.Location = new System.Drawing.Point(168, 81);
            this.Nmero1.Name = "Nmero1";
            this.Nmero1.Size = new System.Drawing.Size(100, 39);
            this.Nmero1.TabIndex = 3;
            this.Nmero1.TextChanged += new System.EventHandler(this.Nmero1_TextChanged);
            // 
            // Numero2
            // 
            this.Numero2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.Location = new System.Drawing.Point(168, 149);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(100, 39);
            this.Numero2.TabIndex = 4;
            this.Numero2.TextChanged += new System.EventHandler(this.Numero2_TextChanged);
            // 
            // Somar
            // 
            this.Somar.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somar.ForeColor = System.Drawing.Color.Black;
            this.Somar.Location = new System.Drawing.Point(12, 211);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(180, 60);
            this.Somar.TabIndex = 5;
            this.Somar.Text = "SOMAR";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.ForeColor = System.Drawing.Color.Black;
            this.Subtrair.Location = new System.Drawing.Point(221, 211);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(180, 60);
            this.Subtrair.TabIndex = 6;
            this.Subtrair.Text = "SUBTRAIR";
            this.Subtrair.UseVisualStyleBackColor = true;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Dividir
            // 
            this.Dividir.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.ForeColor = System.Drawing.Color.Black;
            this.Dividir.Location = new System.Drawing.Point(12, 277);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(180, 60);
            this.Dividir.TabIndex = 7;
            this.Dividir.Text = "DIVIDIR";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.ForeColor = System.Drawing.Color.Black;
            this.Multiplicar.Location = new System.Drawing.Point(221, 288);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(180, 60);
            this.Multiplicar.TabIndex = 8;
            this.Multiplicar.Text = "MULTIPLICAR";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpar.Location = new System.Drawing.Point(420, 211);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(81, 137);
            this.Limpar.TabIndex = 9;
            this.Limpar.Text = "LIMPAR";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(21, 380);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(489, 43);
            this.Resultado.TabIndex = 10;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Software destinado a realizar xcalculos básicos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Somar);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Nmero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(567, 489);
            this.MinimumSize = new System.Drawing.Size(567, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nmero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.TextBox Resultado;
    }
}

