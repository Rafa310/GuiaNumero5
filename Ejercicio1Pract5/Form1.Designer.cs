
namespace Ejercicio1Pract5
{
    partial class Form1
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
            this.calc = new System.Windows.Forms.Button();
            this.cmbot = new System.Windows.Forms.ComboBox();
            this.preg2 = new System.Windows.Forms.Label();
            this.peticion = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.preg1 = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(295, 281);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(226, 46);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // cmbot
            // 
            this.cmbot.FormattingEnabled = true;
            this.cmbot.Location = new System.Drawing.Point(295, 126);
            this.cmbot.Name = "cmbot";
            this.cmbot.Size = new System.Drawing.Size(165, 23);
            this.cmbot.TabIndex = 1;
            this.cmbot.SelectedIndexChanged += new System.EventHandler(this.cmbot_SelectedIndexChanged);
            // 
            // preg2
            // 
            this.preg2.AutoSize = true;
            this.preg2.Location = new System.Drawing.Point(295, 89);
            this.preg2.Name = "preg2";
            this.preg2.Size = new System.Drawing.Size(104, 15);
            this.preg2.TabIndex = 2;
            this.preg2.Text = "Cual es su puesto?";
            // 
            // peticion
            // 
            this.peticion.AutoSize = true;
            this.peticion.Location = new System.Drawing.Point(12, 89);
            this.peticion.Name = "peticion";
            this.peticion.Size = new System.Drawing.Size(102, 15);
            this.peticion.TabIndex = 3;
            this.peticion.Text = "Inserte su nombre";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // preg1
            // 
            this.preg1.AutoSize = true;
            this.preg1.Location = new System.Drawing.Point(148, 89);
            this.preg1.Name = "preg1";
            this.preg1.Size = new System.Drawing.Size(102, 15);
            this.preg1.TabIndex = 5;
            this.preg1.Text = "Cual es su salario?";
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(148, 126);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(129, 23);
            this.salario.TabIndex = 6;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(654, 379);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(114, 53);
            this.salir.TabIndex = 7;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.preg1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.peticion);
            this.Controls.Add(this.preg2);
            this.Controls.Add(this.cmbot);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.ComboBox cmbot;
        private System.Windows.Forms.Label preg2;
        private System.Windows.Forms.Label peticion;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label preg1;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.Button salir;
    }
}

