namespace Calculadora_C
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
            this.Texto = new System.Windows.Forms.TextBox();
            this.Borrar = new System.Windows.Forms.Button();
            this.Parentesis1 = new System.Windows.Forms.Button();
            this.Parentesis2 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.Location = new System.Drawing.Point(15, 13);
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Texto.Size = new System.Drawing.Size(318, 48);
            this.Texto.TabIndex = 0;
            // 
            // Borrar
            // 
            this.Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(13, 85);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 48);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "AC";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Parentesis1
            // 
            this.Parentesis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parentesis1.Location = new System.Drawing.Point(94, 85);
            this.Parentesis1.Name = "Parentesis1";
            this.Parentesis1.Size = new System.Drawing.Size(75, 48);
            this.Parentesis1.TabIndex = 2;
            this.Parentesis1.Text = "(";
            this.Parentesis1.UseVisualStyleBackColor = true;
            // 
            // Parentesis2
            // 
            this.Parentesis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parentesis2.Location = new System.Drawing.Point(175, 85);
            this.Parentesis2.Name = "Parentesis2";
            this.Parentesis2.Size = new System.Drawing.Size(75, 48);
            this.Parentesis2.TabIndex = 3;
            this.Parentesis2.Text = ")";
            this.Parentesis2.UseVisualStyleBackColor = true;
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(13, 139);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(75, 48);
            this.Num7.TabIndex = 4;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(94, 139);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(75, 48);
            this.Num8.TabIndex = 5;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(175, 139);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(75, 48);
            this.Num9.TabIndex = 6;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(13, 193);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(75, 48);
            this.Num4.TabIndex = 7;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(94, 193);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(75, 48);
            this.Num5.TabIndex = 8;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(175, 193);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(75, 48);
            this.Num6.TabIndex = 9;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(13, 247);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(75, 48);
            this.Num1.TabIndex = 10;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(92, 247);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(75, 48);
            this.Num2.TabIndex = 11;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(175, 247);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(75, 48);
            this.Num3.TabIndex = 12;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(256, 85);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 48);
            this.Division.TabIndex = 13;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacion.Location = new System.Drawing.Point(256, 139);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(75, 48);
            this.Multiplicacion.TabIndex = 14;
            this.Multiplicacion.Text = "x";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Suma
            // 
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(256, 193);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 48);
            this.Suma.TabIndex = 15;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(256, 247);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 48);
            this.Resta.TabIndex = 16;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(13, 301);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(154, 48);
            this.Num0.TabIndex = 17;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Punto
            // 
            this.Punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punto.Location = new System.Drawing.Point(175, 300);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(75, 48);
            this.Punto.TabIndex = 18;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = true;
            this.Punto.Click += new System.EventHandler(this.Punto_Click);
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(256, 301);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(75, 48);
            this.Igual.TabIndex = 19;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(344, 360);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Parentesis2);
            this.Controls.Add(this.Parentesis1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Texto);
            this.Name = "Form1";
            this.Text = "La Mejor Calculadora Brayahn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Parentesis1;
        private System.Windows.Forms.Button Parentesis2;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Igual;
    }
}

