namespace Module18.Task2
{
    /// <summary>
    /// Конкретная реализация команды на загрузку видео.
    /// </summary>
    class CommandDownload : Command
    {
        Receiver reseiver;

        public CommandDownload(Receiver reseiver)
        {
            this.reseiver = reseiver;
        }

        public override void Run()
        {
            reseiver.DownloadFile();
        }
    }
}
