using System;
using System.Collections.Generic;
using System.Text;

namespace Lyler
{
    public struct LyricData
    {
        public double time;
        public string line;
    }
    public struct SongRequest
    {
        public string title;
        public string artist;

        public static bool Valid(SongRequest s)
        {
            bool b1 = !string.IsNullOrEmpty(s.title) && !string.IsNullOrWhiteSpace(s.title);
            bool b2 = !string.IsNullOrEmpty(s.artist) && !string.IsNullOrWhiteSpace(s.artist);
            return b1 || b2;
        }
    }
}
