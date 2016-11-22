using System;

using AppKit;
using Foundation;

namespace PaintCodeConverter
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Do any additional setup after loading the view.
			convertButton.Activated += delegate
			{
				ButtonAction(null);
			};
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		void ButtonAction(NSObject sender)
		{
			string resultText = mainTextView.TextStorage.Value;
			resultText = resultText.Replace("argb", "Argb");
			resultText = resultText.Replace("left", "Left");
			resultText = resultText.Replace("right", "Right");
			resultText = resultText.Replace("top", "Top");
			resultText = resultText.Replace("width", "Width");
			resultText = resultText.Replace("height", "Height");
			resultText = resultText.Replace("floor", "Floor");
			resultText = resultText.Replace("addOval", "AddOval");
			resultText = resultText.Replace("setStyle", "SetStyle");
			resultText = resultText.Replace("Paint.Style.FILL", "Android.Graphics.Paint.Style.Fill");
			resultText = resultText.Replace("CW", "Cw");
			resultText = resultText.Replace("drawPath", "DrawPath");
			resultText = resultText.Replace("setColor", "Color = new Color");
			resultText = resultText.Replace("moveTo", "MoveTo");
			resultText = resultText.Replace("cubicTo", "CubicTo");
			resultText = resultText.Replace("lineTo", "LineTo");
			resultText = resultText.Replace("close", "Close");
			resultText = resultText.Replace("setFillType", "SetFillType");
			resultText = resultText.Replace("EVEN_ODD", "EvenOdd");
			resultText = resultText.Replace("abs", "Abs");
			resultText = resultText.Replace("restore", "Restore");
			resultText = resultText.Replace("addRect", "AddRect");
			resultText = resultText.Replace("postRotate", "PostRotate");
			resultText = resultText.Replace("postTranslate", "PostTranslate");
			resultText = resultText.Replace("peek", "Peek");
			resultText = resultText.Replace("rotate", "Rotate");
			resultText = resultText.Replace("translate", "Translate");
			resultText = resultText.Replace("save", "Save");
			resultText = resultText.Replace("draw", "Draw");
			resultText = resultText.Replace("clipRect", "ClipRect");
			resultText = resultText.Replace("setTextSize", "TextSize = ");
			resultText = resultText.Replace("setTypeface", "SetTypeface");
			resultText = resultText.Replace("create", "Create");
			resultText = resultText.Replace("getHeight()", "Height");
			resultText = resultText.Replace("getWidth", "GetWidth");
			resultText = resultText.Replace("clipRect", "ClipRect");
			resultText = resultText.Replace("setStrokeWidth", "StrokeWidth = ");
			resultText = resultText.Replace("setStrokeCap", "StrokeCap = ");
			resultText = resultText.Replace("setStrokeMiter", "SetStrokeMiter");
			resultText = resultText.Replace("(Paint.Cap.ROUND)", "Android.Graphics.Paint.Cap.Round");
			resultText = resultText.Replace("Paint.Style.STROKE", "Android.Graphics.Paint.Style.Stroke");
			resultText = resultText.Replace("Typeface.NORMAL", "TypefaceStyle.Normal");
			resultText = resultText.Replace("push", "Push");
			resultText = resultText.Replace("colorByChangingValue", "ColorByChangingValue");
			resultText = resultText.Replace("BLACK", "Black");
			resultText = resultText.Replace("SetStrokeMiter", "StrokeMiter = ");
			resultText = resultText.Replace("PorterDuff.Mode.SRC_ATOP", "PorterDuff.Mode.SrcAtop");
			resultText = resultText.Replace("setXfermode", "SetXfermode");
			resultText = resultText.Replace("Canvas.ALL_SAVE_FLAG", "SaveFlags.All");
			resultText = resultText.Replace("Layout.Alignment.ALIGN_OPPOSITE", "Android.Text.Layout.Alignment.AlignOpposite");
			resultText = resultText.Replace("ALIGN_CENTER", "AlignCenter");
			resultText = resultText.Replace("bottom", "Bottom");
			resultText = resultText.Replace("addRoundRect", "AddRoundRect");
			resultText = resultText.Replace("context.getAssets()", "Context.Assets");
			resultText = resultText.Replace("boolean", "bool");
			convertTextView.TextStorage.SetString(new NSAttributedString(resultText));
		}
	}
}
