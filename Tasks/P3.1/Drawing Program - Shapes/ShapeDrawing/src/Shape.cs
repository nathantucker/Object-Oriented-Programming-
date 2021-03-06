﻿using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Shape
	{
		Color _color;
		float _x, _y;
		int _width, _height;

		bool _selected;

		public Shape ()
		{
			_color = Color.Green;
			_x = _y = 0;
			_width = _height = 100;
		}

		public Color Color {
			get {
				return _color;
			}
			set {
				_color = value;
			}
		}

		public float X {
			get {
				return _x;
			}
			set {
				_x = value;
			}
		}

		public float Y {
			get {
				return _y;
			}
			set {
				_y = value;
			}
		}

		public bool Selected {
			get {
				return _selected;
			}
			set {
				_selected = value;
			}
		}

		public void Draw ()
		{
			SwinGame.FillRectangle (_color, _x, _y, _width, _height);
		}

		public bool IsAt (Point2D pt)
		{
			return SwinGame.PointInRect (pt, _x, _y, _width, _height);
		}

		public void DrawOutline ()
		{
			SwinGame.DrawRectangle (Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
		}
	}
}
