using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class DraggableForm : Form
    {
        private bool bIsDragging = false;
        private Point startPoint = new Point(0, 0);
        public DraggableForm()
        {
            InitializeComponent();
        }
        private void DraggableForm_MouseDown(object sender, MouseEventArgs e)
        {
            bIsDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void DraggableForm_MouseUp(object sender, MouseEventArgs e)
        {
            bIsDragging = false;
        }

        private void DraggableForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (bIsDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
    }
}
