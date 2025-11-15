namespace CasoDeEstudio
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.btnBorrarSelecionado = new System.Windows.Forms.Button();
            this.btnContarPuestos = new System.Windows.Forms.Button();
            this.btnBuscarPuesto = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(22, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuscarPuesto);
            this.tabPage2.Controls.Add(this.btnContarPuestos);
            this.tabPage2.Controls.Add(this.btnBorrarSelecionado);
            this.tabPage2.Controls.Add(this.btnAgregarPuesto);
            this.tabPage2.Controls.Add(this.txtPuesto);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tvJerarquia);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jerarquia [Arbol]";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 397);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.Location = new System.Drawing.Point(20, 129);
            this.tvJerarquia.Name = "tvJerarquia";
            this.tvJerarquia.Size = new System.Drawing.Size(395, 242);
            this.tvJerarquia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(163, 22);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(252, 22);
            this.txtPuesto.TabIndex = 2;
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.Location = new System.Drawing.Point(23, 53);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(75, 51);
            this.btnAgregarPuesto.TabIndex = 3;
            this.btnAgregarPuesto.Text = "Agregar Puesto";
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // btnBorrarSelecionado
            // 
            this.btnBorrarSelecionado.Location = new System.Drawing.Point(116, 53);
            this.btnBorrarSelecionado.Name = "btnBorrarSelecionado";
            this.btnBorrarSelecionado.Size = new System.Drawing.Size(105, 51);
            this.btnBorrarSelecionado.TabIndex = 4;
            this.btnBorrarSelecionado.Text = "Borrar Seleccionado";
            this.btnBorrarSelecionado.UseVisualStyleBackColor = true;
            this.btnBorrarSelecionado.Click += new System.EventHandler(this.btnBorrarSelecionado_Click);
            // 
            // btnContarPuestos
            // 
            this.btnContarPuestos.Location = new System.Drawing.Point(242, 53);
            this.btnContarPuestos.Name = "btnContarPuestos";
            this.btnContarPuestos.Size = new System.Drawing.Size(75, 52);
            this.btnContarPuestos.TabIndex = 5;
            this.btnContarPuestos.Text = "Contar Puestos";
            this.btnContarPuestos.UseVisualStyleBackColor = true;
            this.btnContarPuestos.Click += new System.EventHandler(this.btnContarPuestos_Click);
            // 
            // btnBuscarPuesto
            // 
            this.btnBuscarPuesto.Location = new System.Drawing.Point(340, 53);
            this.btnBuscarPuesto.Name = "btnBuscarPuesto";
            this.btnBuscarPuesto.Size = new System.Drawing.Size(75, 52);
            this.btnBuscarPuesto.TabIndex = 6;
            this.btnBuscarPuesto.Text = "Buscar Puesto";
            this.btnBuscarPuesto.UseVisualStyleBackColor = true;
            this.btnBuscarPuesto.Click += new System.EventHandler(this.btnBuscarPuesto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(496, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarPuesto;
        private System.Windows.Forms.Button btnContarPuestos;
        private System.Windows.Forms.Button btnBorrarSelecionado;
        private System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvJerarquia;
    }
}

