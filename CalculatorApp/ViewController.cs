using System;

using AppKit;
using Foundation;

namespace CalculatorApp
{
    public partial class ViewController : NSViewController
    {
        
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
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
            }
        }
        string valueOne = "";
        string valueTwo = "";
        string step = "first";
        string operation = "";
        float result = 0;
        public void Solve()
        {
            var Final1 = float.Parse(valueOne);
            var Final2 = float.Parse(valueTwo);
            if (operation == "add")
            { 
                 result = Final1 + Final2;
                
             }
            else if (operation == "subtract")
            {
                result = Final1 - Final2;
            }
            else if (operation == "mult")
            {
                result = Final1 * Final2;
            }
            else if (operation == "divide")
            {
                result = Final1 / Final2;
            }

            infoLabel.StringValue = result.ToString();
        }
        partial void btn_dec(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += ".";
                infoLabel.StringValue += ".";
            }
            else if (step == "second")
            {
                valueTwo += ".";
                infoLabel.StringValue += ".";
            }


        }
        partial void btn_0(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 0;
                infoLabel.StringValue += 0;
            }
            else if (step == "second")
            {
                valueTwo += 0;
                infoLabel.StringValue += 0;
            }
        }
        partial void btn_1(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += "1";
                infoLabel.StringValue += 1;
            }
            else if (step == "second")
            {
                valueTwo += 1;
                infoLabel.StringValue += 1;
            }             
        }
        partial void bnt_2(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 2;
                infoLabel.StringValue += 2;
            }
            else if (step == "second")
            {    
                valueTwo += 2;
                infoLabel.StringValue += 2;
            }
        }

        partial void btn_3(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 3;
                infoLabel.StringValue += 3;
            }
            else if (step == "second")
            {
                valueTwo += 3;
                infoLabel.StringValue += 3;
            }
        }

        partial void btn_4(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 4;
                infoLabel.StringValue += 4;
            }
            else if (step == "second")
            {
                valueTwo += 4;
                infoLabel.StringValue += 4;
            }
        }
        partial void btn_5(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 5;
                infoLabel.StringValue += 5;
            }
            else if (step == "second")
            {
                valueTwo += 5;
                infoLabel.StringValue += 5;
            }
        }
        partial void btn_6(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 6;
                infoLabel.StringValue += 6;
            }
            else if (step == "second")
            {
                valueTwo += 6;
                infoLabel.StringValue += 6;
            }
        }
        partial void btn_7(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 7;
                infoLabel.StringValue += 7;
            }
            else if (step == "second")
            {
                valueTwo += 7;
                infoLabel.StringValue += 7;
            }
        }
        partial void btn_8(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 8;
                infoLabel.StringValue += 8;
            }
            else if (step == "second")
            {
                valueTwo += 8;
                infoLabel.StringValue += 8;
            }
        }
        partial void btn_9(NSObject sender)
        {
            if (step == "first")
            {
                valueOne += 9;
                infoLabel.StringValue += 9;
            }
            else if (step == "second")
            {
                valueTwo += 9;
                infoLabel.StringValue += 9;
            }
        }


        partial void btn_Plus(NSObject sender)
        {
            if (step == "first")
            {
                
                step = "second";
                operation = "add";
                infoLabel.StringValue = valueOne + " + ";
            }
            else if (step == "second")
            {
                Solve();
                operation = "add";
                valueOne = result.ToString();

                valueTwo = "";
                infoLabel.StringValue = valueOne + " + ";
                result = 0;
            }
        }
        partial void btn_Minus(NSObject sender)
        {
            if (step == "first")
            {
                step = "second";
                operation = "subtract";
                infoLabel.StringValue = valueOne + " - ";
            }
            else if (step == "second")
            {
                Solve();
                operation = "subtract";
                valueOne = result.ToString();
                valueTwo = "";
                infoLabel.StringValue = valueOne + " - ";
                result = 0; 
            }
        }

        partial void btn_Mult(NSObject sender)
        {
            if (step == "first")
            {
                step = "second";
                operation = "mult";
                infoLabel.StringValue = valueOne + " * ";
            }
            else if (step == "second")
            {
                Solve();
                operation = "mult";
                valueOne = result.ToString();
                valueTwo = "";
                infoLabel.StringValue = valueOne + " * ";
                result = 0;
            }
        }
        partial void btn_Divide(NSObject sender)
        {
            if (step == "first")
            {
                step = "second";
                operation = "divide";
                infoLabel.StringValue = valueOne + " / ";
            }
            else if (step == "second")
            {
                Solve();
                operation = "divide";
                valueOne = result.ToString();
                valueTwo = "";
                infoLabel.StringValue = valueOne + " / ";
                result = 0;
            }
        }
        partial void btn_Equal(NSObject sender)
        {
            Solve();
        }
        partial void btnReset(NSObject sender)
        {
            valueOne = "";
            valueTwo = "";
            step = "first";
            operation = "";
            result = 0;
            infoLabel.StringValue = "";
        }
    }
}
