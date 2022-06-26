// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CalculatorApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField infoLabel { get; set; }

		[Action ("bnt_2:")]
		partial void bnt_2 (Foundation.NSObject sender);

		[Action ("btn_0:")]
		partial void btn_0 (Foundation.NSObject sender);

		[Action ("btn_1:")]
		partial void btn_1 (Foundation.NSObject sender);

		[Action ("btn_3:")]
		partial void btn_3 (Foundation.NSObject sender);

		[Action ("btn_4:")]
		partial void btn_4 (Foundation.NSObject sender);

		[Action ("btn_5:")]
		partial void btn_5 (Foundation.NSObject sender);

		[Action ("btn_6:")]
		partial void btn_6 (Foundation.NSObject sender);

		[Action ("btn_7:")]
		partial void btn_7 (Foundation.NSObject sender);

		[Action ("btn_8:")]
		partial void btn_8 (Foundation.NSObject sender);

		[Action ("btn_9:")]
		partial void btn_9 (Foundation.NSObject sender);

		[Action ("btn_dec:")]
		partial void btn_dec (Foundation.NSObject sender);

		[Action ("btn_Divide:")]
		partial void btn_Divide (Foundation.NSObject sender);

		[Action ("btn_Equal:")]
		partial void btn_Equal (Foundation.NSObject sender);

		[Action ("btn_Minus:")]
		partial void btn_Minus (Foundation.NSObject sender);

		[Action ("btn_Mult:")]
		partial void btn_Mult (Foundation.NSObject sender);

		[Action ("btn_Plus:")]
		partial void btn_Plus (Foundation.NSObject sender);

		[Action ("btnReset:")]
		partial void btnReset (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (infoLabel != null) {
				infoLabel.Dispose ();
				infoLabel = null;
			}
		}
	}
}
