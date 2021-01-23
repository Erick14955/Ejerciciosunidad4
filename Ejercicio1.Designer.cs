
namespace Unidad4
{
    partial class Ejercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio1));
            this.CuadroNumero = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.resultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CuadroNumero
            // 
            this.CuadroNumero.Location = new System.Drawing.Point(69, 39);
            this.CuadroNumero.Name = "CuadroNumero";
            this.CuadroNumero.Size = new System.Drawing.Size(130, 23);
            this.CuadroNumero.TabIndex = 0;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aceptar.Location = new System.Drawing.Point(205, 39);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Titulo.Location = new System.Drawing.Point(137, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(527, 26);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier nú" +
    "mero.";
            // 
            // resultados
            // 
            this.resultados.Location = new System.Drawing.Point(12, 81);
            this.resultados.Multiline = true;
            this.resultados.Name = "resultados";
            this.resultados.ReadOnly = true;
            this.resultados.Size = new System.Drawing.Size(212, 211);
            this.resultados.TabIndex = 5;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(704, 315);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.CuadroNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CuadroNumero;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox resultados;
    }
}