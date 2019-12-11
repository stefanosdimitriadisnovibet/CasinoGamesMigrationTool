using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CasinoGamesMigrationTool.Domain
{
	public interface ILogger
	{
		void Log<TPayload>(TPayload payload, [CallerMemberName]string callerMemberName = default);
		void LogError<TPayload>(TPayload payload, [CallerMemberName]string callerMemberName = default);
	}

	public class ConsoleLogger : ILogger
	{
		public void Log<TPayload>(TPayload payload, [CallerMemberName]string callerMemberName = default)
		{
			string message = JsonSerializer.Serialize(payload, typeof(TPayload));

			Console.WriteLine($"{DateTime.UtcNow}\t{callerMemberName}\t{message}\n");
		}

		public void LogError<TPayload>(TPayload payload, [CallerMemberName]string callerMemberName = default)
		{
			string message = JsonSerializer.Serialize(payload, typeof(TPayload));

			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine($"{DateTime.UtcNow}\t{callerMemberName}\t{message}\n");

			Console.ResetColor();
		}
	}

	public class FileLogger : ILogger
	{
		private readonly string FolderPath;
		private readonly string FileName;
		private readonly string FilePath;

		public FileLogger()
		{
			FolderPath = $"./logs/{DateTime.UtcNow.Year}-{DateTime.UtcNow.Month}-{DateTime.UtcNow.Day}";
			FileName = "Logs.log";
			FilePath = $"{FolderPath}/{FileName}";

			bool fileExists = File.Exists(FilePath);

			if (fileExists == false)
			{
				Directory.CreateDirectory(FolderPath);

				using (FileStream fileStream = File.Create(FilePath)) { }
			}
		}

		public void Log<TPayload>(TPayload payload, [CallerMemberName] string callerMemberName = null)
		{
			string message = JsonSerializer.Serialize(payload, typeof(TPayload));

			File.AppendAllText(FilePath, $"{DateTime.UtcNow}\t{callerMemberName}\t{message}\n");
		}

		public void LogError<TPayload>(TPayload payload, [CallerMemberName] string callerMemberName = null)
		{
			string message = JsonSerializer.Serialize(payload, typeof(TPayload));

			File.AppendAllText(FilePath, "-----------------------Error-----------------------\n");

			File.AppendAllText(FilePath, $"{DateTime.UtcNow}\t{callerMemberName}\t{message}\n");
		}
	}
}