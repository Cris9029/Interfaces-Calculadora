using System;

namespace Calculadora
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
            this.textBoxProceso = new System.Windows.Forms.TextBox();
            this.textBoxOperacion = new System.Windows.Forms.TextBox();
            this.botonA = new System.Windows.Forms.Button();
            this.botonF = new System.Windows.Forms.Button();
            this.botonE = new System.Windows.Forms.Button();
            this.botonD = new System.Windows.Forms.Button();
            this.botonC = new System.Windows.Forms.Button();
            this.botonB = new System.Windows.Forms.Button();
            this.botonHex = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProceso
            // 
            this.textBoxProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxProceso.Location = new System.Drawing.Point(0, 0);
            this.textBoxProceso.Multiline = true;
            this.textBoxProceso.Name = "textBoxProceso";
            this.textBoxProceso.Size = new System.Drawing.Size(443, 51);
            this.textBoxProceso.TabIndex = 0;
            // 
            // textBoxOperacion
            // 
            this.textBoxOperacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxOperacion.Location = new System.Drawing.Point(0, 51);
            this.textBoxOperacion.Multiline = true;
            this.textBoxOperacion.Name = "textBoxOperacion";
            this.textBoxOperacion.Size = new System.Drawing.Size(443, 133);
            this.textBoxOperacion.TabIndex = 1;
            // 
            // botonA
            // 
            this.botonA.Location = new System.Drawing.Point(0, 190);
            this.botonA.Name = "botonA";
            this.botonA.Size = new System.Drawing.Size(75, 47);
            this.botonA.TabIndex = 2;
            this.botonA.Text = "A";
            this.botonA.UseVisualStyleBackColor = true;
            // 
            // botonF
            // 
            this.botonF.Location = new System.Drawing.Point(0, 455);
            this.botonF.Name = "botonF";
            this.botonF.Size = new System.Drawing.Size(75, 47);
            this.botonF.TabIndex = 3;
            this.botonF.Text = "F";
            this.botonF.UseVisualStyleBackColor = true;
            // 
            // botonE
            // 
            this.botonE.Location = new System.Drawing.Point(0, 402);
            this.botonE.Name = "botonE";
            this.botonE.Size = new System.Drawing.Size(75, 47);
            this.botonE.TabIndex = 4;
            this.botonE.Text = "E";
            this.botonE.UseVisualStyleBackColor = true;
            // 
            // botonD
            // 
            this.botonD.Location = new System.Drawing.Point(0, 349);
            this.botonD.Name = "botonD";
            this.botonD.Size = new System.Drawing.Size(75, 47);
            this.botonD.TabIndex = 5;
            this.botonD.Text = "D";
            this.botonD.UseVisualStyleBackColor = true;
            // 
            // botonC
            // 
            this.botonC.Location = new System.Drawing.Point(0, 296);
            this.botonC.Name = "botonC";
            this.botonC.Size = new System.Drawing.Size(75, 47);
            this.botonC.TabIndex = 6;
            this.botonC.Text = "C";
            this.botonC.UseVisualStyleBackColor = true;
            this.botonC.Click += new System.EventHandler(this.botonC_Click);
            // 
            // botonB
            // 
            this.botonB.Location = new System.Drawing.Point(0, 243);
            this.botonB.Name = "botonB";
            this.botonB.Size = new System.Drawing.Size(75, 47);
            this.botonB.TabIndex = 7;
            this.botonB.Text = "B";
            this.botonB.UseVisualStyleBackColor = true;
            this.botonB.Click += new System.EventHandler(this.botonB_Click);
            // 
            // botonHex
            // 
            this.botonHex.Location = new System.Drawing.Point(0, 508);
            this.botonHex.Name = "botonHex";
            this.botonHex.Size = new System.Drawing.Size(75, 47);
            this.botonHex.TabIndex = 8;
            this.botonHex.Text = "X";
            this.botonHex.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(334, 296);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 47);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(334, 349);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 47);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(334, 402);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 47);
            this.b3.TabIndex = 11;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(253, 296);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 47);
            this.b8.TabIndex = 12;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(253, 349);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 47);
            this.b5.TabIndex = 13;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(253, 402);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 47);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(172, 296);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 47);
            this.b7.TabIndex = 15;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(172, 349);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 47);
            this.b4.TabIndex = 16;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(172, 402);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 47);
            this.b1.TabIndex = 17;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(172, 455);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 47);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 566);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.botonHex);
            this.Controls.Add(this.botonB);
            this.Controls.Add(this.botonC);
            this.Controls.Add(this.botonD);
            this.Controls.Add(this.botonE);
            this.Controls.Add(this.botonF);
            this.Controls.Add(this.botonA);
            this.Controls.Add(this.textBoxOperacion);
            this.Controls.Add(this.textBoxProceso);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */
        #endregion

        private System.Windows.Forms.TextBox textBoxProceso;
        private System.Windows.Forms.TextBox textBoxOperacion;
        private System.Windows.Forms.Button botonA;
        private System.Windows.Forms.Button botonF;
        private System.Windows.Forms.Button botonE;
        private System.Windows.Forms.Button botonD;
        private System.Windows.Forms.Button botonC;
        private System.Windows.Forms.Button botonB;
        private System.Windows.Forms.Button botonHex;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b0;
    }
}

