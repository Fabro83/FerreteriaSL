namespace FerreteriaSL
{
    partial class AplicarFuncionPrecio
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
            this.cb_funcionesGuardas = new System.Windows.Forms.ComboBox();
            this.lbl_funcion = new System.Windows.Forms.Label();
            this.tb_funcion = new System.Windows.Forms.TextBox();
            this.btn_cargarFuncion = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_precioOrigen = new System.Windows.Forms.Label();
            this.lbl_precioDestino = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_preciosDeMuestra = new System.Windows.Forms.GroupBox();
            this.lbl_precioDestinoValor = new System.Windows.Forms.Label();
            this.btn_probarFuncion = new System.Windows.Forms.Button();
            this.btn_eliminarFuncion = new System.Windows.Forms.Button();
            this.pb_aplicarFormula = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_ayuda = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_preciosDeMuestra.SuspendLayout();
            this.gb_ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_funcionesGuardas
            // 
            this.cb_funcionesGuardas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_funcionesGuardas.FormattingEnabled = true;
            this.cb_funcionesGuardas.Location = new System.Drawing.Point(112, 66);
            this.cb_funcionesGuardas.Name = "cb_funcionesGuardas";
            this.cb_funcionesGuardas.Size = new System.Drawing.Size(227, 21);
            this.cb_funcionesGuardas.TabIndex = 0;
            this.cb_funcionesGuardas.SelectedIndexChanged += new System.EventHandler(this.cb_funcionesGuardas_SelectedIndexChanged);
            // 
            // lbl_funcion
            // 
            this.lbl_funcion.AutoSize = true;
            this.lbl_funcion.Location = new System.Drawing.Point(14, 14);
            this.lbl_funcion.Name = "lbl_funcion";
            this.lbl_funcion.Size = new System.Drawing.Size(92, 13);
            this.lbl_funcion.TabIndex = 1;
            this.lbl_funcion.Text = "Funcion a Aplicar:";
            // 
            // tb_funcion
            // 
            this.tb_funcion.Location = new System.Drawing.Point(112, 10);
            this.tb_funcion.Name = "tb_funcion";
            this.tb_funcion.Size = new System.Drawing.Size(227, 20);
            this.tb_funcion.TabIndex = 2;
            this.tb_funcion.TextChanged += new System.EventHandler(this.tb_funcion_TextChanged);
            // 
            // btn_cargarFuncion
            // 
            this.btn_cargarFuncion.Enabled = false;
            this.btn_cargarFuncion.Location = new System.Drawing.Point(112, 37);
            this.btn_cargarFuncion.Name = "btn_cargarFuncion";
            this.btn_cargarFuncion.Size = new System.Drawing.Size(106, 23);
            this.btn_cargarFuncion.TabIndex = 3;
            this.btn_cargarFuncion.Text = "Cargar Funcion";
            this.btn_cargarFuncion.UseVisualStyleBackColor = true;
            this.btn_cargarFuncion.Click += new System.EventHandler(this.btn_insertarFuncion_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Location = new System.Drawing.Point(232, 37);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(107, 23);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar Funcion";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_precioOrigen
            // 
            this.lbl_precioOrigen.AutoSize = true;
            this.lbl_precioOrigen.Location = new System.Drawing.Point(6, 21);
            this.lbl_precioOrigen.Name = "lbl_precioOrigen";
            this.lbl_precioOrigen.Size = new System.Drawing.Size(85, 13);
            this.lbl_precioOrigen.TabIndex = 5;
            this.lbl_precioOrigen.Text = "Precio de ******: ";
            // 
            // lbl_precioDestino
            // 
            this.lbl_precioDestino.AutoSize = true;
            this.lbl_precioDestino.Location = new System.Drawing.Point(6, 42);
            this.lbl_precioDestino.Name = "lbl_precioDestino";
            this.lbl_precioDestino.Size = new System.Drawing.Size(121, 13);
            this.lbl_precioDestino.TabIndex = 6;
            this.lbl_precioDestino.Text = "Nuevo Precio de *******:";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(346, 9);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(23, 23);
            this.btn_ayuda.TabIndex = 7;
            this.btn_ayuda.Text = "?";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Enabled = false;
            this.btn_aplicar.Location = new System.Drawing.Point(113, 207);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_aplicar.TabIndex = 8;
            this.btn_aplicar.Text = "Aplicar";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(201, 207);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gb_preciosDeMuestra
            // 
            this.gb_preciosDeMuestra.Controls.Add(this.lbl_precioDestinoValor);
            this.gb_preciosDeMuestra.Controls.Add(this.lbl_precioOrigen);
            this.gb_preciosDeMuestra.Controls.Add(this.lbl_precioDestino);
            this.gb_preciosDeMuestra.Location = new System.Drawing.Point(17, 133);
            this.gb_preciosDeMuestra.Name = "gb_preciosDeMuestra";
            this.gb_preciosDeMuestra.Size = new System.Drawing.Size(352, 65);
            this.gb_preciosDeMuestra.TabIndex = 10;
            this.gb_preciosDeMuestra.TabStop = false;
            this.gb_preciosDeMuestra.Text = "Vista Anticipada";
            // 
            // lbl_precioDestinoValor
            // 
            this.lbl_precioDestinoValor.AutoSize = true;
            this.lbl_precioDestinoValor.Location = new System.Drawing.Point(130, 42);
            this.lbl_precioDestinoValor.Name = "lbl_precioDestinoValor";
            this.lbl_precioDestinoValor.Size = new System.Drawing.Size(0, 13);
            this.lbl_precioDestinoValor.TabIndex = 7;
            // 
            // btn_probarFuncion
            // 
            this.btn_probarFuncion.Enabled = false;
            this.btn_probarFuncion.Location = new System.Drawing.Point(17, 37);
            this.btn_probarFuncion.Name = "btn_probarFuncion";
            this.btn_probarFuncion.Size = new System.Drawing.Size(75, 80);
            this.btn_probarFuncion.TabIndex = 11;
            this.btn_probarFuncion.Text = "Probar Función";
            this.btn_probarFuncion.UseVisualStyleBackColor = true;
            this.btn_probarFuncion.Click += new System.EventHandler(this.btn_probarFuncion_Click);
            // 
            // btn_eliminarFuncion
            // 
            this.btn_eliminarFuncion.Location = new System.Drawing.Point(113, 94);
            this.btn_eliminarFuncion.Name = "btn_eliminarFuncion";
            this.btn_eliminarFuncion.Size = new System.Drawing.Size(226, 23);
            this.btn_eliminarFuncion.TabIndex = 12;
            this.btn_eliminarFuncion.Text = "Eliminar Función Guardada";
            this.btn_eliminarFuncion.UseVisualStyleBackColor = true;
            this.btn_eliminarFuncion.Click += new System.EventHandler(this.btn_eliminarFuncion_Click);
            // 
            // pb_aplicarFormula
            // 
            this.pb_aplicarFormula.Location = new System.Drawing.Point(210, 235);
            this.pb_aplicarFormula.Name = "pb_aplicarFormula";
            this.pb_aplicarFormula.Size = new System.Drawing.Size(75, 13);
            this.pb_aplicarFormula.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_aplicarFormula.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Aplicando Formula...";
            // 
            // gb_ayuda
            // 
            this.gb_ayuda.Controls.Add(this.label8);
            this.gb_ayuda.Controls.Add(this.label7);
            this.gb_ayuda.Controls.Add(this.label6);
            this.gb_ayuda.Controls.Add(this.label5);
            this.gb_ayuda.Controls.Add(this.label4);
            this.gb_ayuda.Controls.Add(this.label3);
            this.gb_ayuda.Controls.Add(this.label2);
            this.gb_ayuda.Location = new System.Drawing.Point(392, 9);
            this.gb_ayuda.Name = "gb_ayuda";
            this.gb_ayuda.Size = new System.Drawing.Size(198, 221);
            this.gb_ayuda.TabIndex = 15;
            this.gb_ayuda.TabStop = false;
            this.gb_ayuda.Text = "Ayuda";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Los numeros decimales deben ser escritos con un punto en vez de coma.";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 39);
            this.label7.TabIndex = 5;
            this.label7.Text = "La variable ?P es el precio de venta/compra a ser utilizado en la función.";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Se pueden utilizar parentesis para separar términos en la función.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "/ (Barra Invertida) = División.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "+ (Signo más) = Suma.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "- (Guión Medio) = Resta.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "* (Asterisco) = Multiplicación.";
            // 
            // AplicarFuncionPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 233);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ayuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_aplicarFormula);
            this.Controls.Add(this.btn_eliminarFuncion);
            this.Controls.Add(this.btn_probarFuncion);
            this.Controls.Add(this.gb_preciosDeMuestra);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aplicar);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cargarFuncion);
            this.Controls.Add(this.tb_funcion);
            this.Controls.Add(this.lbl_funcion);
            this.Controls.Add(this.cb_funcionesGuardas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AplicarFuncionPrecio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Función Precio";
            this.gb_preciosDeMuestra.ResumeLayout(false);
            this.gb_preciosDeMuestra.PerformLayout();
            this.gb_ayuda.ResumeLayout(false);
            this.gb_ayuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_funcionesGuardas;
        private System.Windows.Forms.Label lbl_funcion;
        private System.Windows.Forms.TextBox tb_funcion;
        private System.Windows.Forms.Button btn_cargarFuncion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_precioOrigen;
        private System.Windows.Forms.Label lbl_precioDestino;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox gb_preciosDeMuestra;
        private System.Windows.Forms.Button btn_probarFuncion;
        private System.Windows.Forms.Label lbl_precioDestinoValor;
        private System.Windows.Forms.Button btn_eliminarFuncion;
        private System.Windows.Forms.ProgressBar pb_aplicarFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_ayuda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}