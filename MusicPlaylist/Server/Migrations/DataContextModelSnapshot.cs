﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicPlaylist.Server.Data;

namespace MusicPlaylist.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicPlaylist.Shared.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MusicStyleId")
                        .HasColumnType("int");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MusicStyleId");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("MusicPlaylist.Shared.MusicStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfStyle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MusicStyles");
                });

            modelBuilder.Entity("MusicPlaylist.Shared.Music", b =>
                {
                    b.HasOne("MusicPlaylist.Shared.MusicStyle", "MusicStyle")
                        .WithMany()
                        .HasForeignKey("MusicStyleId");

                    b.Navigation("MusicStyle");
                });
#pragma warning restore 612, 618
        }
    }
}
