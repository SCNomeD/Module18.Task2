namespace Module18.Task2
{
    /// <summary>
    /// Класс команды на получение информации о видео.
    /// </summary>
    class CommandGetInformation : Command
    {
        Receiver reseiver;

        public CommandGetInformation(Receiver reseiver)
        {
            this.reseiver = reseiver;
        }

        public override void Run()
        {
            reseiver.GetInfo();
        }
    }
}
