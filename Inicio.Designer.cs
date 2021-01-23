
namespace Unidad4
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Ejercicio1 = new System.Windows.Forms.Button();
            this.Ejercicio2 = new System.Windows.Forms.Button();
            this.Ejercicio3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejercicio1
            // 
            this.Ejercicio1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ejercicio1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ejercicio1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ejercicio1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ejercicio1.Location = new System.Drawing.Point(39, 75);
            this.Ejercicio1.Name = "Ejercicio1";
            this.Ejercicio1.Size = new System.Drawing.Size(132, 53);
            this.Ejercicio1.TabIndex = 0;
            this.Ejercicio1.Text = "Ejercicio 1";
            this.Ejercicio1.UseVisualStyleBackColor = false;
            this.Ejercicio1.Click += new System.EventHandler(this.Ejercicio1_Click);
            // 
            // Ejercicio2
            // 
            this.Ejercicio2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ejercicio2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ejercicio2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ejercicio2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ejercicio2.Location = new System.Drawing.Point(256, 75);
            this.Ejercicio2.Name = "Ejercicio2";
            this.Ejercicio2.Size = new System.Drawing.Size(132, 53);
            this.Ejercicio2.TabIndex = 1;
            this.Ejercicio2.Text = "Ejercicio 2";
            this.Ejercicio2.UseVisualStyleBackColor = false;
            this.Ejercicio2.Click += new System.EventHandler(this.Ejercicio2_Click);
            // 
            // Ejercicio3
            // 
            this.Ejercicio3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ejercicio3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ejercicio3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ejercicio3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ejercicio3.Location = new System.Drawing.Point(468, 75);
            this.Ejercicio3.Name = "Ejercicio3";
            this.Ejercicio3.Size = new System.Drawing.Size(132, 53);
            this.Ejercicio3.TabIndex = 2;
            this.Ejercicio3.Text = "Ejercicio 3";
            this.Ejercicio3.UseVisualStyleBackColor = false;
            this.Ejercicio3.Click += new System.EventHandler(this.Ejercicio3_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(727, 209);
            this.Controls.Add(this.Ejercicio3);
            this.Controls.Add(this.Ejercicio2);
            this.Controls.Add(this.Ejercicio1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicios de ciclos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejercicio1;
        private System.Windows.Forms.Button Ejercicio2;
        private System.Windows.Forms.Button Ejercicio3;
    }
}

