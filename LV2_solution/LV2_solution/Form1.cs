using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV2
{
    public partial class Form1 : Form
    {
        private int xCoord;
        private int yCoord;
        
        Point currPoint = new Point();
        Point startPoint = new Point();

        Pen pen;
        private int penThickness = 1;

        Linija linija;
        Kvadar kvadar;
        Elipsa elipsa;
        Kruznica kruznica;
        Poligon poligon = new Poligon();


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint.X = e.X;
            startPoint.Y = e.Y;
            currPoint = startPoint;

            if (radBtnCrna.Checked)
            {
                this.pen = new Pen(Color.Black, penThickness);
            }
            else if (radBtnCrvena.Checked)
            {
                this.pen = new Pen(Color.Red, penThickness);
            }
            else if (radBtnPlava.Checked)
            {
                this.pen = new Pen(Color.Blue, penThickness);
            }
            else
            {
                string colorChoice_colorNotChosen_error = "You must choose a color.";
                MessageBox.Show(colorChoice_colorNotChosen_error, "Error");
            }
            linija = new Linija(pen, startPoint, currPoint);

            xCoord = e.X;
            yCoord = e.Y;

            kvadar = new Kvadar(new Rectangle(), pen);
            kvadar.kvadar.Width = 0;
            kvadar.kvadar.Height = 0;
            kvadar.kvadar.X = e.X;
            kvadar.kvadar.Y = e.Y;

            elipsa = new Elipsa(new Rectangle(), pen);
            elipsa.rectangle.Width = 0;
            elipsa.rectangle.Height = 0;
            elipsa.rectangle.X = e.X;
            elipsa.rectangle.Y = e.Y;

            kruznica = new Kruznica(new Rectangle(), pen);
            kruznica.rectangle.Width = 0;
            kruznica.rectangle.Height = 0; 
            kruznica.rectangle.X = e.X;
            kruznica.rectangle.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form form = (Form)sender;
                Graphics graphics = form.CreateGraphics();

                if (radBtnLinija.Checked)
                {
                    linija.DrawMovable(linija.firstPoint, linija.secondPoint, pen, form);
                    linija.secondPoint = new Point(e.X, e.Y);
                    linija.DrawMovable(linija.firstPoint, linija.secondPoint, pen, form);
                }
                else if (radBtnKvadar.Checked)
                {
                    kvadar.DrawMovable(startPoint, currPoint, pen, form);
                    kvadar.kvadar.Width = e.X - kvadar.kvadar.X;
                    kvadar.kvadar.Height = e.Y - kvadar.kvadar.Y;
                    kvadar.DrawMovable(startPoint, currPoint, pen, form);
                }
                else if (radBtnElipsa.Checked)
                {
                    elipsa.DrawMovable(startPoint, currPoint, pen, form);
                    elipsa.rectangle.Width = e.X - elipsa.rectangle.X;
                    elipsa.rectangle.Height = e.Y - elipsa.rectangle.Y;
                    elipsa.DrawMovable(startPoint, currPoint, pen, form);
                }
                else if (radBtnKruznica.Checked)
                {
                    kruznica.DrawMovable(startPoint, currPoint, pen, form);
                    kruznica.rectangle.Width = e.X - elipsa.rectangle.X;
                    kruznica.rectangle.Height = kruznica.rectangle.Width;
                    kruznica.DrawMovable(startPoint, currPoint, pen, form);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            Graphics graphics = form.CreateGraphics();

            if (radBtnLinija.Checked)
            {
                linija.DrawMovable(linija.firstPoint, linija.secondPoint, pen, form);
                linija.DrawGraphObj(graphics, pen, linija.firstPoint, linija.secondPoint);
            }
            else if (radBtnKvadar.Checked)
            {
                kvadar.DrawMovable(startPoint, currPoint, pen, form);
                kvadar.DrawGraphObj(graphics, pen, startPoint, currPoint);
            }
            else if (radBtnElipsa.Checked)
            {
                elipsa.DrawMovable(startPoint, currPoint, pen, form);
                elipsa.DrawGraphObj(graphics, pen, startPoint, currPoint);
            }
            else if (radBtnKruznica.Checked)
            {
                kruznica.DrawMovable(startPoint, currPoint, pen, form);
                kruznica.DrawGraphObj(graphics, pen, startPoint, currPoint);
            }
            else if (radBtnPoligon.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    poligon.polygonPoints.Add(new Point(xCoord, yCoord));

                    xCoord = 0;
                    yCoord = 0;
                }
            }
        }

        private void radBtnElipsa_CheckedChanged(object sender, EventArgs e) {}
        private void radBtnKvadar_CheckedChanged(object sender, EventArgs e) {}

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            Graphics graphics = form.CreateGraphics();
            if (radBtnPoligon.Checked && e.Button == MouseButtons.Right)
            {
                poligon.DrawGraphObj(graphics, pen, startPoint, currPoint);
                poligon.polygonPoints.Clear();
            }
        }

    }
}
