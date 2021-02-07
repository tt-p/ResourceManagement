using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.UI_Components
{
    class CirclePanel : Panel
    {

        private List<Rectangle> _rects;

        private bool _isDown = false;
        private bool _isRandom = false;

        private Point _mouseLoc = new Point(0, 0);

        private Color _circleColor = Color.LightGreen;

        public CirclePanel()
        {
            _rects = new List<Rectangle>();

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
                Rectangle rect = new Rectangle(_mouseLoc, new Size(0, 0));
                _rects.Add(rect);
            }

            updateRects();

            foreach (Rectangle rect in _rects)
            {
                Random rnd = new Random();
                int alpha = (rect.Width * 100 / 256);
                Color c1 = Color.FromArgb(alpha, _circleColor.R, _circleColor.G, _circleColor.B);
                Color c = _isRandom ? Color.FromArgb(alpha, rnd.Next(256), rnd.Next(256), rnd.Next(256)) : c1;
                Brush brush = new SolidBrush(c);

                e.Graphics.FillEllipse(brush, rect);
                brush.Dispose();
            }
        }

        private void updateRects()
        {
            List<Rectangle> toRemove = new List<Rectangle>();

            for (int i = 0; i < _rects.Count(); i++)
            {
                Rectangle temp = _rects[i];

                if (_rects[i].Width >= 100)
                {
                    toRemove.Add(temp);
                }

            }

            foreach (Rectangle rect in toRemove)
            {
                _rects.Remove(rect);
            }

            for (int i = 0; i < _rects.Count(); i++)
            {
                Rectangle temp = new Rectangle(_rects[i].Location, new Size(_rects[i].Width + 8, _rects[i].Height + 8));
                temp.Location = new Point(temp.X - 4, temp.Y - 4);
                _rects[i] = temp;
            }
        }

        public Color CircleColor
        {
            get => _circleColor;
            set
            {
                _circleColor = value;
                Invalidate();
            }
        }

        public bool RandomCircleColor
        {
            get => _isRandom;
            set
            {
                _isRandom = value;
                Invalidate();
            }
        }

    }
}
