namespace AULA07
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
            this.ir = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblListaTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.listtelefones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ir)).BeginInit();
            this.SuspendLayout();
            // 
            // ir
            // 
            this.ir.Image = global::AULA07.Properties.Resources.logo;
            this.ir.Location = new System.Drawing.Point(12, 12);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(100, 81);
            this.ir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ir.TabIndex = 0;
            this.ir.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(150, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(319, 111);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblListaTelefone
            // 
            this.lblListaTelefone.AutoSize = true;
            this.lblListaTelefone.Location = new System.Drawing.Point(150, 183);
            this.lblListaTelefone.Name = "lblListaTelefone";
            this.lblListaTelefone.Size = new System.Drawing.Size(99, 15);
            this.lblListaTelefone.TabIndex = 3;
            this.lblListaTelefone.Text = "Lista de Telefones";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(376, 108);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(517, 107);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(517, 351);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAgenda.CausesValidation = false;
            this.lblAgenda.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgenda.Location = new System.Drawing.Point(208, 28);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(374, 50);
            this.lblAgenda.TabIndex = 9;
            this.lblAgenda.Text = "AGENDA UNISANTA";
            // 
            // listtelefones
            // 
            this.listtelefones.FormattingEnabled = true;
            this.listtelefones.ItemHeight = 15;
            this.listtelefones.Location = new System.Drawing.Point(163, 213);
            this.listtelefones.Name = "listtelefones";
            this.listtelefones.Size = new System.Drawing.Size(419, 124);
            this.listtelefones.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listtelefones);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblListaTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ir;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblListaTelefone;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Button btnIncluir;
        private Button btnListar;
        private Label lblAgenda;
        private ListBox listtelefones;
    }
}