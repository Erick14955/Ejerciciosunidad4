
namespace Unidad4
{
    partial class Ejercicio2
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
            this.CuadroNumero = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroElevacion = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CuadroNumero
            // 
            this.CuadroNumero.Location = new System.Drawing.Point(69, 49);
            this.CuadroNumero.Name = "CuadroNumero";
            this.CuadroNumero.Size = new System.Drawing.Size(122, 23);
            this.CuadroNumero.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Titulo.Location = new System.Drawing.Point(120, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(566, 25);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Hacer un programa que calcule el resultado de un número elevado a cualquier poten" +
    "cia.";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(12, 52);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(51, 15);
            this.Numero.TabIndex = 2;
            this.Numero.Text = "Numero";
            this.Numero.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero al cual desea elevar";
            // 
            // CuadroElevacion
            // 
            this.CuadroElevacion.Location = new System.Drawing.Point(173, 93);
            this.CuadroElevacion.Name = "CuadroElevacion";
            this.CuadroElevacion.Size = new System.Drawing.Size(122, 23);
            this.CuadroElevacion.TabIndex = 4;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(12, 222);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(59, 15);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "Resultado";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(69, 219);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(122, 23);
            this.Result.TabIndex = 6;
            // 
            // Aceptar
            // 
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aceptar.Location = new System.Drawing.Point(12, 137);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(131, 27);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(843, 299);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.CuadroElevacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.CuadroNumero);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CuadroNumero;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroElevacion;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Aceptar;
    }
}