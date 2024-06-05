namespace WinFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblColoqueValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotemperatura = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSAO TEMPERATURA";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(309, 124);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblColoqueValor
            // 
            this.lblColoqueValor.AutoSize = true;
            this.lblColoqueValor.Location = new System.Drawing.Point(311, 107);
            this.lblColoqueValor.Name = "lblColoqueValor";
            this.lblColoqueValor.Size = new System.Drawing.Size(129, 15);
            this.lblColoqueValor.TabIndex = 2;
            this.lblColoqueValor.Text = "Coloque a temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escolha qual você deseja";
            // 
            // cbotemperatura
            // 
            this.cbotemperatura.FormattingEnabled = true;
            this.cbotemperatura.Items.AddRange(new object[] {
            "Celsius > Fahrenheit",
            "Fahrenheit > Celsius"});
            this.cbotemperatura.Location = new System.Drawing.Point(303, 221);
            this.cbotemperatura.Name = "cbotemperatura";
            this.cbotemperatura.Size = new System.Drawing.Size(121, 23);
            this.cbotemperatura.TabIndex = 4;
            this.cbotemperatura.SelectedIndexChanged += new System.EventHandler(this.cbotemperatura_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(301, 313);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(38, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(484, 297);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Converter";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cbotemperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblColoqueValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Label lblColoqueValor;
        private Label label2;
        private ComboBox cbotemperatura;
        private Label lblResultado;
        private Button btnResultado;
    }
}