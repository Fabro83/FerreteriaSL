namespace FerreteriaSL
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_inicioEntrar = new System.Windows.Forms.Button();
            this.btn_inicioSalir = new System.Windows.Forms.Button();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.lbl_inicioAlerta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(89, 17);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 0;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            this.usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // btn_inicioEntrar
            // 
            this.btn_inicioEntrar.Location = new System.Drawing.Point(57, 99);
            this.btn_inicioEntrar.Name = "btn_inicioEntrar";
            this.btn_inicioEntrar.Size = new System.Drawing.Size(75, 23);
            this.btn_inicioEntrar.TabIndex = 4;
            this.btn_inicioEntrar.Text = "Ingresar";
            this.btn_inicioEntrar.UseVisualStyleBackColor = true;
            this.btn_inicioEntrar.Click += new System.EventHandler(this.btn_inicioEntrar_Click);
            // 
            // btn_inicioSalir
            // 
            this.btn_inicioSalir.Location = new System.Drawing.Point(143, 99);
            this.btn_inicioSalir.Name = "btn_inicioSalir";
            this.btn_inicioSalir.Size = new System.Drawing.Size(75, 23);
            this.btn_inicioSalir.TabIndex = 5;
            this.btn_inicioSalir.Text = "Salir";
            this.btn_inicioSalir.UseVisualStyleBackColor = true;
            this.btn_inicioSalir.Click += new System.EventHandler(this.btn_inicioSalir_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(89, 48);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 1;
            this.contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contraseña_KeyPress);
            // 
            // lbl_inicioAlerta
            // 
            this.lbl_inicioAlerta.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_inicioAlerta.Location = new System.Drawing.Point(17, 78);
            this.lbl_inicioAlerta.Name = "lbl_inicioAlerta";
            this.lbl_inicioAlerta.Size = new System.Drawing.Size(240, 13);
            this.lbl_inicioAlerta.TabIndex = 6;
            this.lbl_inicioAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_inicioAlerta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(206, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(275, 131);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_inicioAlerta);
            this.Controls.Add(this.btn_inicioSalir);
            this.Controls.Add(this.btn_inicioEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_inicioEntrar;
        private System.Windows.Forms.Button btn_inicioSalir;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label lbl_inicioAlerta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

