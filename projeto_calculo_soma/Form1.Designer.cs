namespace projeto_calculo_soma
{
    partial class CalculadoraSoma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraSoma));
            this.textnum1 = new System.Windows.Forms.TextBox();
            this.textnum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textnum1
            // 
            this.textnum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textnum1.Location = new System.Drawing.Point(76, 29);
            this.textnum1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textnum1.Name = "textnum1";
            this.textnum1.Size = new System.Drawing.Size(253, 26);
            this.textnum1.TabIndex = 0;
            this.textnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textnum1.TextChanged += new System.EventHandler(this.textnum1_TextChanged);
            // 
            // textnum2
            // 
            this.textnum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textnum2.Location = new System.Drawing.Point(76, 79);
            this.textnum2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textnum2.Name = "textnum2";
            this.textnum2.Size = new System.Drawing.Size(253, 26);
            this.textnum2.TabIndex = 1;
            this.textnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textnum2.TextChanged += new System.EventHandler(this.textnum2_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.TabIndex = 2;
            this.label1.Text = "?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "________________________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(452, 16);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(170, 71);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(32, 419);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 54);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(502, 419);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 54);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.Window;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(32, 146);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(350, 103);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(452, 111);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(170, 71);
            this.btnSubtrair.TabIndex = 9;
            this.btnSubtrair.Text = "&Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(452, 205);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(170, 71);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = "&Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(452, 308);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(170, 71);
            this.btnMulti.TabIndex = 11;
            this.btnMulti.Text = "&Multiplicar";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(32, 271);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(170, 71);
            this.btnComparar.TabIndex = 12;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParImpar.Location = new System.Drawing.Point(212, 271);
            this.btnParImpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(170, 71);
            this.btnParImpar.TabIndex = 13;
            this.btnParImpar.Text = "Par Ímpar";
            this.btnParImpar.UseVisualStyleBackColor = true;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CalculadoraSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(642, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textnum2);
            this.Controls.Add(this.textnum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CalculadoraSoma";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.CalculadoraSoma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnum1;
        private System.Windows.Forms.TextBox textnum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnParImpar;
        private System.Windows.Forms.Label label3;
    }
}

