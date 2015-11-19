using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FerreteriaSL
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Inicio));
            this.usuario = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.btn_inicioEntrar = new Button();
            this.btn_inicioSalir = new Button();
            this.contraseña = new TextBox();
            this.lbl_inicioAlerta = new Label();
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new Point(89, 17);
            this.usuario.Name = "usuario";
            this.usuario.Size = new Size(100, 20);
            this.usuario.TabIndex = 0;
            this.usuario.TextChanged += new EventHandler(this.usuario_TextChanged);
            this.usuario.KeyPress += new KeyPressEventHandler(this.usuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // btn_inicioEntrar
            // 
            this.btn_inicioEntrar.Location = new Point(57, 99);
            this.btn_inicioEntrar.Name = "btn_inicioEntrar";
            this.btn_inicioEntrar.Size = new Size(75, 23);
            this.btn_inicioEntrar.TabIndex = 4;
            this.btn_inicioEntrar.Text = "Ingresar";
            this.btn_inicioEntrar.UseVisualStyleBackColor = true;
            this.btn_inicioEntrar.Click += new EventHandler(this.btn_inicioEntrar_Click);
            // 
            // btn_inicioSalir
            // 
            this.btn_inicioSalir.Location = new Point(143, 99);
            this.btn_inicioSalir.Name = "btn_inicioSalir";
            this.btn_inicioSalir.Size = new Size(75, 23);
            this.btn_inicioSalir.TabIndex = 5;
            this.btn_inicioSalir.Text = "Salir";
            this.btn_inicioSalir.UseVisualStyleBackColor = true;
            this.btn_inicioSalir.Click += new EventHandler(this.btn_inicioSalir_Click);
            // 
            // contraseña
            // 
            this.contraseña.Location = new Point(89, 48);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new Size(100, 20);
            this.contraseña.TabIndex = 1;
            this.contraseña.KeyPress += new KeyPressEventHandler(this.contraseña_KeyPress);
            // 
            // lbl_inicioAlerta
            // 
            this.lbl_inicioAlerta.ForeColor = Color.Crimson;
            this.lbl_inicioAlerta.Location = new Point(17, 78);
            this.lbl_inicioAlerta.Name = "lbl_inicioAlerta";
            this.lbl_inicioAlerta.Size = new Size(240, 13);
            this.lbl_inicioAlerta.TabIndex = 6;
            this.lbl_inicioAlerta.TextAlign = ContentAlignment.MiddleCenter;
            this.lbl_inicioAlerta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pictureBox1.Location = new Point(206, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(51, 51);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DarkSeaGreen;
            this.ClientSize = new Size(275, 131);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_inicioAlerta);
            this.Controls.Add(this.btn_inicioSalir);
            this.Controls.Add(this.btn_inicioEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            ((ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usuario;
        private Label label1;
        private Label label2;
        private Button btn_inicioEntrar;
        private Button btn_inicioSalir;
        private TextBox contraseña;
        private Label lbl_inicioAlerta;
        private PictureBox pictureBox1;
    }
}

