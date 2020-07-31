using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTuts
{
    class Track
    {

        public string TrackName { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string ShortDesc { get; set; }
        public string Diff { get; set; } // Difficulty
        public double Length { get; set; } // track Length

        public string LongDesc { get; set; }


        public List<Track> tracks = new List<Track>();
    }
}
