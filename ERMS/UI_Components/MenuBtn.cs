using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.UI_Components
{
    class MenuBtn : Button
    {
        private Color _color = Color.FromArgb(10, 30, 28);
        private Color _hover = Color.FromArgb(38, 48, 46);
        private Color _down = Color.White;
        private Color _textColor = Color.Black;

        private bool _isHover = false;
        private bool _isDown = false;

        public MenuBtn()
        {
            FlatStyle = FlatStyle.Flat;
            DoubleBuffered = true;

            MouseEnter += (sender, e) =>
            {
                _isHover = true;
                Invalidate();
            };

            MouseLeave += (sender, e) =>
            {
                _isHover = false;
                Invalidate();
            };

            MouseDown += (sender, e) =>
            {
                _isDown = true;
                Invalidate();
            };

            MouseUp += (sender, e) =>
            {
                _isDown = false;
                Invalidate();
            };

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;

            Brush brush = _isDown ? new SolidBrush(_down) : new SolidBrush(_isHover ? _hover : _color);

            g.FillRectangle(brush, 0, 0, Width, Height);

            brush.Dispose();

            brush = new SolidBrush(_textColor);

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }

        public Color ButtonColor
        {
            get => _color;
            set
            {
                _color = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _hover;
            set
            {
                _hover = value;
                Invalidate();
            }
        }

        public Color OnMouseDownButtonColor
        {
            get => _down;
            set
            {
                _down = value;
                Invalidate();
            }
        }

    }
}
