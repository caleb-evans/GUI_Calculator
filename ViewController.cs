using System;

using AppKit;
using Foundation;

namespace GUICalculator
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

        Solver a = new Solver();




        partial void clear(AppKit.NSButton sender)
        {
            Display.StringValue = "";
            Display2.StringValue = "";
            a.Clear();
        }

        partial void decimalPoint(AppKit.NSButton sender)
        {
            Display.StringValue += '.';
            a.Accumulate(".");
        }

        partial void divide(AppKit.NSButton sender)
        {
            Display.StringValue += '/';
            a.Accumulate("/");

        }

        partial void eight(AppKit.NSButton sender)
        {
            Display.StringValue += '8';
            a.Accumulate("8");

        }

        partial void equals(AppKit.NSButton sender)
        {
            Display2.StringValue = a.Solve().ToString();
        }

        partial void five(AppKit.NSButton sender)
        {
            Display.StringValue += '5';
            a.Accumulate("5");

        }

        partial void four(AppKit.NSButton sender)
        {
            Display.StringValue += '4';
            a.Accumulate("4");

        }

        partial void minus(AppKit.NSButton sender)
        {
            Display.StringValue += '-';
            a.Accumulate("-");

        }

        partial void multiply(AppKit.NSButton sender)
        {
            Display.StringValue += '*';
            a.Accumulate("*");

        }

        partial void nine(AppKit.NSButton sender)
        {
            Display.StringValue += '9';
            a.Accumulate("9");

        }

        partial void one(AppKit.NSButton sender)
        {
            Display.StringValue += '1';
            a.Accumulate("1");

        }

        partial void percent(AppKit.NSButton sender)
        {
            Display.StringValue += '%';
            a.Accumulate("%");

        }

        partial void plus(AppKit.NSButton sender)
        {
            Display.StringValue += '+';
            a.Accumulate("+");

        }

        partial void posNeg(AppKit.NSButton sender)
        {
            Display.StringValue += '-';
            a.Accumulate("-");

        }

        partial void seven(AppKit.NSButton sender)
        {
            Display.StringValue += '7';
            a.Accumulate("7");

        }

        partial void six(AppKit.NSButton sender)
        {
            Display.StringValue += '6';
            a.Accumulate("6");

        }

        partial void three(AppKit.NSButton sender)
        {
            Display.StringValue += '3';
            a.Accumulate("3");

        }

        partial void two(AppKit.NSButton sender)
        {
            Display.StringValue += '2';
            a.Accumulate("2");

        }

        partial void zero(AppKit.NSButton sender)
        {
            Display.StringValue += '0';
            a.Accumulate("0");

        }
    }
}