namespace FolhaPagamento
{
    partial class frmFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.cbbClubeSaude = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(48, 32);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(105, 20);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da folha";
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(48, 272);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(110, 20);
            this.lblClubeLazer.TabIndex = 1;
            this.lblClubeLazer.Text = "Clube de lazer";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(326, 190);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(107, 20);
            this.lblSalarioLiquido.TabIndex = 2;
            this.lblSalarioLiquido.Text = "Salário liquído";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(299, 124);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(134, 20);
            this.lblImpostoRenda.TabIndex = 3;
            this.lblImpostoRenda.Text = "Imposto de renda";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(336, 51);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(97, 20);
            this.lblSalarioFolha.TabIndex = 4;
            this.lblSalarioFolha.Text = "Salário folha";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(48, 106);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(58, 20);
            this.lblSalarioBruto.TabIndex = 6;
            this.lblSalarioBruto.Text = "Salário";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(48, 130);
            this.txtSalarioBruto.MaxLength = 10;
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(138, 26);
            this.txtSalarioBruto.TabIndex = 1;
            this.txtSalarioBruto.TextChanged += new System.EventHandler(this.txtSalarioBruto_TextChanged);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(443, 187);
            this.txtSalarioLiquido.MaxLength = 10;
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioLiquido.TabIndex = 6;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoRenda.Location = new System.Drawing.Point(443, 121);
            this.txtImpostoRenda.MaxLength = 10;
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(100, 26);
            this.txtImpostoRenda.TabIndex = 5;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFolha.Location = new System.Drawing.Point(443, 48);
            this.txtSalarioFolha.MaxLength = 10;
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioFolha.TabIndex = 4;
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(48, 57);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(113, 26);
            this.dtpDataFolha.TabIndex = 0;
            this.dtpDataFolha.TabStop = false;
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlanoSaude.Location = new System.Drawing.Point(48, 197);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(138, 24);
            this.ckbPlanoSaude.TabIndex = 2;
            this.ckbPlanoSaude.Text = "Plano de saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // cbbClubeSaude
            // 
            this.cbbClubeSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClubeSaude.FormattingEnabled = true;
            this.cbbClubeSaude.Location = new System.Drawing.Point(48, 295);
            this.cbbClubeSaude.Name = "cbbClubeSaude";
            this.cbbClubeSaude.Size = new System.Drawing.Size(181, 28);
            this.cbbClubeSaude.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(398, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(145, 41);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(398, 326);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(145, 41);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(398, 279);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 41);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 405);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbbClubeSaude);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.lblDataFolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo de caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.ComboBox cbbClubeSaude;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}