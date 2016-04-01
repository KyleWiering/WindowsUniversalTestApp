using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsUniversalTestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private InputMaster InputMaster;

        public MainPage()
        {
            this.InitializeComponent();
            InputMaster = new InputMaster();
            InputMaster.SystemTextBox = SystemTextBox;
        }

        private void Heading_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void SystemTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string text = InputTextBox.Text;
            if (text.Length > 0)
            {
                SystemTextBox.Text += "\nYou: " + text;
                InputTextBox.Text = "";
                InputMaster.TalkToTheSystem(text);
            }
        }

        private void SystemTextBox_Loading(FrameworkElement sender, object args)
        {
            SystemTextBox.Text = "System Initializing...";
        }

        private void SystemTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            SystemTextBox.Text = "You are in a small room.";
        }
    }
}
