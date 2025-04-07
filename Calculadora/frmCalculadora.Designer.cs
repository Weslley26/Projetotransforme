namespace Calculadora
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblReposta = new System.Windows.Forms.Label();
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(40, 32);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(78, 20);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1";
          
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.Location = new System.Drawing.Point(40, 115);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(78, 20);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(40, 55);
            this.txtNumero1.MaxLength = 10;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 26);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(40, 138);
            this.txtNumero2.MaxLength = 10;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 26);
            this.txtNumero2.TabIndex = 1;
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(40, 229);
            this.txtResposta.MaxLength = 10;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 26);
            this.txtResposta.TabIndex = 5;
            // 
            // lblReposta
            // 
            this.lblReposta.AutoSize = true;
            this.lblReposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReposta.Location = new System.Drawing.Point(40, 203);
            this.lblReposta.Name = "lblReposta";
            this.lblReposta.Size = new System.Drawing.Size(78, 20);
            this.lblReposta.TabIndex = 4;
            this.lblReposta.Text = "Resposta";
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.rdbDividir);
            this.gpbOperacoes.Controls.Add(this.rdbMultiplicar);
            this.gpbOperacoes.Controls.Add(this.rdbSubtrair);
            this.gpbOperacoes.Controls.Add(this.rdbSomar);
            this.gpbOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperacoes.Location = new System.Drawing.Point(233, 32);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Size = new System.Drawing.Size(200, 223);
            this.gpbOperacoes.TabIndex = 2;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(42, 170);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(69, 24);
            this.rdbDividir.TabIndex = 6;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(41, 127);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(97, 24);
            this.rdbMultiplicar.TabIndex = 5;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(41, 84);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(83, 24);
            this.rdbSubtrair.TabIndex = 4;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(42, 45);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(74, 24);
            this.rdbSomar.TabIndex = 3;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(497, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 57);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(497, 115);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(157, 57);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(497, 198);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(157, 57);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 309);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbOperacoes);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblReposta);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblReposta;
        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

