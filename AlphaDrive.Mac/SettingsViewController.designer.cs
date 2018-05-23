// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AlphaDrive.Mac
{
	[Register ("SettingsViewController")]
	partial class SettingsViewController
	{
		[Outlet]
		AppKit.NSButton btnCancel { get; set; }

		[Outlet]
		AppKit.NSButton btnSave { get; set; }

		[Outlet]
		AppKit.NSButton btnSaveAndClose { get; set; }

		[Outlet]
		AlphaDrive.Mac.MainPaneView MainPane { get; set; }

		[Outlet]
		AlphaDrive.Mac.Views.SourceListView SourceList { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnCancel != null) {
				btnCancel.Dispose ();
				btnCancel = null;
			}

			if (btnSave != null) {
				btnSave.Dispose ();
				btnSave = null;
			}

			if (btnSaveAndClose != null) {
				btnSaveAndClose.Dispose ();
				btnSaveAndClose = null;
			}

			if (MainPane != null) {
				MainPane.Dispose ();
				MainPane = null;
			}

			if (SourceList != null) {
				SourceList.Dispose ();
				SourceList = null;
			}
		}
	}
}
