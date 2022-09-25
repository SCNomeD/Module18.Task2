using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18.Task2
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        string url;
        string name;

        /// <summary>
        /// Метод получает информацию о видео.
        /// </summary>
        public void GetInformation()
        {
            Console.Write("Введите ссылку на видео YouTube: ");

            url = Console.ReadLine();

            var video = RequestToYouTube(url);

            Console.WriteLine($"\nНазвание: {video.Result.Title}");
            Console.WriteLine($"Дата загрузки: {video.Result.UploadDate}");
            Console.WriteLine($"Продолжительность: {video.Result.Duration}");
            Console.WriteLine($"Автор: {video.Result.Author}");
        }

        private async Task<YoutubeExplode.Videos.Video> RequestToYouTube(string url)
        {
            Console.WriteLine("Получаем информацию...");

            var youtube = new YoutubeClient();

            return await youtube.Videos.GetAsync(url);
        }

        /// <summary>
        /// Метод скачивает файл.
        /// </summary>
        public void DownloadFile()
        {
            IAsyncResult result = Download();

            while (result.IsCompleted != true) { }

            Console.WriteLine("\nЗагрузка завершена.");
        }

        private async Task Download()
        {
            Console.Write("\nВведите имя для сохраняемого файла: ");
            name = Console.ReadLine();

            Console.WriteLine("\nФайл загружается...");

            var youtube = new YoutubeClient();

            await youtube.Videos.DownloadAsync(url, name + ".mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
        }
    }
}
