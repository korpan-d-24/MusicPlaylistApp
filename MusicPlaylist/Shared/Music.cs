using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist.Shared
{
    public class Music
    {
        public int Id { get; set; } = 0;

        public string SongName { get; set; }

        public string AlbumName { get; set; }

        public string GroupName { get; set; }

        public string ReleaseYear { get; set; }

        public MusicStyle MusicStyle { get; set; } = new MusicStyle();

        public string Url { get; set; }
    }
}
