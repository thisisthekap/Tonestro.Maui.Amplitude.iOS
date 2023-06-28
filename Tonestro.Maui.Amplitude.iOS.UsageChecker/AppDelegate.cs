using Security;
using Xunit.Runners;

namespace Tonestro.Maui.Amplitude.iOS.UsageChecker;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();
        var uiLabel = new UILabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = "No test failures so far",
            AutoresizingMask = UIViewAutoresizing.All,
        };
        vc.View!.AddSubview(uiLabel);
        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        var testRunner = AssemblyRunner.WithoutAppDomain(GetType().Assembly.Location);
        bool testFailed = false;
        testRunner.OnTestFailed += info =>
        {
            testFailed = true;
            var message = $"TEST {info.TestDisplayName} FAILED: {info.ExceptionMessage}";
            BeginInvokeOnMainThread(() => uiLabel.Text = message);
            Console.WriteLine(message);
        };
        testRunner.OnExecutionComplete += info =>
        {
            if (!testFailed)
            {
                var message = $"total={info.TotalTests} skipped={info.TestsSkipped} failed={info.TestsFailed}";
                BeginInvokeOnMainThread(() => uiLabel.Text = message);
                Console.WriteLine(message);
            }
        };

        testRunner.Start();

        return true;
    }
}