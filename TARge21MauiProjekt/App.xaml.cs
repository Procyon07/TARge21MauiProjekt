#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.Graphics;
#endif


using Views;

namespace TARge21MauiProjekt;

public partial class App : Application
{

    //const int WindowWidth = 540;
    //const int WindowHeight = 1000;

    public App()
    {
        InitializeComponent();

#if WINDOWS
	Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (Handler, view) => 
		{
			var mauiWindow = Handler.VirtualView;
			var nativeWindow = Handler.PlatformView;
			nativeWindow.Activate();
			IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
			WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
			AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
			appWindow.Resize(new Windows.Graphics.SizeInt32(WindowWidth, WindowHeight));
		});	

#endif

        MainPage = new NavigationPage(new FrontPage());
    }
}
