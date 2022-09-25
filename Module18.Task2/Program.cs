namespace Module18.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // команда на получение информации
            CommandGetInformation commandGetInformation = new CommandGetInformation(receiver);
            // инициализация команды
            sender.SetCommand(commandGetInformation);
            // выполнение команды
            sender.Run();

            // команда на получение загрузку видео
            CommandDownload commandDownload = new CommandDownload(receiver);
            // инициализация команды
            sender.SetCommand(commandDownload);
            // выполнение команды
            sender.Run();
        }
    }
}