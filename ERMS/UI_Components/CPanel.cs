using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.UI_Components
{
    class CPanel : Panel
    {
        private Rectangle _rect;

        private bool _isDown = false;
        private bool _isRandom = false;

        private Point _mouseLoc = new Point(0, 0);

        private Color _circleColor = Color.LightGreen;

        public CPanel()
        {
            _rect = new Rectangle(new Point(50, 50), new Size(10, 10));

            MouseDown += (sender, e) =>
            {
                _isDown = true;
                _mouseLoc = e.Location;
                Invalidate();
            };
            MouseUp += (sender, e) =>
            {
                _isDown = false;
                Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_isDown)
            {
                _rect.Location = _mouseLoc;
            }

            if (_rect.Width < 200)
            {
                _rect.Width += 5;
                _rect.Height += 5;
            }
            else
            {
                _rect.Width = 0;
                _rect.Height = 0;
            }

            Brush brush = new SolidBrush(_circleColor);

            e.Graphics.FillEllipse(brush, _rect);
        }
    }
}
