using AppKit;
using Foundation;

namespace AlphaDrive.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            //mainWindowController = new MainWindowController();
            //mainWindowController.Window.MakeKeyAndOrderFront(this);

            //var rotation = new SettingsViewController();
            //rotation.Window.MakeKeyAndOrderFront(this);

            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
