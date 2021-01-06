using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DanceDJPal.ViewModels;

namespace DanceDJPal.Views
{
    public class BPMControl : UserControl
    {
        public BPMControl()
        {
            this.DataContext = new BPMControlViewModel();
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
