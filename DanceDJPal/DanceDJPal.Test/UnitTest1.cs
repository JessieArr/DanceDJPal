using DanceDJPal.Core;
using System;
using Xunit;

namespace DanceDJPal.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testFilePath = "myPath";
            var test = new AudioFile(testFilePath);
            Assert.Equal("B.B. King", test.File.Tag.FirstAlbumArtist);
            Assert.Equal("Live In Cook County Jail", test.File.Tag.Album);
        }
    }
}
