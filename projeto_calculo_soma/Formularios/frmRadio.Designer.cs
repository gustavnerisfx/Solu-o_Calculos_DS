namespace projeto_calculo_soma.Formularios
{
    partial class frmRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioParOuImpar = new System.Windows.Forms.RadioButton();
            this.radioMulti = new System.Windows.Forms.RadioButton();
            this.radioDividir = new System.Windows.Forms.RadioButton();
            this.radioSubtra = new System.Windows.Forms.RadioButton();
            this.radioSoma = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEXC = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioParOuImpar);
            this.groupBox1.Controls.Add(this.radioMulti);
            this.groupBox1.Controls.Add(this.radioDividir);
            this.groupBox1.Controls.Add(this.radioSubtra);
            this.groupBox1.Controls.Add(this.radioSoma);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(43, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(167, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioParOuImpar
            // 
            this.radioParOuImpar.Location = new System.Drawing.Point(14, 171);
            this.radioParOuImpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioParOuImpar.Name = "radioParOuImpar";
            this.radioParOuImpar.Size = new System.Drawing.Size(113, 33);
            this.radioParOuImpar.TabIndex = 4;
            this.radioParOuImpar.TabStop = true;
            this.radioParOuImpar.Text = "&Par ou Ímpar";
            this.radioParOuImpar.UseVisualStyleBackColor = true;
            this.radioParOuImpar.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioMulti
            // 
            this.radioMulti.Location = new System.Drawing.Point(14, 134);
            this.radioMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMulti.Name = "radioMulti";
            this.radioMulti.Size = new System.Drawing.Size(102, 33);
            this.radioMulti.TabIndex = 3;
            this.radioMulti.TabStop = true;
            this.radioMulti.Text = "&Multiplicar";
            this.radioMulti.UseVisualStyleBackColor = true;
            this.radioMulti.CheckedChanged += new System.EventHandler(this.radioMulti_CheckedChanged);
            // 
            // radioDividir
            // 
            this.radioDividir.Location = new System.Drawing.Point(14, 97);
            this.radioDividir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDividir.Name = "radioDividir";
            this.radioDividir.Size = new System.Drawing.Size(102, 33);
            this.radioDividir.TabIndex = 2;
            this.radioDividir.TabStop = true;
            this.radioDividir.Text = "&Dividir";
            this.radioDividir.UseVisualStyleBackColor = true;
            this.radioDividir.CheckedChanged += new System.EventHandler(this.radioDividir_CheckedChanged);
            // 
            // radioSubtra
            // 
            this.radioSubtra.Location = new System.Drawing.Point(14, 60);
            this.radioSubtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSubtra.Name = "radioSubtra";
            this.radioSubtra.Size = new System.Drawing.Size(102, 33);
            this.radioSubtra.TabIndex = 1;
            this.radioSubtra.TabStop = true;
            this.radioSubtra.Text = "&Subtrair";
            this.radioSubtra.UseVisualStyleBackColor = true;
            this.radioSubtra.CheckedChanged += new System.EventHandler(this.radioSubtra_CheckedChanged);
            // 
            // radioSoma
            // 
            this.radioSoma.Location = new System.Drawing.Point(14, 28);
            this.radioSoma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioSoma.Name = "radioSoma";
            this.radioSoma.Size = new System.Drawing.Size(102, 33);
            this.radioSoma.TabIndex = 0;
            this.radioSoma.TabStop = true;
            this.radioSoma.Text = "&Somar";
            this.radioSoma.UseVisualStyleBackColor = true;
            this.radioSoma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(255, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 107);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "________________________________";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(296, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 104);
            this.label3.TabIndex = 5;
            this.label3.Text = "?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnEXC
            // 
            this.btnEXC.Location = new System.Drawing.Point(186, 318);
            this.btnEXC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEXC.Name = "btnEXC";
            this.btnEXC.Size = new System.Drawing.Size(117, 51);
            this.btnEXC.TabIndex = 6;
            this.btnEXC.Text = "&Executar";
            this.btnEXC.UseVisualStyleBackColor = true;
            this.btnEXC.Click += new System.EventHandler(this.btnEXC_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(323, 318);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 51);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(457, 318);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 51);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 404);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEXC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSubtra;
        private System.Windows.Forms.RadioButton radioSoma;
        private System.Windows.Forms.RadioButton radioParOuImpar;
        private System.Windows.Forms.RadioButton radioMulti;
        private System.Windows.Forms.RadioButton radioDividir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEXC;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}