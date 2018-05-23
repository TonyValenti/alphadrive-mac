namespace AlphaDrive.Mac.FileSettings.Models
{
    public interface IFileSettingsModel
    {
        bool DriveMapAttachDriveName { get; set; }
        bool DriveMapEnabledDrive { get; set; }
        bool DriveMapShowAfterLoading { get; set; }
        bool ExtrasShowCreateNewMatter { get; set; }
        bool ExtrasShowLaunchClio { get; set; }
        bool ExtrasShowClientFiles { get; set; }
        bool ExtrasShowClioBills { get; set; }
        bool ExtrasViewClientsClio { get; set; }
        bool ExtrasViewMatterInClio { get; set; }
        string[] DriveLettersList { get; set; }
        string[] OrganizationMattersList { get; set; }

        void LoadSettings();
        void SaveSettings();
    }
}