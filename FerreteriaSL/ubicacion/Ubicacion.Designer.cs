using System.ComponentModel;
using System.Windows.Forms;

namespace FerreteriaSL.ubicacion
{
    partial class Ubicacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tv_sections = new System.Windows.Forms.TreeView();
            this.btn_addSection = new System.Windows.Forms.Button();
            this.btn_deleteSection = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv_sections
            // 
            this.tv_sections.Location = new System.Drawing.Point(12, 12);
            this.tv_sections.Name = "tv_sections";
            this.tv_sections.Size = new System.Drawing.Size(443, 405);
            this.tv_sections.TabIndex = 0;
            this.tv_sections.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_sections_BeforeSelect);
            this.tv_sections.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_sections_NodeMouseClick);
            // 
            // btn_addSection
            // 
            this.btn_addSection.Location = new System.Drawing.Point(170, 423);
            this.btn_addSection.Name = "btn_addSection";
            this.btn_addSection.Size = new System.Drawing.Size(140, 39);
            this.btn_addSection.TabIndex = 1;
            this.btn_addSection.Text = "Agregar Nueva Sub-Sección a Selección";
            this.btn_addSection.UseVisualStyleBackColor = true;
            this.btn_addSection.Click += new System.EventHandler(this.btn_addSection_Click);
            // 
            // btn_deleteSection
            // 
            this.btn_deleteSection.Location = new System.Drawing.Point(316, 423);
            this.btn_deleteSection.Name = "btn_deleteSection";
            this.btn_deleteSection.Size = new System.Drawing.Size(140, 39);
            this.btn_deleteSection.TabIndex = 2;
            this.btn_deleteSection.Text = "Elminiar Sub-Sección Seleccionada";
            this.btn_deleteSection.UseVisualStyleBackColor = true;
            this.btn_deleteSection.Click += new System.EventHandler(this.btn_deleteSection_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 474);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(69, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addItems
            // 
            this.btn_addItems.Location = new System.Drawing.Point(170, 468);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Size = new System.Drawing.Size(284, 29);
            this.btn_addItems.TabIndex = 4;
            this.btn_addItems.Text = "Agregar/Quitar Articulos a Sub-Sección";
            this.btn_addItems.UseVisualStyleBackColor = true;
            this.btn_addItems.Click += new System.EventHandler(this.btn_addItems_Click);
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btn_addItems);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_deleteSection);
            this.Controls.Add(this.btn_addSection);
            this.Controls.Add(this.tv_sections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ubicacion";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secciones";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tv_sections;
        private Button btn_addSection;
        private Button btn_deleteSection;
        private Button btn_close;
        private Button btn_addItems;
    }
}