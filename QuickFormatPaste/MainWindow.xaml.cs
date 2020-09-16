using NHotkey;
using NHotkey.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace QuickFormatPaste
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HotkeyManager.Current.AddOrReplace("Open", Key.C, ModifierKeys.Alt, OnHotOpen);
            HotkeyManager.Current.AddOrReplace("Close", Key.X, ModifierKeys.Alt, OnHotClose);
            Hide();
        }
        
        private void OnHotOpen(object sender, HotkeyEventArgs e)
        {
            Show();
        }

        private void OnHotClose(object sender, HotkeyEventArgs e)
        {
            Hide();
        }

        private void OnClose(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        

        private void MenuMouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Color.FromArgb(0xFF, 128, 0, 128));
        }

        private void MenuMouseLeave(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Color.FromArgb(0xFF, 75, 0, 130));
        }
    }
}
