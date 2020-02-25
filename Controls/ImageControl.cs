// 
// Rika
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Rika.Controls
{
    public partial class ImagePanel : Panel
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Bitmap _backBuffer = null;
        private Bitmap _image = null;
        private int _scale = 1;
        private bool _centered = false;

        /// <summary>
        /// Image to draw, cached to a backbuffer to reduce flickering and offer smooth scrolling
        /// </summary>
        public virtual Bitmap Image
        {
            get { return _image; }
            set
            {
                if (_image != null)
                    _image.Dispose();

                _image = value;

                // If there is an image, set the correct resolution
                if (_image != null)
                {
                    // Create graphics to ensure the proper dpi is used
                    Graphics gfx = this.CreateGraphics();
                    _image.SetResolution(gfx.DpiX, gfx.DpiY);
                    gfx.Dispose();
                }

                // Update
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Back color of the control
        /// </summary>
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// Fore color of the control
        /// </summary>
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                UpdateBackBuffer();
            }
        }

        /// <summary>
        /// The scale amount to draw the image
        /// </summary>
        public int ImageScale
        {
            get { return _scale; }
            set { _scale = value < 1 ? 1 : value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// If centering the image within the control, or drawing at top-left corner
        /// </summary>
        public bool Centered
        {
            get { return _centered; }
            set { _centered = value; UpdateBackBuffer(); }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        public ImagePanel()
        {
            InitializeComponent();

            // Set-up panel
            AutoScroll = true;

            // Set control style
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, true);

            // Update the backbuffer
            UpdateBackBuffer();
        }

        /// <summary>
        /// On control paint
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (_backBuffer == null)
                return;

            if (!Enabled)
            {
                DrawDisabled(e.Graphics);
                return;
            }

            Rectangle src = new Rectangle(0, 0, _backBuffer.Width, _backBuffer.Height);
            using (Bitmap image = _backBuffer.Clone(src, _backBuffer.PixelFormat))
            {
                Point srcPoint = GetTranslatePoint(Point.Empty);
                AutoScrollMinSize = _image != null ? new Size(_image.Width * _scale, _image.Height * _scale) : new Size(_backBuffer.Width, _backBuffer.Height);
                e.Graphics.Clear(Color.White);
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.ScaleTransform(_scale, _scale);
                e.Graphics.DrawImage(image, ClientRectangle, srcPoint.X, srcPoint.Y, ClientSize.Width, ClientSize.Height, GraphicsUnit.Pixel);
            }
        }

        /// <summary>
        /// On client size changed
        /// </summary>
        protected override void OnClientSizeChanged(EventArgs e)
        {
            UpdateBackBuffer();
        }

        /// <summary>
        /// On scroll
        /// </summary>
        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);

            Invalidate();
        }

        /// <summary>
        /// On enter
        /// </summary>
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            // Allows for wheel scrolling
            Focus();
        }

        /// <summary>
        /// On mouse down
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Allows for wheel scrolling
            Focus();
        }

        /// <summary>
        /// Updates the backbuffer
        /// </summary>
        public void UpdateBackBuffer()
        {
            Graphics gfx = null;

            if (_backBuffer != null)
                _backBuffer.Dispose();

            if (_image != null)
            {
                Size backBufferSize = CalculateSize(_image.Width, _image.Height);
                _backBuffer = new Bitmap(backBufferSize.Width, backBufferSize.Height, PixelFormat.Format32bppPArgb);
                gfx = Graphics.FromImage(_backBuffer);
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    gfx.FillRectangle(brush, new Rectangle(GetPoint(), _image.Size));
                    gfx.DrawImage(_image, GetPoint());
                }
            }
            else
            {
                _backBuffer = new Bitmap(ClientSize.Width < 1 ? 1 : ClientSize.Width, ClientSize.Height < 1 ? 1 : ClientSize.Height, PixelFormat.Format32bppPArgb);
            }

            if (gfx != null)
                gfx.Dispose();

            // Flip to screen
            Invalidate();
        }

        /// <summary>
        /// Gets the image origin point for centering primarily
        /// </summary>
        /// <returns>Image origin position</returns>
        private Point GetPoint()
        {
            int xOffset = ((_image.Width * _scale) / 2) + _scale > 1 ? (_image.Width / 2) : 0;
            int yOffset = ((_image.Height * _scale) / 2) + _scale > 1 ? (_image.Height / 2) : 0;
            int x = ((ClientSize.Width / _scale) / 2) - xOffset;
            int y = ((ClientSize.Height / _scale) / 2) - yOffset;
            return !_centered ? Point.Empty : new Point(_image.Width * _scale > ClientSize.Width ? 0 : x, _image.Height * _scale > ClientSize.Height ? 0 : y);
        }

        /// <summary>
        /// Translates a point with scaling and scrolling values considered
        /// </summary>
        /// <param name="point">Point to translate</param>
        /// <returns>A Translated point</returns>
        public Point GetTranslatePoint(Point point)
        {
            return new Point((point.X - AutoScrollPosition.X) / (_scale == 0 ? 1 : _scale), (point.Y - AutoScrollPosition.Y) / (_scale == 0 ? 1 : _scale));
        }

        /// <summary>
        /// Gets the backbuffer size
        /// </summary>
        public Size CalculateSize(int width, int height)
        {
            // New backbuffer size
            Size backBufferSize = new Size(width, height);

            // Set the backbuffer size
            if (backBufferSize.Width < ClientSize.Width)
                backBufferSize.Width = ClientSize.Width;

            if (backBufferSize.Height < ClientSize.Height)
                backBufferSize.Height = ClientSize.Height;

            // Return backbuffer size
            return backBufferSize;
        }

        /// <summary>
        /// Draws the control in disabled state
        /// </summary>
        /// <param name="gfx">GDI+ context used to draw the title</param>
        public void DrawDisabled(Graphics gfx)
        {
            gfx.FillRectangle(SystemBrushes.ControlDark, ClientRectangle);
        }
    }
}
