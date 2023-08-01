using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace YoloAnnotate
{
	public class SplitButton : Button
	{
		Point mMousePoint;

		public event EventHandler ArrowClick;

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			mMousePoint = e.Location;
		}

		protected override void OnClick(EventArgs e)
		{
			if (mMousePoint.X < this.Width - (this.Padding.Right - 1))
			{
				base.OnClick(e);
			}
			else
			{
				ArrowClick?.Invoke(this, e);
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			this.Invalidate();
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);

			this.Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			int start = this.Width - this.Padding.Right;

			using (Pen p = new Pen(BackColor, 1))
			{
				if (this.Focused)
				{
					e.Graphics.DrawLine(p, start, 3, start, this.Height - 3 - 1);
				}
				else
				{
					e.Graphics.DrawLine(p, start, 2, start, this.Height - 2 - 1);
				}
			}

			Point mid = new Point(start - 1 + (int)(this.Padding.Right * 0.5f), (int)(this.Height * 0.5f));

			e.Graphics.FillPolygon(Brushes.Black, new PointF[] { Point.Add(mid, new Size(-3, -2)), Point.Add(mid, new Size(3, -2)), Point.Add(mid, new Size(0, 3)) }, FillMode.Alternate);
		}
	}
}
