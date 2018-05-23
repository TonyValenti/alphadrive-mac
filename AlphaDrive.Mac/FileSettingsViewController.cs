// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using AlphaDrive.Mac.FileSettings.Models;

namespace AlphaDrive.Mac
{
	public partial class FileSettingsViewController : NSViewController
	{
		public FileSettingsViewController (IntPtr handle) : base (handle)
		{
		}

        private FileSettingsModel _fileSettings = new FileSettingsModel();

        [Export("FileSettings")]
        public FileSettingsModel FileSettings
        {
            get { return _fileSettings; }
            set
            {
                WillChangeValue(nameof(FileSettings));
                _fileSettings = value;
                DidChangeValue(nameof(FileSettings));
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            FileSettings = new FileSettingsModel();
            FileSettings.LoadSettings();


            popupDriveLetter.RemoveAllItems();
            popupDriveLetter.AddItems(FileSettings.DriveLettersList);


            matterOrganizationMatterList.RemoveAllItems();
            matterOrganizationMatterList.AddItems(FileSettings.OrganizationMattersList);
        }
    }
}
