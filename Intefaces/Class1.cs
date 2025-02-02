namespace Interfaces
{
    // Интерфейс говорит о том, что должно быть в классе
    public interface ITextHelper
    {
        public int GetWordsCount();
    }

    public class TextHelper : ITextHelper
    {
        private string _text;

        public TextHelper(string text)
        {
            _text = text;
        }

        public int GetWordsCount()
        {
            return _text.Split(" ").Length;
        }
    }

    class DatabaseHelper
    {
        public string[] GetUsers(ConsoleLogger logger)
        {
            logger.Success("Получили данные");
            return ["Alex", "John"];
        }
    }

    public interface ILogger
    {
        public void Log(string text);
        public void Info(string text);
        public void Warn(string text);
        public void Error(string text);
        public void Success(string text);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string text) { }
        public void Info(string text) { }
        public void Warn(string text) { }
        public void Error(string text) { }
        public void Success(string text) { }
    }

    class TelegramLogger : ILogger
    {
        public void Log(string text) { }
        public void Info(string text) { }
        public void Warn(string text) { }
        public void Error(string text) { }
        public void Success(string text) { }
    }
}
