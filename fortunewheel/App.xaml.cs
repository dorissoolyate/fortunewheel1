#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Views;
using Windows.Graphics;
#endif

namespace fortunewheel;

public partial class App : Application
{
    const int WindowWidth = 540;
    const int WindowHeight = 900;
    public App()
    {
        InitializeComponent();

        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
#endif
        });

        // Создаем стартовую страницу и оборачиваем ее в NavigationPage
        MainPage = new NavigationPage(new Views.WelcomePage());
    }
}