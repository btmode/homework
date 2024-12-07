// class Utils - IsNullOrEmptyString(), GetRandomNumber() - static
// class Game - GetScore(), GetLevel(), GetHighScore(), Finish() - не статик
// class Logger(string filePath) - Log(), Error(), Warning(), Info() - не статик
// class Person - GetName(), GetAge(), GetAddress(), GetPhoneNumber() - не статик
// class MathHelper - Add(), Subtract(), Multiply(), Divide() - static
// class BankAccount - GetBalance(), Deposit(), Withdraw() - не статик
// class GameCharacter - Attack(GameCharacter target), MoveTo(int x, int y), GetHealth(), Jump() - не статик
// class WeatherForecast(string city) - GetTemperature(), GetHumidity(), GetWindSpeed() - не статик
// class Image - Resize(), SetOpacity(), SetBlur() - не статик
// class AudioPlaylist - Play(), Pause(), SetVolume(), AddSong(), NextSong() - не статик
// class TextAnalyzer - CountWords(), CountSentences(), CountPunctuations(), CountLetter(char letter) - не статик

// не статик
// var utils = new Utils();
// utils.IsNullOrEmptyString(null);
// utils.GetRandomNumber();
//
// статик
// Utils.IsNullOrEmptyString(null);
// Utils.GetRandomNumber();

// var ananlyzer = new TextAnalyzer("какой-то текст");
//
// TextAnalyzer.CountWords();
// TextAnalyzer.CountSentences();
//
// string? password = "";
// if (password == null || password == "") {}
//
// if (utils.IsNullOrEmptyString(password)) {}
//
// var cLogger = new Logger("C:\\log.txt");
// var fleshLogger = new Logger("F:\\log.txt");
//
// cLogger.Info("Какое-то сообщение");
// cLogger.Error("Какое-то сообщение");
// cLogger.Warning("Какое-то сообщение");
// cLogger.Success("Какое-то сообщение");
// cLogger.Log("Какое-то сообщение");
//
// var p1 = new Person("John", 25, "New York", "123-456-7890");
// p1.GetName();
// var p2 = new Person("Jane", 30, "Los Angeles", "987-654-3210");
//
// cLogger.Info("Какое-то сообщение");
// fleshLogger.Error("Не удалось что-то сделать");
//
// // var utils = new Utils();
// utils.IsNullOrEmptyString(null);
// utils.GetRandomNumber();

// class Dictionary - AddWord(string word), TranslateWord(string word), RemoveWord(string word) - не статик 
// class Car - Start(), Stop(), TurnLeft(), TurnRight() - не статик
// !class Plane - Start(), Stop(), TakeOff(), Land() - не статик
// !class DateTime - GetNow(), GetCurrentDay(), GetCurrentMonth(), GetCurrentYear() - статик
// !static class ConsoleHepler - Clear(), WriteLine(), Write(), ReadLine(), ReadKey() - статик 
// class Program - Main(), Start() - статик
// class Dialog - ShowMessage(string message), ShowError(string message), ShowWarning(string message), ShowInfo(string message) - не статик
// class Painter(string imagePath) - DrawLine(), DrawRectangle(), DrawCircle(), DrawPolygon() - статик 
// class Table - AddRow(string[] row), RemoveRow(int index), GetRow(int index), GetRowCount(), GetColumn(int index), AddColumn() не статик 
// !class KeyboardEmulator - PressEnter(), PressEscape(), PressSpace() статик 
// !class MouseEmulator - GetPosition(), ClickLeftButton(), ClickRightButton(), ClickMiddleButton() - статик 
// !class Button - SetText(string text), SetPosition(int x, int y), SetSize(int width, int height), SetColor(Color color) - не статик 
// class WindowsEmulator - StartProgram(string programName), CloseProgram(string programName), VisitWebsite(string url), OpenFile(string filePath) - статик

