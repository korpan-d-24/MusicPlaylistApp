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

        public DbSet<Music> Musics { get; set; }

        public DbSet<MusicStyle> MusicStyles { get; set; }
    }
}
