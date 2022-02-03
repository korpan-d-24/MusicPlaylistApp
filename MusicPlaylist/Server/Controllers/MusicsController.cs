using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlaylist.Shared;
using MusicPlaylist.Server.Data;
using Microsoft.EntityFrameworkCore;

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

        private readonly DataContext _context;

        public MusicsController(DataContext context)
        {
            /// <summary>
            /// Getsthe list notes
            /// </summary>
            /// <remarks>
            /// Sample request:
            /// GET /note
            /// </remarks>
            /// <returns></returns>

            _context = context;
        }

        [HttpGet("styles")]
        public async Task<IActionResult> GetStyles()
        {
            return Ok(await _context.MusicStyles.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetMusic()
        {
            return base.Ok(await GetDbMusics());
        }

        private async Task<List<Music>> GetDbMusics()
        {
            return await _context.Musics.Include(ms => ms.MusicStyle).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleMusic(int id)
        {
            var music = await _context.Musics.Include(ms => ms.MusicStyle).FirstOrDefaultAsync(m => m.Id == id);
            if (music == null)
            {
                return NotFound("Music was`t found");
            }
            return Ok(musics);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMusicMusic(Music music)
        {
            _context.Musics.Add(music);
            await _context.SaveChangesAsync();

            return Ok(await GetDbMusics());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusicMusic(Music music, int id)
        {
            var dbMusic = await _context.Musics.Include(ms => ms.MusicStyle).FirstOrDefaultAsync(m => m.Id == id);
            if (dbMusic == null)
            {
                return NotFound("Music was`t found");
            }

            dbMusic.SongName = music.SongName;
            dbMusic.AlbumName = music.AlbumName;
            dbMusic.GroupName = music.GroupName;
            dbMusic.ReleaseYear = music.ReleaseYear;
            dbMusic.MusicStyleId = music.MusicStyleId;
            dbMusic.Url = music.Url;

            await _context.SaveChangesAsync();

            return Ok(await GetDbMusics());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusicMusic(int id)
        {
            var dbMusic = await _context.Musics.Include(ms => ms.MusicStyle).FirstOrDefaultAsync(m => m.Id == id);
            if (dbMusic == null)
            {
                return NotFound("Music was`t found");
            }
            _context.Musics.Remove(dbMusic);
            await _context.SaveChangesAsync();

            return Ok(await GetDbMusics());
        }
    }
}
