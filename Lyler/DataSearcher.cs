using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Lyler
{
    public class DataSearcher
    {
        private HttpClient hc = new HttpClient();
        public SearcherState State { get; private set; } = SearcherState.None;

        public DataSearcher()
        {
            hc.DefaultRequestHeaders.UserAgent.ParseAdd("Songic/1.0");
        }

        public async Task<(Song[] song, string mes, bool success)> SearchSongData(SongRequest rd)
        {
            if (State == SearcherState.Searching) return (Array.Empty<Song>(), "이미 정보 검색중", false);

            State = SearcherState.Searching;

            try
            {
                return await GetData(rd);
            }
            finally
            {
                State = SearcherState.None;
            }
        }

        private async Task<(Song[] data, string message, bool success)> GetData(SongRequest rd)
        {
            string artist = Uri.EscapeDataString((rd.artist ?? "").Trim());
            string title = Uri.EscapeDataString((rd.title ?? "").Trim());
            string query = Uri.EscapeDataString($"{rd.artist} {rd.title}".Trim());
            

            string[] urls =
            {
                $"https://lrclib.net/api/search?artist_name={artist}&track_name={title}",
                $"https://lrclib.net/api/search?q={query}",
                $"https://lrclib.net/api/search?track_name={title}",
                $"https://lrclib.net/api/search?q={artist}"
            };

            foreach (string url in urls)
            {
                for (int attempt = 0; attempt < 10; attempt++)
                {
                    HttpResponseMessage response = await hc.GetAsync(url);

                    if (response.StatusCode == HttpStatusCode.ServiceUnavailable || (int)response.StatusCode == 429)
                    {
                        await Task.Delay(500);
                        continue;
                    }

                    if (!response.IsSuccessStatusCode) return (Array.Empty<Song>(), $"{response.StatusCode} 정보 검색 실패", false);

                    string json = await response.Content.ReadAsStringAsync();
                    try
                    {
                        List<Song>? songs = JsonSerializer.Deserialize<List<Song>>(json);

                        if (songs != null && songs.Count > 0) return (songs.ToArray(), "정보 검색 성공", true);
                    }
                    catch (JsonException)
                    {
                        return (Array.Empty<Song>(), $"JSON 변환 실패\n{json}", false);
                    }

                    break;
                }
            }

            return (Array.Empty<Song>(), "정보 검색 결과 없음", false);
        }
    }
}
