using Avalonia.Controls;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DanceDJPal.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
        }

        public async void OpenMusicLibrary()
        {
            var dialog = new OpenFolderDialog();
            var result = await dialog.ShowAsync(new Window());

            var files = new List<string>();
            if (result != null)
            {
                foreach (string file in Directory.EnumerateFiles(
                    result,
                    "*.mp3",
                    SearchOption.AllDirectories))
                {
                    files.Add(file);
                }
            }
        }

        public void ExitCommand()
        {
            Environment.Exit(0);
        }        
    }
}
