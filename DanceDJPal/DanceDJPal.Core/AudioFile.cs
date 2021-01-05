using System;

namespace DanceDJPal.Core
{
    public class AudioFile
    {
        public TagLib.File File;
        public AudioFile(string path)
        {
            File = TagLib.File.Create(path);            
        }

        public void UpdateBPM(uint bpm)
        {
            File.Tag.BeatsPerMinute = bpm;
            File.Save();
        }
    }
}
