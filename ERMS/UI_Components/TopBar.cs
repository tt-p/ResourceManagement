using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP_Group_27.ERMS.UI_Components
{
    class TopBar : Panel
    {

        private Point _mouseLoc;

        private CloseBtn _btnClose;
        private MinBtn _btnMin;

        private Color _color = Color.FromArgb(4, 12, 12);
        private Color _textColor = Color.White;

        private bool _minBtn = true;

        private Form _form;

        public TopBar()
        {
            Dock = DockStyle.Top;

            Height = 30;
            BackColor = _color;

            _btnClose = new CloseBtn();
            _btnMin = new MinBtn();

            _btnClose.ButtonColor = BackColor;
            _btnMin.ButtonColor = BackColor;

            _btnClose.Width = 30;
            _btnMin.Width = 30;

            _btnClose.Click += (sender, e) =>
            {
                Program.exit();
            };

            _btnMin.Click += (sender, e) =>
            {
                _form.WindowState = FormWindowState.Minimized;
            };

            Controls.Add(_btnClose);
            Controls.Add(_btnMin);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            BackColor = _color;

            _btnClose.ButtonColor = BackColor;
            _btnMin.ButtonColor = BackColor;

            _btnMin.Visible = _minBtn;

            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(_textColor);

            SizeF stringSize = g.MeasureString(_form.Text, _form.Font);

            g.DrawString(_form.Text , _form.Font, brush, 5, 25 - stringSize.Height);

            _btnClose.Location = new Point(Width - _btnClose.Width - 5, 5);
            _btnMin.Location = new Point(Width - _btnClose.Width -_btnMin.Width - 5, 5);

            brush.Dispose();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _mouseLoc = new Point (-e.Location.X, -e.Location.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(_mouseLoc.X, _mouseLoc.Y);
                _form.Location = mousePose;
            }
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

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public bool MinBtn
        {
            get => _minBtn;
            set
            {
                _minBtn = value;
                Invalidate();
            }
        }

        public Form form
        {
            get => _form;
            set
            {
                _form = value;
            }
        }
    }
}
