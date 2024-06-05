namespace ProjetoPorcentagemSalario
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDiasTrabalhados = new System.Windows.Forms.TextBox();
            this.txtValorDaDiaria = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultadoBase = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblResultadoValorIR = new System.Windows.Forms.Label();
            this.lblResultadoValorLiquido = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 164);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtDiasTrabalhados
            // 
            this.txtDiasTrabalhados.Location = new System.Drawing.Point(200, 203);
            this.txtDiasTrabalhados.Name = "txtDiasTrabalhados";
            this.txtDiasTrabalhados.Size = new System.Drawing.Size(100, 23);
            this.txtDiasTrabalhados.TabIndex = 2;
            // 
            // txtValorDaDiaria
            // 
            this.txtValorDaDiaria.Location = new System.Drawing.Point(200, 242);
            this.txtValorDaDiaria.Name = "txtValorDaDiaria";
            this.txtValorDaDiaria.Size = new System.Drawing.Size(100, 23);
            this.txtValorDaDiaria.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(330, 241);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultadoBase
            // 
            this.lblResultadoBase.AutoSize = true;
            this.lblResultadoBase.Location = new System.Drawing.Point(208, 280);
            this.lblResultadoBase.Name = "lblResultadoBase";
            this.lblResultadoBase.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoBase.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(200, 124);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.ValidatingType = typeof(System.DateTime);
            // 
            // lblResultadoValorIR
            // 
            this.lblResultadoValorIR.AutoSize = true;
            this.lblResultadoValorIR.Location = new System.Drawing.Point(208, 311);
            this.lblResultadoValorIR.Name = "lblResultadoValorIR";
            this.lblResultadoValorIR.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoValorIR.TabIndex = 7;
            // 
            // lblResultadoValorLiquido
            // 
            this.lblResultadoValorLiquido.AutoSize = true;
            this.lblResultadoValorLiquido.Location = new System.Drawing.Point(208, 336);
            this.lblResultadoValorLiquido.Name = "lblResultadoValorLiquido";
            this.lblResultadoValorLiquido.Size = new System.Drawing.Size(0, 15);
            this.lblResultadoValorLiquido.TabIndex = 8;
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(160, 127);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(28, 15);
            this.CPF.TabIndex = 9;
            this.CPF.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dias Trabalhados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor Diario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor IR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Salario Liquido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.lblResultadoValorLiquido);
            this.Controls.Add(this.lblResultadoValorIR);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblResultadoBase);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorDaDiaria);
            this.Controls.Add(this.txtDiasTrabalhados);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNome;
        private TextBox txtDiasTrabalhados;
        private TextBox txtValorDaDiaria;
        private Button btnCalcular;
        private Label lblResultadoBase;
        private MaskedTextBox txtCPF;
        private Label lblResultadoValorIR;
        private Label lblResultadoValorLiquido;
        private Label CPF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}