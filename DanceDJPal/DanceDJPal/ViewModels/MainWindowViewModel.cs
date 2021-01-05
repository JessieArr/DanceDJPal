using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanceDJPal.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string bpmText;
        public string BPMText
        {
            get => bpmText;
            set => this.RaiseAndSetIfChanged(ref bpmText, value);
        }
        private DateTime _FirstClickTime;
        private int _ClickCount;

        public MainWindowViewModel()
        {
            BPMText = "BPM will appear here.";
        }

        public void TapForBPMCommand()
        {
            if(_FirstClickTime == DateTime.MinValue)
            {
                _FirstClickTime = DateTime.Now;                
            }
            _ClickCount++;
            var timeSinceFirstClick = DateTime.Now - _FirstClickTime;
            var bpm = _ClickCount / timeSinceFirstClick.TotalMinutes;
            BPMText = bpm.ToString() + " BPM";
        }

        public void ResetCommand()
        {
            _ClickCount = 0;
            _FirstClickTime = DateTime.MinValue;
        }
    }
}
