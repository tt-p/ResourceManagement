using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.UI_Components
{
    class ColorPanel : Panel
    {

        private bool _isHover = false;
        private Color _color = Color.FromArgb(21, 64, 56);
        private Point _mouseLoc = new Point(0,0);

        public ColorPanel()
        {
            DoubleBuffered = true;

            MouseEnter += (sender, e) =>
            {
                _isHover = true;
                Invalidate();
            };

            MouseMove += (snder, e) =>
            {
                _mouseLoc = e.Location;

                if ((e.X % 2 == 0) && (e.Y % 2 == 0))
                    Invalidate();
            };

            MouseLeave += (sender, e) =>
            {
                _isHover = false;
                Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int red = (_mouseLoc.X * 256) / 900;
            int green = (_mouseLoc.Y * 256) / 500 ;
            int blue = red/2 + green/2;
            BackColor = _isHover ? Color.FromArgb(red % 256, green % 256, blue % 256) : _color;
        }

        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                Invalidate();
            }
        }
    }
}
