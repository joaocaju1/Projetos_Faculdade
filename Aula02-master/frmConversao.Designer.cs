namespace Aula02
{
    partial class frmConversao
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
            this.cboTipoConversao = new System.Windows.Forms.ComboBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorOriginal = new System.Windows.Forms.TextBox();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboTipoConversao
            // 
            this.cboTipoConversao.FormattingEnabled = true;
            this.cboTipoConversao.Items.AddRange(new object[] {
            "Kilo -> Libra",
            "Libra ->Kilo"});
            this.cboTipoConversao.Location = new System.Drawing.Point(48, 162);
            this.cboTipoConversao.Name = "cboTipoConversao";
            this.cboTipoConversao.Size = new System.Drawing.Size(283, 49);
            this.cboTipoConversao.TabIndex = 0;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(367, 161);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(170, 50);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor para converter: ";
            // 
            // txtValorOriginal
            // 
            this.txtValorOriginal.Location = new System.Drawing.Point(367, 94);
            this.txtValorOriginal.Name = "txtValorOriginal";
            this.txtValorOriginal.Size = new System.Drawing.Size(170, 47);
            this.txtValorOriginal.TabIndex = 3;
            this.txtValorOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.Location = new System.Drawing.Point(367, 248);
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.ReadOnly = true;
            this.txtValorConvertido.Size = new System.Drawing.Size(170, 47);
            this.txtValorConvertido.TabIndex = 5;
            this.txtValorConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor convertido: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(523, 49);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Conversao de Medidas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 355);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtValorConvertido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cboTipoConversao);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConversao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversao de medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboTipoConversao;
        private Button btnConverter;
        private Label label1;
        private TextBox txtValorOriginal;
        private TextBox txtValorConvertido;
        private Label label2;
        private Label lblTitulo;
    }
}