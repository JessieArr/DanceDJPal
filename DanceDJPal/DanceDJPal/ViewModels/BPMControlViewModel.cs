using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DanceDJPal.ViewModels
{
    public class BPMControlViewModel : ViewModelBase
    {
        private string bpmText;
        public string BPMText
        {
            get => bpmText;
            set => this.RaiseAndSetIfChanged(ref bpmText, value);
        }
        private DateTime _FirstClickTime;
        private int _ClickCount;

        public BPMControlViewModel()
        {
            ResetBPMText();
        }

        public void TapForBPMCommand()
        {
            if (_FirstClickTime == DateTime.MinValue)
            {
                _FirstClickTime = DateTime.Now;
                return;
            }
            _ClickCount++;
            var timeSinceFirstClick = DateTime.Now - _FirstClickTime;
            var bpm = _ClickCount / timeSinceFirstClick.TotalMinutes;
            
            var bpmString = bpm.ToString("0.0");
            BPMText = $"{_ClickCount} clicks in {timeSinceFirstClick.TotalSeconds} minutes - {bpmString} BPM";
        }

        public void ResetCommand()
        {
            _ClickCount = 0;
            _FirstClickTime = DateTime.MinValue;
            ResetBPMText();
        }

        private void ResetBPMText()
        {
            BPMText = "BPM will appear here.";
        }
    }
}
