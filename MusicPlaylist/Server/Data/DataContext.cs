using Microsoft.EntityFrameworkCore;
using MusicPlaylist.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlaylist.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicStyle>().HasData(
            new MusicStyle { Id = 1, NameOfStyle = "Heavy metal" },
            new MusicStyle { Id = 2, NameOfStyle = "Rock 'n' Roll" },
            new MusicStyle { Id = 3, NameOfStyle = "Jazz" }
            );

            modelBuilder.Entity<Music>().HasData(
            new Music { Id = 1, SongName = "Heaven and Hell", AlbumName = "Heaven and Hell", GroupName = "Black Sabbath", ReleaseYear = "1980", MusicStyleId = 1, Url = "https://www.youtube.com/watch?v=RVUK2rtAkJE" },
            new Music { Id = 2, SongName = "Catch The Rainbow", AlbumName = "Ritchie Blackmore's Rainbow", GroupName = "Rainbow", ReleaseYear = "1975", MusicStyleId = 2, Url = "https://www.youtube.com/watch?v=V5QukAC-jqE" },
            new Music { Id = 3, SongName = "What a wonderful world", AlbumName = "What a wonderful world", GroupName = "Louis Armstrong", ReleaseYear = "1967", MusicStyleId = 3, Url = "https://www.youtube.com/watch?v=CWzrABouyeE" }
            );
        }

        public DbSet<Music> Musics { get; set; }

        public DbSet<MusicStyle> MusicStyles { get; set; }
    }
}
