using System;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;

namespace osk
{
    /// <summary>
    /// Interaction logic for NumberKeyboardWindow.xaml
    /// </summary>
    public partial class NumberKeyboardWindow : Window
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int GWL_EXSTYLE = -20;
        public NumberKeyboardWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(1);
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
                        Left = (Screen.PrimaryScreen.Bounds.Size.Width / 2) - 222d;
                        Top = Screen.PrimaryScreen.Bounds.Size.Height - 358d;

                    });
                    Thread.Sleep(1000);
                }
            });
            checkWidowSize.IsBackground = true;
            checkWidowSize.Start();
        }
    }
}
