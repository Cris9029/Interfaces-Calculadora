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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.bPlus = new System.Windows.Forms.Button();
            this.bRaiz = new System.Windows.Forms.Button();
            this.bMod = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMult = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bRes = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.bBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProceso
            // 
            this.textBoxProceso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProceso.ForeColor = System.Drawing.Color.Gray;
            this.textBoxProceso.Location = new System.Drawing.Point(0, 0);
            this.textBoxProceso.Multiline = true;
            this.textBoxProceso.Name = "textBoxProceso";
            this.textBoxProceso.ReadOnly = true;
            this.textBoxProceso.Size = new System.Drawing.Size(443, 51);
            this.textBoxProceso.TabIndex = 0;
            this.textBoxProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOperacion
            // 
            this.textBoxOperacion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxOperacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOperacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxOperacion.Location = new System.Drawing.Point(0, 51);
            this.textBoxOperacion.Multiline = true;
            this.textBoxOperacion.Name = "textBoxOperacion";
            this.textBoxOperacion.ReadOnly = true;
            this.textBoxOperacion.Size = new System.Drawing.Size(443, 133);
            this.textBoxOperacion.TabIndex = 1;
            this.textBoxOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botonA
            // 
            this.botonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonA.Location = new System.Drawing.Point(0, 190);
            this.botonA.Name = "botonA";
            this.botonA.Size = new System.Drawing.Size(75, 47);
            this.botonA.TabIndex = 2;
            this.botonA.Text = "A";
            this.botonA.UseVisualStyleBackColor = true;
            this.botonA.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // botonF
            // 
            this.botonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonF.Location = new System.Drawing.Point(0, 455);
            this.botonF.Name = "botonF";
            this.botonF.Size = new System.Drawing.Size(75, 47);
            this.botonF.TabIndex = 3;
            this.botonF.Text = "F";
            this.botonF.UseVisualStyleBackColor = true;
            this.botonF.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // botonE
            // 
            this.botonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonE.Location = new System.Drawing.Point(0, 402);
            this.botonE.Name = "botonE";
            this.botonE.Size = new System.Drawing.Size(75, 47);
            this.botonE.TabIndex = 4;
            this.botonE.Text = "E";
            this.botonE.UseVisualStyleBackColor = true;
            this.botonE.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // botonD
            // 
            this.botonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonD.Location = new System.Drawing.Point(0, 349);
            this.botonD.Name = "botonD";
            this.botonD.Size = new System.Drawing.Size(75, 47);
            this.botonD.TabIndex = 5;
            this.botonD.Text = "D";
            this.botonD.UseVisualStyleBackColor = true;
            this.botonD.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // botonC
            // 
            this.botonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonC.Location = new System.Drawing.Point(0, 296);
            this.botonC.Name = "botonC";
            this.botonC.Size = new System.Drawing.Size(75, 47);
            this.botonC.TabIndex = 6;
            this.botonC.Text = "C";
            this.botonC.UseVisualStyleBackColor = true;
            this.botonC.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // botonB
            // 
            this.botonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonB.Location = new System.Drawing.Point(0, 243);
            this.botonB.Name = "botonB";
            this.botonB.Size = new System.Drawing.Size(75, 47);
            this.botonB.TabIndex = 7;
            this.botonB.Text = "B";
            this.botonB.UseVisualStyleBackColor = true;
            this.botonB.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // botonHex
            // 
            this.botonHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonHex.Location = new System.Drawing.Point(0, 562);
            this.botonHex.Name = "botonHex";
            this.botonHex.Size = new System.Drawing.Size(75, 47);
            this.botonHex.TabIndex = 8;
            this.botonHex.Text = "x";
            this.botonHex.UseVisualStyleBackColor = true;
            this.botonHex.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(260, 296);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 47);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(260, 349);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 47);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(260, 402);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 47);
            this.b3.TabIndex = 11;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(179, 296);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 47);
            this.b8.TabIndex = 12;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(179, 349);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 47);
            this.b5.TabIndex = 13;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(179, 402);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 47);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(98, 296);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 47);
            this.b7.TabIndex = 15;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(98, 349);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 47);
            this.b4.TabIndex = 16;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(98, 402);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 47);
            this.b1.TabIndex = 17;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(179, 455);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 47);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlus.Location = new System.Drawing.Point(356, 243);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(75, 47);
            this.bPlus.TabIndex = 19;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bRaiz
            // 
            this.bRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRaiz.Location = new System.Drawing.Point(356, 509);
            this.bRaiz.Name = "bRaiz";
            this.bRaiz.Size = new System.Drawing.Size(75, 47);
            this.bRaiz.TabIndex = 20;
            this.bRaiz.Text = "√";
            this.bRaiz.UseVisualStyleBackColor = true;
            this.bRaiz.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bMod
            // 
            this.bMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMod.Location = new System.Drawing.Point(356, 455);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(75, 47);
            this.bMod.TabIndex = 21;
            this.bMod.Text = "%";
            this.bMod.UseVisualStyleBackColor = true;
            this.bMod.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(356, 402);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(75, 47);
            this.bDiv.TabIndex = 22;
            this.bDiv.Text = "÷";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bMult
            // 
            this.bMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMult.Location = new System.Drawing.Point(356, 349);
            this.bMult.Name = "bMult";
            this.bMult.Size = new System.Drawing.Size(75, 47);
            this.bMult.TabIndex = 23;
            this.bMult.Text = "X";
            this.bMult.UseVisualStyleBackColor = true;
            this.bMult.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bMinus
            // 
            this.bMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMinus.Location = new System.Drawing.Point(356, 296);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(75, 47);
            this.bMinus.TabIndex = 24;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // bRes
            // 
            this.bRes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRes.ForeColor = System.Drawing.SystemColors.Window;
            this.bRes.Location = new System.Drawing.Point(356, 562);
            this.bRes.Name = "bRes";
            this.bRes.Size = new System.Drawing.Size(75, 47);
            this.bRes.TabIndex = 25;
            this.bRes.Text = "=";
            this.bRes.UseVisualStyleBackColor = false;
            this.bRes.Click += new System.EventHandler(this.bRes_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(356, 190);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 47);
            this.bBorrar.TabIndex = 26;
            this.bBorrar.Text = "⌫";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bClean
            // 
            this.bClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClean.Location = new System.Drawing.Point(260, 190);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(75, 47);
            this.bClean.TabIndex = 27;
            this.bClean.Text = "CLR";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // bBin
            // 
            this.bBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBin.Location = new System.Drawing.Point(98, 562);
            this.bBin.Name = "bBin";
            this.bBin.Size = new System.Drawing.Size(75, 47);
            this.bBin.TabIndex = 28;
            this.bBin.Text = "b";
            this.bBin.UseVisualStyleBackColor = true;
            this.bBin.Click += new System.EventHandler(this.ClickGeneral);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(443, 621);
            this.Controls.Add(this.bBin);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bRes);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bMult);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMod);
            this.Controls.Add(this.bRaiz);
            this.Controls.Add(this.bPlus);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bRaiz;
        private System.Windows.Forms.Button bMod;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMult;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bRes;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Button bBin;
    }
}

