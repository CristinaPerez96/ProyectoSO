namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Registro = new System.Windows.Forms.Button();
            this.Sesion = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Conectados = new System.Windows.Forms.Button();
            this.Cont = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(97, 223);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(103, 51);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registrarse";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // Sesion
            // 
            this.Sesion.Location = new System.Drawing.Point(265, 223);
            this.Sesion.Name = "Sesion";
            this.Sesion.Size = new System.Drawing.Size(103, 52);
            this.Sesion.TabIndex = 1;
            this.Sesion.Text = "Iniciar";
            this.Sesion.UseVisualStyleBackColor = true;
            this.Sesion.Click += new System.EventHandler(this.Sesion_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(177, 116);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(191, 22);
            this.user.TabIndex = 2;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(177, 177);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(191, 22);
            this.contraseña.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(48, 181);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(68, 17);
            this.password.TabIndex = 5;
            this.password.Text = "password";
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(236, 28);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(152, 47);
            this.Desconectar.TabIndex = 6;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(48, 27);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(152, 48);
            this.Conectar.TabIndex = 7;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(456, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(456, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(456, 178);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dame el nombre del jugador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "que ganó en menor tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dame el menor tiempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "en el que ganó \"usuario\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número de partidas ganadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "por el \"usuario\"";
            // 
            // Conectados
            // 
            this.Conectados.Location = new System.Drawing.Point(421, 344);
            this.Conectados.Name = "Conectados";
            this.Conectados.Size = new System.Drawing.Size(163, 76);
            this.Conectados.TabIndex = 18;
            this.Conectados.Text = "Ver conectados";
            this.Conectados.UseVisualStyleBackColor = true;
            this.Conectados.Click += new System.EventHandler(this.Conectados_Click);
            // 
            // Cont
            // 
            this.Cont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cont.Location = new System.Drawing.Point(482, 244);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(146, 67);
            this.Cont.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jugador});
            this.dataGridView1.Location = new System.Drawing.Point(97, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(271, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // Jugador
            // 
            this.Jugador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Jugador.HeaderText = "Jugador Conectado";
            this.Jugador.Name = "Jugador";
            this.Jugador.ReadOnly = true;
            this.Jugador.Width = 143;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cont);
            this.Controls.Add(this.Conectados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Sesion);
            this.Controls.Add(this.Registro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button Sesion;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Conectados;
        private System.Windows.Forms.Label Cont;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador;
    }
}

