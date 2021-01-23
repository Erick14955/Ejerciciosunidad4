
namespace Unidad4
{
    partial class Ejercicio3
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
            this.textpers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantpersonas = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.labedad = new System.Windows.Forms.Label();
            this.textedad = new System.Windows.Forms.TextBox();
            this.Aceptar1 = new System.Windows.Forms.Button();
            this.labProm = new System.Windows.Forms.Label();
            this.labmayor = new System.Windows.Forms.Label();
            this.labmenor = new System.Windows.Forms.Label();
            this.textprom = new System.Windows.Forms.TextBox();
            this.textmayor = new System.Windows.Forms.TextBox();
            this.textmenor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textpers
            // 
            this.textpers.AutoSize = true;
            this.textpers.Location = new System.Drawing.Point(12, 63);
            this.textpers.Name = "textpers";
            this.textpers.Size = new System.Drawing.Size(121, 15);
            this.textpers.TabIndex = 0;
            this.textpers.Text = "Cantidad de personas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(761, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hacer un programa que calcule el promedio de edad de un grupo de personas y diga " +
    "cuál es la de edad más grande y cuál es la más joven.";
            // 
            // cantpersonas
            // 
            this.cantpersonas.Location = new System.Drawing.Point(139, 60);
            this.cantpersonas.Name = "cantpersonas";
            this.cantpersonas.Size = new System.Drawing.Size(105, 23);
            this.cantpersonas.TabIndex = 2;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aceptar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aceptar.Location = new System.Drawing.Point(260, 60);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(91, 22);
            this.Aceptar.TabIndex = 3;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // labedad
            // 
            this.labedad.AutoSize = true;
            this.labedad.Location = new System.Drawing.Point(12, 110);
            this.labedad.Name = "labedad";
            this.labedad.Size = new System.Drawing.Size(33, 15);
            this.labedad.TabIndex = 4;
            this.labedad.Text = "Edad";
            this.labedad.Visible = false;
            // 
            // textedad
            // 
            this.textedad.Location = new System.Drawing.Point(51, 107);
            this.textedad.Name = "textedad";
            this.textedad.Size = new System.Drawing.Size(100, 23);
            this.textedad.TabIndex = 5;
            this.textedad.Visible = false;
            // 
            // Aceptar1
            // 
            this.Aceptar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Aceptar1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Aceptar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aceptar1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aceptar1.Location = new System.Drawing.Point(166, 108);
            this.Aceptar1.Name = "Aceptar1";
            this.Aceptar1.Size = new System.Drawing.Size(91, 22);
            this.Aceptar1.TabIndex = 6;
            this.Aceptar1.Text = "Aceptar";
            this.Aceptar1.UseVisualStyleBackColor = false;
            this.Aceptar1.Visible = false;
            this.Aceptar1.Click += new System.EventHandler(this.Aceptar1_Click);
            // 
            // labProm
            // 
            this.labProm.AutoSize = true;
            this.labProm.Location = new System.Drawing.Point(12, 150);
            this.labProm.Name = "labProm";
            this.labProm.Size = new System.Drawing.Size(59, 15);
            this.labProm.TabIndex = 7;
            this.labProm.Text = "Promedio";
            this.labProm.Visible = false;
            // 
            // labmayor
            // 
            this.labmayor.AutoSize = true;
            this.labmayor.Location = new System.Drawing.Point(12, 193);
            this.labmayor.Name = "labmayor";
            this.labmayor.Size = new System.Drawing.Size(70, 15);
            this.labmayor.TabIndex = 8;
            this.labmayor.Text = "Edad mayor";
            this.labmayor.Visible = false;
            // 
            // labmenor
            // 
            this.labmenor.AutoSize = true;
            this.labmenor.Location = new System.Drawing.Point(12, 233);
            this.labmenor.Name = "labmenor";
            this.labmenor.Size = new System.Drawing.Size(71, 15);
            this.labmenor.TabIndex = 9;
            this.labmenor.Text = "Edad menor";
            this.labmenor.Visible = false;
            // 
            // textprom
            // 
            this.textprom.Location = new System.Drawing.Point(77, 147);
            this.textprom.Name = "textprom";
            this.textprom.ReadOnly = true;
            this.textprom.Size = new System.Drawing.Size(100, 23);
            this.textprom.TabIndex = 10;
            this.textprom.Visible = false;
            // 
            // textmayor
            // 
            this.textmayor.Location = new System.Drawing.Point(88, 190);
            this.textmayor.Name = "textmayor";
            this.textmayor.ReadOnly = true;
            this.textmayor.Size = new System.Drawing.Size(100, 23);
            this.textmayor.TabIndex = 11;
            this.textmayor.Visible = false;
            this.textmayor.WordWrap = false;
            // 
            // textmenor
            // 
            this.textmenor.Location = new System.Drawing.Point(88, 230);
            this.textmenor.Name = "textmenor";
            this.textmenor.ReadOnly = true;
            this.textmenor.Size = new System.Drawing.Size(100, 23);
            this.textmenor.TabIndex = 12;
            this.textmenor.Visible = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.textmenor);
            this.Controls.Add(this.textmayor);
            this.Controls.Add(this.textprom);
            this.Controls.Add(this.labmenor);
            this.Controls.Add(this.labmayor);
            this.Controls.Add(this.labProm);
            this.Controls.Add(this.Aceptar1);
            this.Controls.Add(this.textedad);
            this.Controls.Add(this.labedad);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.cantpersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpers);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textpers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantpersonas;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label labedad;
        private System.Windows.Forms.TextBox textedad;
        private System.Windows.Forms.Button Aceptar1;
        private System.Windows.Forms.Label labProm;
        private System.Windows.Forms.Label labmayor;
        private System.Windows.Forms.Label labmenor;
        private System.Windows.Forms.TextBox textprom;
        private System.Windows.Forms.TextBox textmayor;
        private System.Windows.Forms.TextBox textmenor;
    }
}