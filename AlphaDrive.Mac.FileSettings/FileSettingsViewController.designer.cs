// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AlphaDrive.Mac.FileSettings
{
    [Register ("FileSettingsViewController")]
    partial class FileSettingsViewController
    {
        [Outlet]
        AppKit.NSButton driveMapAttachDrive { get; set; }

        [Outlet]
        AppKit.NSButton driveMappingEnableDrive { get; set; }

        [Outlet]
        AppKit.NSButton driveMapShowAfterLoading { get; set; }

        [Outlet]
        AppKit.NSButton extraCreateNewMatter { get; set; }

        [Outlet]
        AppKit.NSButton extraLaunchClio { get; set; }

        [Outlet]
        AppKit.NSButton extraShowClientFiles { get; set; }

        [Outlet]
        AppKit.NSButton extrasShowClioBills { get; set; }

        [Outlet]
        AppKit.NSButton extraViewClientClo { get; set; }

        [Outlet]
        AppKit.NSButton extraViewMatterInClio { get; set; }

        [Outlet]
        AppKit.NSPopUpButton matterOrganizationMatterList { get; set; }

        [Outlet]
        AppKit.NSPopUpButton popupDriveLetter { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (extraCreateNewMatter != null) {
                extraCreateNewMatter.Dispose ();
                extraCreateNewMatter = null;
            }

            if (driveMappingEnableDrive != null) {
                driveMappingEnableDrive.Dispose ();
                driveMappingEnableDrive = null;
            }

            if (driveMapAttachDrive != null) {
                driveMapAttachDrive.Dispose ();
                driveMapAttachDrive = null;
            }

            if (driveMapShowAfterLoading != null) {
                driveMapShowAfterLoading.Dispose ();
                driveMapShowAfterLoading = null;
            }

            if (popupDriveLetter != null) {
                popupDriveLetter.Dispose ();
                popupDriveLetter = null;
            }

            if (matterOrganizationMatterList != null) {
                matterOrganizationMatterList.Dispose ();
                matterOrganizationMatterList = null;
            }

            if (extraShowClientFiles != null) {
                extraShowClientFiles.Dispose ();
                extraShowClientFiles = null;
            }

            if (extrasShowClioBills != null) {
                extrasShowClioBills.Dispose ();
                extrasShowClioBills = null;
            }

            if (extraLaunchClio != null) {
                extraLaunchClio.Dispose ();
                extraLaunchClio = null;
            }

            if (extraViewClientClo != null) {
                extraViewClientClo.Dispose ();
                extraViewClientClo = null;
            }

            if (extraViewMatterInClio != null) {
                extraViewMatterInClio.Dispose ();
                extraViewMatterInClio = null;
            }
        }
    }
}
