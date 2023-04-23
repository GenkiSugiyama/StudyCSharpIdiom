namespace Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var song1 = new Song("song1", "aaa", 200);
            var song2 = new Song("song2", "bbb", 240);
            var song3 = new Song("song3", "ccc", 180);

            Song[] songs = new Song[] { song1, song2, song3 };

            foreach (var song in songs)
            {
                var span = new TimeSpan(0, 0, song.Length);
                var mmss = span.ToString(@"hh\:mm\:ss");
                Console.WriteLine($"タイトル：{song.Title} 歌手：{song.ArtistName} 演奏時間：{mmss}");
            }
        }
    }

    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public Song(string title, string artistName, int length)
        {
            this.Title = title;
            this.ArtistName = artistName;
            this.Length = length;
        }
    }
}