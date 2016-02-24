namespace prjPrincipal
{
    partial class frmCalcularSalario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadHoras = new System.Windows.Forms.TextBox();
            this.txtPrecioHora = new System.Windows.Forms.TextBox();
            this.txtPorcentajeCargas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCalcularDos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorcentajeCargasProyectado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio hora";
            // 
            // txtCantidadHoras
            // 
            this.txtCantidadHoras.Location = new System.Drawing.Point(182, 66);
            this.txtCantidadHoras.Name = "txtCantidadHoras";
            this.txtCantidadHoras.Size = new System.Drawing.Size(188, 20);
            this.txtCantidadHoras.TabIndex = 3;
            this.txtCantidadHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadHoras_KeyPress);
            // 
            // txtPrecioHora
            // 
            this.txtPrecioHora.Location = new System.Drawing.Point(182, 113);
            this.txtPrecioHora.Name = "txtPrecioHora";
            this.txtPrecioHora.Size = new System.Drawing.Size(188, 20);
            this.txtPrecioHora.TabIndex = 5;
            // 
            // txtPorcentajeCargas
            // 
            this.txtPorcentajeCargas.Location = new System.Drawing.Point(182, 150);
            this.txtPorcentajeCargas.Name = "txtPorcentajeCargas";
            this.txtPorcentajeCargas.Size = new System.Drawing.Size(188, 20);
            this.txtPorcentajeCargas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porcentaje Cargas";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(182, 203);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(188, 20);
            this.txtSalarioNeto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salario Neto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(182, 260);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCalcularDos
            // 
            this.btnCalcularDos.Location = new System.Drawing.Point(295, 259);
            this.btnCalcularDos.Name = "btnCalcularDos";
            this.btnCalcularDos.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularDos.TabIndex = 12;
            this.btnCalcularDos.Text = "Calcular Dos";
            this.btnCalcularDos.UseVisualStyleBackColor = true;
            this.btnCalcularDos.Click += new System.EventHandler(this.btnCalcularDos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Porcentaje Cargas";
            // 
            // txtPorcentajeCargasProyectado
            // 
            this.txtPorcentajeCargasProyectado.Location = new System.Drawing.Point(491, 153);
            this.txtPorcentajeCargasProyectado.Name = "txtPorcentajeCargasProyectado";
            this.txtPorcentajeCargasProyectado.Size = new System.Drawing.Size(188, 20);
            this.txtPorcentajeCargasProyectado.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 331);
            this.Controls.Add(this.txtPorcentajeCargasProyectado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcularDos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalarioNeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPorcentajeCargas);
            this.Controls.Add(this.txtPrecioHora);
            this.Controls.Add(this.txtCantidadHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadHoras;
        private System.Windows.Forms.TextBox txtPrecioHora;
        private System.Windows.Forms.TextBox txtPorcentajeCargas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCalcularDos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcentajeCargasProyectado;
    }
}

