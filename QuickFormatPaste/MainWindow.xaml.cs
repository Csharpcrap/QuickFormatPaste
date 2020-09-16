using NHotkey;
using NHotkey.Wpf;
using System.Windows;
using System.Windows.Input;

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
    }
}
