namespace LV2
{
    partial class Form1
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
            this.grpBoxColor = new System.Windows.Forms.GroupBox();
            this.radBtnPlava = new System.Windows.Forms.RadioButton();
            this.radBtnCrvena = new System.Windows.Forms.RadioButton();
            this.radBtnCrna = new System.Windows.Forms.RadioButton();
            this.grpBoxGrafObj = new System.Windows.Forms.GroupBox();
            this.radBtnPoligon = new System.Windows.Forms.RadioButton();
            this.radBtnKvadar = new System.Windows.Forms.RadioButton();
            this.radBtnLinija = new System.Windows.Forms.RadioButton();
            this.radBtnKruznica = new System.Windows.Forms.RadioButton();
            this.radBtnElipsa = new System.Windows.Forms.RadioButton();
            this.grpBoxColor.SuspendLayout();
            this.grpBoxGrafObj.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxColor
            // 
            this.grpBoxColor.Controls.Add(this.radBtnPlava);
            this.grpBoxColor.Controls.Add(this.radBtnCrvena);
            this.grpBoxColor.Controls.Add(this.radBtnCrna);
            this.grpBoxColor.Location = new System.Drawing.Point(486, 155);
            this.grpBoxColor.Name = "grpBoxColor";
            this.grpBoxColor.Size = new System.Drawing.Size(115, 96);
            this.grpBoxColor.TabIndex = 3;
            this.grpBoxColor.TabStop = false;
            this.grpBoxColor.Text = "Color";
            // 
            // radBtnPlava
            // 
            this.radBtnPlava.AutoSize = true;
            this.radBtnPlava.Location = new System.Drawing.Point(5, 65);
            this.radBtnPlava.Name = "radBtnPlava";
            this.radBtnPlava.Size = new System.Drawing.Size(46, 17);
            this.radBtnPlava.TabIndex = 7;
            this.radBtnPlava.TabStop = true;
            this.radBtnPlava.Text = "Blue";
            this.radBtnPlava.UseVisualStyleBackColor = true;
            // 
            // radBtnCrvena
            // 
            this.radBtnCrvena.AutoSize = true;
            this.radBtnCrvena.Location = new System.Drawing.Point(5, 42);
            this.radBtnCrvena.Name = "radBtnCrvena";
            this.radBtnCrvena.Size = new System.Drawing.Size(45, 17);
            this.radBtnCrvena.TabIndex = 6;
            this.radBtnCrvena.TabStop = true;
            this.radBtnCrvena.Text = "Red";
            this.radBtnCrvena.UseVisualStyleBackColor = true;
            // 
            // radBtnCrna
            // 
            this.radBtnCrna.AutoSize = true;
            this.radBtnCrna.Location = new System.Drawing.Point(6, 19);
            this.radBtnCrna.Name = "radBtnCrna";
            this.radBtnCrna.Size = new System.Drawing.Size(52, 17);
            this.radBtnCrna.TabIndex = 5;
            this.radBtnCrna.TabStop = true;
            this.radBtnCrna.Text = "Black";
            this.radBtnCrna.UseVisualStyleBackColor = true;
            // 
            // grpBoxGrafObj
            // 
            this.grpBoxGrafObj.Controls.Add(this.radBtnPoligon);
            this.grpBoxGrafObj.Controls.Add(this.radBtnKvadar);
            this.grpBoxGrafObj.Controls.Add(this.radBtnLinija);
            this.grpBoxGrafObj.Controls.Add(this.radBtnKruznica);
            this.grpBoxGrafObj.Controls.Add(this.radBtnElipsa);
            this.grpBoxGrafObj.Location = new System.Drawing.Point(486, 12);
            this.grpBoxGrafObj.Name = "grpBoxGrafObj";
            this.grpBoxGrafObj.Size = new System.Drawing.Size(115, 137);
            this.grpBoxGrafObj.TabIndex = 2;
            this.grpBoxGrafObj.TabStop = false;
            this.grpBoxGrafObj.Text = "Graf.Obj";
            // 
            // radBtnPoligon
            // 
            this.radBtnPoligon.AutoSize = true;
            this.radBtnPoligon.Location = new System.Drawing.Point(6, 111);
            this.radBtnPoligon.Name = "radBtnPoligon";
            this.radBtnPoligon.Size = new System.Drawing.Size(63, 17);
            this.radBtnPoligon.TabIndex = 4;
            this.radBtnPoligon.TabStop = true;
            this.radBtnPoligon.Text = "Polygon";
            this.radBtnPoligon.UseVisualStyleBackColor = true;
            // 
            // radBtnKvadar
            // 
            this.radBtnKvadar.AutoSize = true;
            this.radBtnKvadar.Location = new System.Drawing.Point(6, 88);
            this.radBtnKvadar.Name = "radBtnKvadar";
            this.radBtnKvadar.Size = new System.Drawing.Size(74, 17);
            this.radBtnKvadar.TabIndex = 3;
            this.radBtnKvadar.TabStop = true;
            this.radBtnKvadar.Text = "Rectangle";
            this.radBtnKvadar.UseVisualStyleBackColor = true;
            this.radBtnKvadar.CheckedChanged += new System.EventHandler(this.radBtnKvadar_CheckedChanged);
            // 
            // radBtnLinija
            // 
            this.radBtnLinija.AutoSize = true;
            this.radBtnLinija.Location = new System.Drawing.Point(6, 65);
            this.radBtnLinija.Name = "radBtnLinija";
            this.radBtnLinija.Size = new System.Drawing.Size(45, 17);
            this.radBtnLinija.TabIndex = 2;
            this.radBtnLinija.TabStop = true;
            this.radBtnLinija.Text = "Line";
            this.radBtnLinija.UseVisualStyleBackColor = true;
            // 
            // radBtnKruznica
            // 
            this.radBtnKruznica.AutoSize = true;
            this.radBtnKruznica.Location = new System.Drawing.Point(6, 42);
            this.radBtnKruznica.Name = "radBtnKruznica";
            this.radBtnKruznica.Size = new System.Drawing.Size(51, 17);
            this.radBtnKruznica.TabIndex = 1;
            this.radBtnKruznica.TabStop = true;
            this.radBtnKruznica.Text = "Circle";
            this.radBtnKruznica.UseVisualStyleBackColor = true;
            // 
            // radBtnElipsa
            // 
            this.radBtnElipsa.AutoSize = true;
            this.radBtnElipsa.Location = new System.Drawing.Point(6, 19);
            this.radBtnElipsa.Name = "radBtnElipsa";
            this.radBtnElipsa.Size = new System.Drawing.Size(55, 17);
            this.radBtnElipsa.TabIndex = 0;
            this.radBtnElipsa.TabStop = true;
            this.radBtnElipsa.Text = "Ellipse";
            this.radBtnElipsa.UseVisualStyleBackColor = true;
            this.radBtnElipsa.CheckedChanged += new System.EventHandler(this.radBtnElipsa_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 332);
            this.Controls.Add(this.grpBoxColor);
            this.Controls.Add(this.grpBoxGrafObj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.grpBoxColor.ResumeLayout(false);
            this.grpBoxColor.PerformLayout();
            this.grpBoxGrafObj.ResumeLayout(false);
            this.grpBoxGrafObj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxColor;
        private System.Windows.Forms.RadioButton radBtnPlava;
        private System.Windows.Forms.RadioButton radBtnCrvena;
        private System.Windows.Forms.RadioButton radBtnCrna;
        private System.Windows.Forms.GroupBox grpBoxGrafObj;
        private System.Windows.Forms.RadioButton radBtnPoligon;
        private System.Windows.Forms.RadioButton radBtnKvadar;
        private System.Windows.Forms.RadioButton radBtnLinija;
        private System.Windows.Forms.RadioButton radBtnKruznica;
        private System.Windows.Forms.RadioButton radBtnElipsa;
    }
}

