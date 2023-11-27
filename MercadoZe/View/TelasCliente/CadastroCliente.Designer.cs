namespace MercadoZe.View.TelasCliente
{
    partial class CadastroCliente
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtNomeCliente = new TextBox();
			TxtEmailCliente = new TextBox();
			Bnt_Cadastro = new Button();
			NumeroCelular = new MaskedTextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(190, 9);
			label1.Name = "label1";
			label1.Size = new Size(194, 25);
			label1.TabIndex = 0;
			label1.Text = "Cadastro de Cliente";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(85, 71);
			label2.Name = "label2";
			label2.Size = new Size(68, 30);
			label2.TabIndex = 1;
			label2.Text = "Nome";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(85, 144);
			label3.Name = "label3";
			label3.Size = new Size(62, 30);
			label3.TabIndex = 2;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(85, 235);
			label4.Name = "label4";
			label4.Size = new Size(76, 30);
			label4.TabIndex = 3;
			label4.Text = "Celular";
			// 
			// txtNomeCliente
			// 
			txtNomeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNomeCliente.Location = new Point(85, 104);
			txtNomeCliente.Name = "txtNomeCliente";
			txtNomeCliente.Size = new Size(331, 29);
			txtNomeCliente.TabIndex = 4;
			txtNomeCliente.TextChanged += textBox1_TextChanged;
			// 
			// TxtEmailCliente
			// 
			TxtEmailCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			TxtEmailCliente.Location = new Point(85, 177);
			TxtEmailCliente.Name = "TxtEmailCliente";
			TxtEmailCliente.Size = new Size(331, 29);
			TxtEmailCliente.TabIndex = 5;
			// 
			// Bnt_Cadastro
			// 
			Bnt_Cadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
			Bnt_Cadastro.Location = new Point(222, 364);
			Bnt_Cadastro.Name = "Bnt_Cadastro";
			Bnt_Cadastro.Size = new Size(130, 34);
			Bnt_Cadastro.TabIndex = 7;
			Bnt_Cadastro.Text = "Cadastrar";
			Bnt_Cadastro.UseVisualStyleBackColor = true;
			Bnt_Cadastro.Click += Bnt_Cadastro_Click;
			// 
			// NumeroCelular
			// 
			NumeroCelular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			NumeroCelular.Location = new Point(85, 268);
			NumeroCelular.Mask = "(999) 000-0000";
			NumeroCelular.Name = "NumeroCelular";
			NumeroCelular.Size = new Size(156, 29);
			NumeroCelular.TabIndex = 8;
			// 
			// CadastroCliente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			ClientSize = new Size(574, 450);
			Controls.Add(NumeroCelular);
			Controls.Add(Bnt_Cadastro);
			Controls.Add(TxtEmailCliente);
			Controls.Add(txtNomeCliente);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "CadastroCliente";
			Text = "CadastroCliente";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNomeCliente;
        private TextBox TxtEmailCliente;
        private Button Bnt_Cadastro;
        private MaskedTextBox NumeroCelular;
    }
}