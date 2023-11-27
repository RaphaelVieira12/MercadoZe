namespace MercadoZe.View.TelasUsuario
{
	partial class DeletaUsuario
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
            groupBox1 = new GroupBox();
            tbxEmail = new TextBox();
            btn_Excluir = new Button();
            tbxNome = new TextBox();
            cbx_TipoUsuario = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_Buscar = new Button();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 20);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 0;
            label1.Text = "Excluir Usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxEmail);
            groupBox1.Controls.Add(btn_Excluir);
            groupBox1.Controls.Add(tbxNome);
            groupBox1.Controls.Add(cbx_TipoUsuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(23, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 233);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxEmail.Location = new Point(69, 92);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(151, 29);
            tbxEmail.TabIndex = 6;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Location = new Point(325, 191);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(75, 23);
            btn_Excluir.TabIndex = 15;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // tbxNome
            // 
            tbxNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNome.Location = new Point(69, 27);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(151, 29);
            tbxNome.TabIndex = 5;
            // 
            // cbx_TipoUsuario
            // 
            cbx_TipoUsuario.FormattingEnabled = true;
            cbx_TipoUsuario.Items.AddRange(new object[] { "Gerente", "Caixa", "Atendente" });
            cbx_TipoUsuario.Location = new Point(20, 165);
            cbx_TipoUsuario.Name = "cbx_TipoUsuario";
            cbx_TipoUsuario.Size = new Size(121, 23);
            cbx_TipoUsuario.TabIndex = 3;
            cbx_TipoUsuario.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 141);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 2;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 90);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 1;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 0;
            label3.Text = "Nome :";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(266, 131);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 20;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(30, 125);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(197, 29);
            txtNomeCliente.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(275, 30);
            label2.TabIndex = 18;
            label2.Text = "Digite a Matricula do Usuário";
            // 
            // DeletaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 418);
            Controls.Add(groupBox1);
            Controls.Add(btn_Buscar);
            Controls.Add(txtNomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeletaUsuario";
            Text = "DeletaUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private GroupBox groupBox1;
		private TextBox tbxEmail;
		private Button btn_Excluir;
		private TextBox tbxNome;
		private ComboBox cbx_TipoUsuario;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button btn_Buscar;
		private TextBox txtNomeCliente;
		private Label label2;
	}
}