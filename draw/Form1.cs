using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draw
{
    
    public partial class Form1 : Form
    {
        enum Category
        {
            CurveCategory, CloseCurveCategory, PolylineCategory, PolygonCategory, PickCategory, CircleCategory,
            RectCategory, EllipseCategory, TextCategory, PalmCategory,
            LineCategory
        };//Line, Rect, Text,

        public Form1()
        {
            InitializeComponent();
            isDraw = false;
            this.panel1.MouseDown += new MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(this.Panel1_MouseUp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            shape = Category.RectCategory;
        }

      

        private void ellipsepButton_Click(object sender, EventArgs e)
        {
            shape = Category.EllipseCategory;
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!isDraw) return;
            // Create a Graphics object for the Control.
            Graphics g = panel1.CreateGraphics();
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);
            switch (shape)
            {
                case Category.EllipseCategory:
                    {
                        g.DrawEllipse(blackPen, startPoint.X, startPoint.Y, (endPoint.X - startPoint.X), endPoint.Y - startPoint.Y);
                        break;
                    }
                case Category.RectCategory:
                    {
                        g.DrawRectangle(blackPen, startPoint.X, startPoint.Y, (endPoint.X - startPoint.X), endPoint.Y - startPoint.Y);
                        break;
                    }
                case Category.LineCategory:
                    {
                        g.DrawLine(blackPen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
                        break;
                    }
            }
            // Clean up the Graphics object.
            g.Dispose();
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            shape = Category.LineCategory;
        }
    }
}
