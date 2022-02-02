using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlaylist.Shared;

namespace MusicPlaylist.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MusicsController : ControllerBase
    {
        static List<MusicStyle> styles = new List<MusicStyle>
        {
            new MusicStyle { Id = 1, NameOfStyle = "Heavy metal"},
            new MusicStyle { Id = 2, NameOfStyle = "Rock 'n' Roll"}
        };

        static List<Music> musics = new List<Music>
        {
            new Music { Id = 1, SongName = "Heaven and Hell", AlbumName = "Heaven and Hell", GroupName = "Black Sabbath", ReleaseYear = "1980", MusicStyle = styles[0], Url = "https://www.youtube.com/watch?v=RVUK2rtAkJE"},
            new Music { Id = 2, SongName = "Catch The Rainbow", AlbumName = "Ritchie Blackmore's Rainbow", GroupName = "Rainbow", ReleaseYear = "1975", MusicStyle = styles[1], Url = "https://www.youtube.com/watch?v=V5QukAC-jqE"}
        };

        [HttpGet("styles")]
        public async Task<IActionResult> GetStyles()
        {
            return Ok(styles);
        }

        [HttpGet]
        public async Task<IActionResult> GetMusic()
        {
            return Ok(musics);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleMusic(int id)
        {
            var music = musics.FirstOrDefault(m => m.Id == id);
            if (music == null)
            {
                return NotFound("Music was`t found");
            }
            return Ok(musics);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMusicMusic(Music music)
        {
            music.Id = musics.Max(m => m.Id + 1);
            musics.Add(music);
            return Ok(musics);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusicMusic(Music music, int id)
        {
            var dbMusic = musics.FirstOrDefault(m => m.Id == id);
            if (dbMusic == null)
            {
                return NotFound("Music was`t found");
            }
            var index = musics.IndexOf(dbMusic);
            musics[index] = music;

            return Ok(musics);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusicMusic(int id)
        {
            var dbMusic = musics.FirstOrDefault(m => m.Id == id);
            if (dbMusic == null)
            {
                return NotFound("Music was`t found");
            }
            musics.Remove(dbMusic);

            return Ok(musics);
        }
    }
}
