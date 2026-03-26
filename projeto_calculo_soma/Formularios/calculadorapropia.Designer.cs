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
            this.lblVisor = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btno = new System.Windows.Forms.Button();
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
            this.btnvi = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnElev = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblVisor.Location = new System.Drawing.Point(12, 9);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(447, 74);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btno);
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
            this.flowLayoutPanel1.Controls.Add(this.btnvi);
            this.flowLayoutPanel1.Controls.Add(this.btn0);
            this.flowLayoutPanel1.Controls.Add(this.btnMM);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 463);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btno
            // 
            this.btno.Location = new System.Drawing.Point(202, 3);
            this.btno.Name = "btno";
            this.btno.Size = new System.Drawing.Size(93, 86);
            this.btno.TabIndex = 3;
            this.btno.Text = "<-";
            this.btno.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(103, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(93, 86);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(4, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(93, 86);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(202, 95);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 86);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(103, 95);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 86);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(4, 95);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 86);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(202, 187);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 86);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(103, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 86);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(4, 187);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 86);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(202, 279);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 86);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(103, 279);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 86);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.f_digitos);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(4, 279);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 86);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.f_digitos);
            // 
            // btnvi
            // 
            this.btnvi.Location = new System.Drawing.Point(202, 371);
            this.btnvi.Name = "btnvi";
            this.btnvi.Size = new System.Drawing.Size(93, 86);
            this.btnvi.TabIndex = 15;
            this.btnvi.Text = ",";
            this.btnvi.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(103, 371);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 86);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.f_digitos);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(4, 371);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(93, 86);
            this.btnMM.TabIndex = 17;
            this.btnMM.Text = "+/-";
            this.btnMM.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnMenos);
            this.flowLayoutPanel2.Controls.Add(this.btnMais);
            this.flowLayoutPanel2.Controls.Add(this.btnDivi);
            this.flowLayoutPanel2.Controls.Add(this.btnVezes);
            this.flowLayoutPanel2.Controls.Add(this.btnElev);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(331, 120);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(128, 457);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMenos.Location = new System.Drawing.Point(3, 3);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(125, 86);
            this.btnMenos.TabIndex = 0;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMais.Location = new System.Drawing.Point(3, 95);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(125, 86);
            this.btnMais.TabIndex = 1;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDivi.Location = new System.Drawing.Point(3, 187);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(125, 86);
            this.btnDivi.TabIndex = 2;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            // 
            // btnVezes
            // 
            this.btnVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVezes.Location = new System.Drawing.Point(3, 279);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(125, 86);
            this.btnVezes.TabIndex = 3;
            this.btnVezes.Text = "*";
            this.btnVezes.UseVisualStyleBackColor = true;
            // 
            // btnElev
            // 
            this.btnElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnElev.Location = new System.Drawing.Point(3, 371);
            this.btnElev.Name = "btnElev";
            this.btnElev.Size = new System.Drawing.Size(125, 86);
            this.btnElev.TabIndex = 4;
            this.btnElev.Text = "^";
            this.btnElev.UseVisualStyleBackColor = true;
            this.btnElev.Click += new System.EventHandler(this.button17_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnIgual);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(16, 589);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(447, 64);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnIgual.Location = new System.Drawing.Point(3, 3);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(440, 48);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // calculadorapropia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 665);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "calculadorapropia";
            this.Text = "calculadorapropia";
            this.Click += new System.EventHandler(this.f_digitos);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btno;
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
        private System.Windows.Forms.Button btnvi;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnIgual;
    }
}