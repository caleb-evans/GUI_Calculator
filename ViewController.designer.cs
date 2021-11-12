// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GUICalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField Display { get; set; }

		[Outlet]
		AppKit.NSTextField Display2 { get; set; }

		[Action ("clear:")]
		partial void clear (AppKit.NSButton sender);

		[Action ("Clear:")]
		partial void Clear (AppKit.NSButton sender);

		[Action ("decimalPoint:")]
		partial void decimalPoint (AppKit.NSButton sender);

		[Action ("divide:")]
		partial void divide (AppKit.NSButton sender);

		[Action ("eight:")]
		partial void eight (AppKit.NSButton sender);

		[Action ("equals:")]
		partial void equals (AppKit.NSButton sender);

		[Action ("five:")]
		partial void five (AppKit.NSButton sender);

		[Action ("four:")]
		partial void four (AppKit.NSButton sender);

		[Action ("minus:")]
		partial void minus (AppKit.NSButton sender);

		[Action ("multiply:")]
		partial void multiply (AppKit.NSButton sender);

		[Action ("nine:")]
		partial void nine (AppKit.NSButton sender);

		[Action ("one:")]
		partial void one (AppKit.NSButton sender);

		[Action ("percent:")]
		partial void percent (AppKit.NSButton sender);

		[Action ("plus:")]
		partial void plus (AppKit.NSButton sender);

		[Action ("plusMinus:")]
		partial void plusMinus (AppKit.NSButton sender);

		[Action ("posNeg:")]
		partial void posNeg (AppKit.NSButton sender);

		[Action ("seven:")]
		partial void seven (AppKit.NSButton sender);

		[Action ("six:")]
		partial void six (AppKit.NSButton sender);

		[Action ("three:")]
		partial void three (AppKit.NSButton sender);

		[Action ("two:")]
		partial void two (AppKit.NSButton sender);

		[Action ("zero:")]
		partial void zero (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (Display != null) {
				Display.Dispose ();
				Display = null;
			}

			if (Display2 != null) {
				Display2.Dispose ();
				Display2 = null;
			}
		}
	}
}
