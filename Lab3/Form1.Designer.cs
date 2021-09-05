
namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(33, 56);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(201, 23);
            this.txtServidor.TabIndex = 1;
            // 
            // txtBD
            // 
            this.txtBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBD.Location = new System.Drawing.Point(33, 125);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(201, 23);
            this.txtBD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de datos";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(295, 125);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(201, 23);
            this.txtContraseña.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(295, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuario";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Autenticacion Integrada";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(117, 206);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(89, 25);
            this.btnConectar.TabIndex = 9;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Location = new System.Drawing.Point(212, 206);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(98, 25);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(316, 206);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(123, 25);
            this.btnDesconectar.TabIndex = 11;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersona.Location = new System.Drawing.Point(445, 206);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(89, 25);
            this.btnPersona.TabIndex = 12;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 243);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conexión a un origen de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnPersona;
    }
}

