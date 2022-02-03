using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicPlaylist.Shared;
using System.Net.Http;
using System.Net.Http.Json;


namespace MusicPlaylist.Client.Services
{
    public class MusicService : IMusicService
    {
        private readonly HttpClient _httpClient;

        public MusicService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<MusicStyle> Styles { get; set; } = new List<MusicStyle>();

        public List<Music> Musics { get; set; } = new List<Music>();

        public event Action OnChange;

        public async Task<List<Music>> CreateMusic(Music music)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/musics", music);
            Musics = await result.Content.ReadFromJsonAsync<List<Music>>();
            OnChange.Invoke();
            return Musics;
        }

        public async Task<List<Music>> DeleteMusic(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/musics/{id}");
            Musics = await result.Content.ReadFromJsonAsync<List<Music>>();
            OnChange.Invoke();
            return Musics;
        }

        public async Task<Music> GetMusic(int id)
        {
            return await _httpClient.GetFromJsonAsync<Music>($"api/musics/{id}");
        }

        public async Task<List<Music>> GetMusics()
        {
            Musics = await _httpClient.GetFromJsonAsync<List<Music>>("api/musics");
            return Musics;
        }

        public async Task GetStyles()
        {
            Styles = await _httpClient.GetFromJsonAsync<List<MusicStyle>>("api/musics/styles");
        }

        public async Task<List<Music>> UpdateMusic(Music music, int id)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/musics/{id}", music);
            Musics = await result.Content.ReadFromJsonAsync<List<Music>>();
            OnChange.Invoke();
            return Musics;
        }
    }
}
