using System;
using Foundation;

namespace AlphaDrive.Mac.FileSettings.Models
{
    [Register("FileSettingsModel")]
    public class FileSettingsModel : NSObject, IFileSettingsModel
    {
        public FileSettingsModel()
        {
        }

        private bool _driveMapAttachDrive;

        [Export(nameof(DriveMapAttachDriveName))]
        public bool DriveMapAttachDriveName
        {
            get { return _driveMapAttachDrive; }
            set
            {
                WillChangeValue(nameof(DriveMapAttachDriveName));
                _driveMapAttachDrive = value;
                DidChangeValue(nameof(DriveMapAttachDriveName));
            }
        }

        private bool _driveMapEnabledDrive;

        [Export(nameof(DriveMapEnabledDrive))]
        public bool DriveMapEnabledDrive
        {
            get { return _driveMapEnabledDrive; }
            set
            {
                WillChangeValue(nameof(DriveMapEnabledDrive));
                _driveMapEnabledDrive = value;
                DidChangeValue(nameof(DriveMapEnabledDrive));
            }
        }

        private bool _driveMapShowAfterLoading;

        [Export(nameof(DriveMapShowAfterLoading))]
        public bool DriveMapShowAfterLoading
        {
            get { return _driveMapShowAfterLoading; }
            set
            {
                WillChangeValue(nameof(DriveMapShowAfterLoading));
                _driveMapShowAfterLoading = value;
                DidChangeValue(nameof(DriveMapShowAfterLoading));
            }
        }

        private bool _extrasShowCreateNewMatter;

        [Export(nameof(ExtrasShowCreateNewMatter))]
        public bool ExtrasShowCreateNewMatter
        {
            get { return _extrasShowCreateNewMatter; }
            set
            {
                WillChangeValue(nameof(ExtrasShowCreateNewMatter));
                _extrasShowCreateNewMatter = value;
                DidChangeValue(nameof(ExtrasShowCreateNewMatter));
            }
        }

        private bool _extrasShowLaunchClio;
        [Export(nameof(ExtrasShowLaunchClio))]
        public bool ExtrasShowLaunchClio
        {
            get { return _extrasShowLaunchClio; }
            set
            {
                WillChangeValue(nameof(ExtrasShowLaunchClio));
                _extrasShowLaunchClio = value;
                DidChangeValue(nameof(ExtrasShowLaunchClio));
            }
        }

        private bool _extrasShowClientFiles;
        [Export(nameof(ExtrasShowClientFiles))]
        public bool ExtrasShowClientFiles
        {
            get { return _extrasShowClientFiles; }
            set
            {
                WillChangeValue(nameof(ExtrasShowClientFiles));
                _extrasShowClientFiles = value;
                DidChangeValue(nameof(ExtrasShowClientFiles));
            }
        }

        private bool _extrasShowClioBills;

        [Export(nameof(ExtrasShowClioBills))]
        public bool ExtrasShowClioBills
        {
            get { return _extrasShowClioBills; }
            set
            {
                WillChangeValue(nameof(ExtrasShowClioBills));
                _extrasShowClioBills = value;
                DidChangeValue(nameof(ExtrasShowClioBills));
            }
        }

        private bool _extrasViewClientsClio;
        [Export(nameof(ExtrasViewClientsClio))]
        public bool ExtrasViewClientsClio
        {
            get { return _extrasViewClientsClio; }
            set
            {
                WillChangeValue(nameof(ExtrasViewClientsClio));
                _extrasViewClientsClio = value;
                DidChangeValue(nameof(ExtrasViewClientsClio));
            }
        }

        private bool _extrasViewMatterInClio;
        [Export(nameof(ExtrasViewMatterInClio))]
        public bool ExtrasViewMatterInClio
        {
            get { return _extrasViewMatterInClio; }
            set
            {
                WillChangeValue(nameof(ExtrasViewMatterInClio));
                _extrasViewMatterInClio = value;
                DidChangeValue(nameof(ExtrasViewMatterInClio));
            }
        }

        private string[] _driveLettersList;
        [Export(nameof(DriveLettersList))]
        public string[] DriveLettersList
        {
            get { return _driveLettersList; }
            set
            {
                WillChangeValue(nameof(DriveLettersList));
                _driveLettersList = value;
                DidChangeValue(nameof(DriveLettersList));
            }
        }

        private string[] _organizationMattersList;
        [Export(nameof(OrganizationMattersList))]
        public string[] OrganizationMattersList
        {
            get { return _organizationMattersList; }
            set
            {
                WillChangeValue(nameof(OrganizationMattersList));
                _organizationMattersList = value;
                DidChangeValue(nameof(OrganizationMattersList));
            }
        }

        public void LoadSettings()
        {
            // some dummy load

            this.DriveMapEnabledDrive = true;
            this.ExtrasShowLaunchClio = true;
            this.ExtrasViewMatterInClio = true;
            this.DriveMapShowAfterLoading = true;

            this.OrganizationMattersList = new string[] {
                "Status > Client > Matter number and Matter description",
                "Status > Matter description",
                "Status > Matter number",
                "Status > Matter number and Matter description",
                "Status > Client > Matter description and Matter number",
                "Attorney > Status > Matter number",
            };
            this.DriveLettersList = new string[] {
                "Drive A:",
                "Drive B:",
                "Drive C:",
                "Drive D:", 
            };
        }

        public  void SaveSettings()
        {
            
        }       
    }
}
