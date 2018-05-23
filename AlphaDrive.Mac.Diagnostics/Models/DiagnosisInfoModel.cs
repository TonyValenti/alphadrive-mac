using System;
using Foundation;

namespace AlphaDrive.Mac.Diagnostics.Models
{
    [Register("DiagnosisInfoModel")]
    public class DiagnosisInfoModel : NSObject
    {
        public DiagnosisInfoModel()
        {
        }

        private string _diagnosisTextOutput;

        [Export(nameof(DiagnosisTextOutput))]
        public string DiagnosisTextOutput
        {
            get { return _diagnosisTextOutput; }
            set
            {
                WillChangeValue(nameof(DiagnosisTextOutput));
                _diagnosisTextOutput = value;
                DidChangeValue(nameof(DiagnosisTextOutput));
            }
        }

        public void LoadSettings()
        {
            DiagnosisTextOutput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }

        public void SaveSettings()
        {
            
        }


    }
}
