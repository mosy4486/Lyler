using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lyler
{
    public partial class Form1 : Form
    {
        private SongRequest curSr;
        private Song curSong;
        private Song[] curSongs;
        private DataSearcher dataSearcher = new();
        private int curdex = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshUI()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!SongRequest.Valid(curSr))
            {
                LogText.Text = "*정보를 가져와주세요*";
                return;
            }
        }

        private async void LyricButton_Click(object sender, EventArgs e)
        {
            if (!SongRequest.Valid(curSr))
            {
                LogText.Text = "*값을 입력해주세요*";
                return;
            }

            LogText.Text = "정보를 가져오는중....";
            var result = await dataSearcher.SearchSongData(curSr);
            LogText.Text = result.mes;

            if (result.success)
            {
                curdex = 0;
                curSongs = result.song;
                ShowDataResult(0);
            }
        }
        private void ShowDataResult(int index)
        {
            if (curSongs == null || curSongs.Length == 0)
            {
                LogText.Text = "*정보를 가져와주세요*";
                return;
            }

            if (index < 0 || index >= curSongs.Length)
            {
                return;
            }

            curdex = index;

            StringBuilder sb = new();

            curSong = curSongs[index];
            sb.AppendLine();
            sb.AppendLine($"No.{curdex+1}");
            sb.AppendLine();
            sb.AppendLine($"제목: {curSong.trackName}");
            sb.AppendLine($"아티스트: {curSong.artistName}");
            sb.AppendLine($"앨범: {curSong.albumName}");
            sb.AppendLine($"길이: {curSong.duration}초");
            sb.AppendLine();

            var result = GetLyricsByAll(curSong.plainLyrics);

            if (!result.success) sb.AppendLine("가사 로딩 실패");

            foreach (var lyric in result.lyrics) sb.AppendLine(lyric.line);

            ResultBox.Text = sb.ToString();
        }
        private (List<LyricData> lyrics, bool success) GetLyricsByAll(string lyric)
        {
            List<LyricData> lyrics = new();
            if (string.IsNullOrWhiteSpace(lyric) || string.IsNullOrEmpty(lyric)) return (lyrics, false);
            string[] lines = lyric.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                // 빈 줄은 일단 제외
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                lyrics.Add(new LyricData
                {
                    line = line
                });
            }
            return (lyrics, true);
        }

        private void ArtistInput_TextChanged(object sender, EventArgs e)
        {
            curSr.artist = ArtistInput.Text;
        }
        private void TitleInput_TextChanged(object sender, EventArgs e)
        {
            curSr.title = TitleInput.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void neButton_Click(object sender, EventArgs e)
        {
            ShowDataResult(curdex + 1);
        }

        private void prButton_Click(object sender, EventArgs e)
        {
            ShowDataResult(curdex - 1);
        }
    }
}
