namespace CasoDeEstudio
{
    partial class ParqueTecnologico
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
            this.btnBuscarPuesto = new System.Windows.Forms.Button();
            this.btnContarPuestos = new System.Windows.Forms.Button();
            this.btnBorrarSelecionado = new System.Windows.Forms.Button();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(27, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.tvJerarquia);
            this.tabPage2.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.Tan;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(651, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jerarquia [Arbol]";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPuesto
            // 
            this.btnBuscarPuesto.BackColor = System.Drawing.Color.Tan;
            this.btnBuscarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPuesto.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPuesto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPuesto.Location = new System.Drawing.Point(427, 98);
            this.btnBuscarPuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPuesto.Name = "btnBuscarPuesto";
            this.btnBuscarPuesto.Size = new System.Drawing.Size(97, 77);
            this.btnBuscarPuesto.TabIndex = 6;
            this.btnBuscarPuesto.Text = "Buscar Puesto";
            this.btnBuscarPuesto.UseVisualStyleBackColor = false;
            this.btnBuscarPuesto.Click += new System.EventHandler(this.btnBuscarPuesto_Click);
            // 
            // btnContarPuestos
            // 
            this.btnContarPuestos.BackColor = System.Drawing.Color.Tan;
            this.btnContarPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContarPuestos.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarPuestos.ForeColor = System.Drawing.Color.White;
            this.btnContarPuestos.Location = new System.Drawing.Point(304, 96);
            this.btnContarPuestos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContarPuestos.Name = "btnContarPuestos";
            this.btnContarPuestos.Size = new System.Drawing.Size(101, 79);
            this.btnContarPuestos.TabIndex = 5;
            this.btnContarPuestos.Text = "Contar Puestos";
            this.btnContarPuestos.UseVisualStyleBackColor = false;
            this.btnContarPuestos.Click += new System.EventHandler(this.btnContarPuestos_Click);
            // 
            // btnBorrarSelecionado
            // 
            this.btnBorrarSelecionado.BackColor = System.Drawing.Color.Tan;
            this.btnBorrarSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSelecionado.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSelecionado.ForeColor = System.Drawing.Color.White;
            this.btnBorrarSelecionado.Location = new System.Drawing.Point(163, 96);
            this.btnBorrarSelecionado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrarSelecionado.Name = "btnBorrarSelecionado";
            this.btnBorrarSelecionado.Size = new System.Drawing.Size(121, 77);
            this.btnBorrarSelecionado.TabIndex = 4;
            this.btnBorrarSelecionado.Text = "Borrar Seleccionado";
            this.btnBorrarSelecionado.UseVisualStyleBackColor = false;
            this.btnBorrarSelecionado.Click += new System.EventHandler(this.btnBorrarSelecionado_Click);
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.BackColor = System.Drawing.Color.Tan;
            this.btnAgregarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPuesto.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuesto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPuesto.Location = new System.Drawing.Point(37, 96);
            this.btnAgregarPuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(98, 77);
            this.btnAgregarPuesto.TabIndex = 3;
            this.btnAgregarPuesto.Text = "Agregar Puesto";
            this.btnAgregarPuesto.UseVisualStyleBackColor = false;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.ForeColor = System.Drawing.Color.Black;
            this.txtPuesto.Location = new System.Drawing.Point(206, 43);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(334, 36);
            this.txtPuesto.TabIndex = 2;
            this.txtPuesto.TextChanged += new System.EventHandler(this.txtPuesto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Puesto:";
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvJerarquia.Location = new System.Drawing.Point(41, 265);
            this.tvJerarquia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvJerarquia.Name = "tvJerarquia";
            this.tvJerarquia.Size = new System.Drawing.Size(570, 271);
            this.tvJerarquia.TabIndex = 0;
            this.tvJerarquia.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvJerarquia_AfterSelect);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(407, 662);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarPuesto);
            this.groupBox1.Controls.Add(this.txtPuesto);
            this.groupBox1.Controls.Add(this.btnContarPuestos);
            this.groupBox1.Controls.Add(this.btnAgregarPuesto);
            this.groupBox1.Controls.Add(this.btnBorrarSelecionado);
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(570, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ParqueTecnologico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(723, 667);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ParqueTecnologico";
            this.Text = "Parque Tecnologico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

