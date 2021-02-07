using System;
using System.Drawing;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.UI_Components
{
    class CloseBtn : Button
    {
        private Color _buttonColor = Color.FromArgb(4, 12, 12);
        private Color _onHoverButtonColor = Color.Red;

        private Color _textColor = Color.LightGray;
        private Color _onHoverTextColor = Color.White;

        private bool _isHovering;

        public CloseBtn()
        {
            this.Width = 20;
            this.Height = 20;

            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

            g.FillRectangle(brush, 0, 0, Width, Height);


            brush.Dispose();

            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

            Text = "X";

            this.Font = new Font("Myriad Pro", 10, FontStyle.Regular);

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }
        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
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
        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
    }
}
