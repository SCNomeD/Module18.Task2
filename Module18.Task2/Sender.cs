namespace Module18.Task2
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command command;

        /// <summary>
        /// Устанавливает текущий объект команды.
        /// </summary>
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        public void Run()
        {
            command.Run();
        }
    }
}