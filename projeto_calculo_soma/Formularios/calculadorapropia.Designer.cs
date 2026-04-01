namespace projeto_calculo_soma.Formularios
{
    partial class calculadorapropia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadorapropia));
            this.lblVisor = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnElev = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_iGual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
            this.lblVisor.Location = new System.Drawing.Point(11, 7);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(385, 86);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBack);
            this.flowLayoutPanel1.Controls.Add(this.btnCE);
            this.flowLayoutPanel1.Controls.Add(this.btnC);
            this.flowLayoutPanel1.Controls.Add(this.btn9);
            this.flowLayoutPanel1.Controls.Add(this.btn8);
            this.flowLayoutPanel1.Controls.Add(this.btn7);
            this.flowLayoutPanel1.Controls.Add(this.btn6);
            this.flowLayoutPanel1.Controls.Add(this.btn5);
            this.flowLayoutPanel1.Controls.Add(this.btn4);
            this.flowLayoutPanel1.Controls.Add(this.btn3);
            this.flowLayoutPanel1.Controls.Add(this.btn2);
            this.flowLayoutPanel1.Controls.Add(this.btn1);
            this.flowLayoutPanel1.Controls.Add(this.btnVirgula);
            this.flowLayoutPanel1.Controls.Add(this.btn0);
            this.flowLayoutPanel1.Controls.Add(this.btnMM);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 96);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 370);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.Location = new System.Drawing.Point(187, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 69);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCE.Location = new System.Drawing.Point(98, 2);
            this.btnCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(83, 69);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnC.Location = new System.Drawing.Point(9, 2);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(83, 69);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn9.Location = new System.Drawing.Point(187, 75);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(83, 69);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn8.Location = new System.Drawing.Point(98, 75);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(83, 69);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn7.Location = new System.Drawing.Point(9, 75);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(83, 69);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn6.Location = new System.Drawing.Point(187, 148);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(83, 69);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn5.Location = new System.Drawing.Point(98, 148);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(83, 69);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn4.Location = new System.Drawing.Point(9, 148);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(83, 69);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn3.Location = new System.Drawing.Point(187, 221);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(83, 69);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn2.Location = new System.Drawing.Point(98, 221);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 69);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1.Location = new System.Drawing.Point(9, 221);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 69);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.f_digitos);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVirgula.Location = new System.Drawing.Point(187, 294);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(83, 69);
            this.btnVirgula.TabIndex = 15;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn0.Location = new System.Drawing.Point(98, 294);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(83, 69);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.f_digitos);
            // 
            // btnMM
            // 
            this.btnMM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMM.Location = new System.Drawing.Point(9, 294);
            this.btnMM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(83, 69);
            this.btnMM.TabIndex = 17;
            this.btnMM.Text = "+/-";
            this.btnMM.UseVisualStyleBackColor = false;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnMenos);
            this.flowLayoutPanel2.Controls.Add(this.btnMais);
            this.flowLayoutPanel2.Controls.Add(this.btnDivi);
            this.flowLayoutPanel2.Controls.Add(this.btnVezes);
            this.flowLayoutPanel2.Controls.Add(this.btnElev);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(282, 96);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 370);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMenos.Location = new System.Drawing.Point(3, 2);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(111, 69);
            this.btnMenos.TabIndex = 0;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMais.Location = new System.Drawing.Point(3, 75);
            this.btnMais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(111, 69);
            this.btnMais.TabIndex = 1;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnDivi
            // 
            this.btnDivi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDivi.Location = new System.Drawing.Point(3, 148);
            this.btnDivi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(111, 69);
            this.btnDivi.TabIndex = 2;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = false;
            this.btnDivi.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVezes.Location = new System.Drawing.Point(3, 221);
            this.btnVezes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(111, 69);
            this.btnVezes.TabIndex = 3;
            this.btnVezes.Text = "*";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnElev
            // 
            this.btnElev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnElev.Location = new System.Drawing.Point(3, 294);
            this.btnElev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElev.Name = "btnElev";
            this.btnElev.Size = new System.Drawing.Size(111, 69);
            this.btnElev.TabIndex = 4;
            this.btnElev.Text = "^";
            this.btnElev.UseVisualStyleBackColor = false;
            this.btnElev.Click += new System.EventHandler(this.f_operacoes);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btn_iGual);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 471);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(393, 51);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // lblHistorico
            // 
            this.lblHistorico.Location = new System.Drawing.Point(307, 7);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(89, 18);
            this.lblHistorico.TabIndex = 4;
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btn_iGual
            // 
            this.btn_iGual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_iGual.Location = new System.Drawing.Point(3, 3);
            this.btn_iGual.Name = "btn_iGual";
            this.btn_iGual.Size = new System.Drawing.Size(390, 48);
            this.btn_iGual.TabIndex = 0;
            this.btn_iGual.Text = "=";
            this.btn_iGual.UseVisualStyleBackColor = true;
            this.btn_iGual.Click += new System.EventHandler(this.btn_iGual_Click);
            // 
            // calculadorapropia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(402, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calculadorapropia";
            this.Text = "calculadorapropia";
            this.Load += new System.EventHandler(this.calculadorapropia_Load);
            this.Shown += new System.EventHandler(this.calculadorapropia_Shown);
            this.Click += new System.EventHandler(this.f_digitos);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadorapropia_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnElev;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iGual;
    }
}