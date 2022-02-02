using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlaylist.Shared;

namespace MusicPlaylist.Client.Services
{
    interface IMusicService
    {
        event Action OnChange;

        List<MusicStyle> Styles { get; set; }

        List<Music> Musics { get; set; }

        Task<List<Music>> GetMusics();

        Task GetStyles();

        Task<Music> GetMusic(int id);

        Task<List<Music>> CreateMusic(Music music);

        Task<List<Music>> UpdateMusic(Music music, int id);

        Task<List<Music>> DeleteMusic(int id);
    }
}
