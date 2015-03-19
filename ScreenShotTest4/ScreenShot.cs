using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;


namespace ScreenShotTest4
{
	public class ScreenShot
	{
		public ScreenShot ()
		{
		}
		public static void makeScreen() {
			//Create a new bitmap.
			var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
			                               Screen.PrimaryScreen.Bounds.Height,
			                               PixelFormat.Format32bppArgb);
			
			// Create a graphics object from the bitmap.
			var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
				
			// Take the screenshot from the upper left corner to the right bottom corner.
			gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
			                            Screen.PrimaryScreen.Bounds.Y,
			                            0,
			                            0,
			                            Screen.PrimaryScreen.Bounds.Size,
			                            CopyPixelOperation.SourceCopy);
				
			// Save the screenshot to the specified path that the user has chosen.
			bmpScreenshot.Save(DateTime.Now.ToLongTimeString()+".png", ImageFormat.Png);			
		}
	}
}

