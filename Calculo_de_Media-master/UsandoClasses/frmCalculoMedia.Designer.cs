namespace UsandoClasses
{
    partial class frmCalculoMedia
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(124, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(371, 39);
            this.txtNome.TabIndex = 2;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(124, 147);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(115, 39);
            this.txtP1.TabIndex = 3;
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "P1";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(380, 150);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(115, 39);
            this.txtP2.TabIndex = 4;
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "P2";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(557, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 59);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(285, 221);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(115, 39);
            this.txtMedia.TabIndex = 8;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(201, 224);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(81, 32);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.Text = "Média";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(124, 27);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(158, 39);
            this.txtRA.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "RA";
            // 
            // frmCalculoMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 299);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculoMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo da Media";
            this.Load += new System.EventHandler(this.frmCalculoMedia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtP1;
        private Label label2;
        private TextBox txtP2;
        private Label label3;
        private Button btnCalcular;
        private TextBox txtMedia;
        private Label lblMedia;
        private TextBox txtRA;
        private Label label5;
    }
}