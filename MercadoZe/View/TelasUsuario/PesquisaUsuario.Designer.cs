namespace MercadoZe.View.TelasUsuario
{
	partial class PesquisaUsuario
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_Buscar = new Button();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(155, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 47);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar Usuário";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(629, 379);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(621, 351);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buscar por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btn_Buscar);
            tabPage2.Controls.Add(txtNomeCliente);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(621, 351);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por Usuario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 265);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(69, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 29);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(69, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 29);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 200);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 4;
            label6.Text = "Ultimo Acesso";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Caixa", "Atendente" });
            comboBox1.Location = new Point(57, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(381, 23);
            comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 141);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 2;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 92);
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
            btn_Buscar.Location = new Point(343, 26);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 20;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(120, 20);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(197, 29);
            txtNomeCliente.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 18;
            label2.Text = "Matricula";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 30);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 0;
            label10.Text = "Nome :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 90);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 1;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 141);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 2;
            label8.Text = "Tipo";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Gerente", "Caixa", "Atendente" });
            comboBox2.Location = new Point(20, 165);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 191);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 4;
            label7.Text = "Senha";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(69, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(151, 29);
            textBox5.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(297, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(69, 92);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 29);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(7, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(123, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 247);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(130, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 29);
            textBox6.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(366, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // PesquisaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "PesquisaUsuario";
            Text = "PesquisaUsuario";
            Load += PesquisaUsuario_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private GroupBox groupBox1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label6;
		private ComboBox comboBox1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Button btn_Buscar;
		private TextBox txtNomeCliente;
		private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Button button2;
    }
}