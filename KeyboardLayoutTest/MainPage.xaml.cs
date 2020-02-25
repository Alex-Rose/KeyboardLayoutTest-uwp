using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KeyboardLayoutTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CoreTextServicesManager.GetForCurrentView().InputLanguageChanged += MainPage_InputLanguageChanged;
        }

        private void MainPage_InputLanguageChanged(CoreTextServicesManager sender, object args)
        {
            Debug.WriteLine(CoreTextServicesManager.GetForCurrentView().InputLanguage.DisplayName);
            Debug.WriteLine(CoreTextServicesManager.GetForCurrentView().InputLanguage.LanguageTag);
            Debug.WriteLine(CoreTextServicesManager.GetForCurrentView().InputLanguage.NativeName);
            Debug.WriteLine(CoreTextServicesManager.GetForCurrentView().InputLanguage.Script);
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Debug.WriteLine(String.Format("Key: {0}, WasKeyDown: {1}, IsExtendedKey: {2}, IsKeyReleased {3}. IsMenuKeyDown: {4}, RepeatCount: {5}, ScanCode: {6}", 
                (int)e.Key, e.KeyStatus.WasKeyDown, e.KeyStatus.IsExtendedKey, e.KeyStatus.IsKeyReleased, e.KeyStatus.IsMenuKeyDown, e.KeyStatus.RepeatCount, e.KeyStatus.ScanCode));
        }

        private void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}
