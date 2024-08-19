using System.Drawing;
using System.Windows.Forms;

namespace Practico2
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
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TGuardar = new System.Windows.Forms.Button();
            this.TEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(21, 45);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(95, 13);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(123, 45);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "Modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(21, 103);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(21, 137);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(21, 175);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 4;
            this.LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(75, 101);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(86, 20);
            this.TDni.TabIndex = 5;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(75, 134);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(86, 20);
            this.TNombre.TabIndex = 6;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(75, 172);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(86, 20);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TGuardar
            // 
            this.TGuardar.Location = new System.Drawing.Point(21, 219);
            this.TGuardar.Name = "TGuardar";
            this.TGuardar.Size = new System.Drawing.Size(64, 20);
            this.TGuardar.TabIndex = 8;
            this.TGuardar.Text = "Guardar";
            this.TGuardar.UseVisualStyleBackColor = true;
            this.TGuardar.Click += new System.EventHandler(this.TGuardar_Click);
            // 
            // TEliminar
            // 
            this.TEliminar.Location = new System.Drawing.Point(96, 219);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(64, 20);
            this.TEliminar.TabIndex = 9;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(235, 277);
            this.Controls.Add(this.TEliminar);
            this.Controls.Add(this.TGuardar);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNya);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Button TGuardar;
        private Button TEliminar;
    }
}

