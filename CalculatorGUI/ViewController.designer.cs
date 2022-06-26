// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CalculatorGUI
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField txtResult { get; set; }

		[Action ("btnFive_Click:")]
		partial void btnFive_Click (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtResult != null) {
				txtResult.Dispose ();
				txtResult = null;
			}
		}
	}
}
