using System;
using System.Collections.Generic;
using System.Text;

namespace Lyler
{
    public struct Song
    {
        public int id { get; set; }

        public string trackName { get; set; }

        public string artistName { get; set; }

        public string albumName { get; set; }

        public double duration { get; set; }

        public bool instrumental { get; set; }

        public bool hasWordSync { get; set; }

        public string plainLyrics { get; set; }

        public string syncedLyrics { get; set; }

        public string lyricsfile { get; set; }
    }
}
