using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Interop;
using osk.KeyboardLayout;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Threading;
using System.Net;
using System.IO;
using System.Text;
using UIAutomationClient;
using System.Diagnostics;
using System.Linq;

namespace osk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int GWL_EXSTYLE = -20;

        public static NumberKeyboardWindow numberKeyboardWindow;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(0);
            numberKeyboardWindow = new NumberKeyboardWindow();
            SourceInitialized += (s, e) =>
            {
                var interopHelper = new WindowInteropHelper(this);
                int exStyle = GetWindowLong(interopHelper.Handle, GWL_EXSTYLE);
                SetWindowLong(interopHelper.Handle, GWL_EXSTYLE, exStyle | WS_EX_NOACTIVATE);
            };
            Thread checkWidowSize = new Thread(() =>
            {
                while (true)
                {
                    App.Current.Dispatcher.BeginInvoke(() =>
                    {
                        Left = (Screen.PrimaryScreen.Bounds.Size.Width / 2) - 540;
                        Top = Screen.PrimaryScreen.Bounds.Size.Height - 370;

                    });
                    Thread.Sleep(1000);
                }
            });
            checkWidowSize.IsBackground = true;
            checkWidowSize.Start();
        }
    }
}
