using Microsoft.Extensions.Logging;
using System;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class XunitLogger<T>(ITestOutputHelper output, LogLevel minLogLevel = LogLevel.Debug) : ILogger<T>
{
	private readonly ITestOutputHelper _output = output;
	private readonly LogLevel _minLogLevel = minLogLevel;

	public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

	public bool IsEnabled(LogLevel logLevel) => logLevel >= _minLogLevel;

	public void Log<TState>(
		LogLevel logLevel,
		EventId eventId,
		TState state,
		Exception? exception,
		Func<TState, Exception?, string> formatter)
	{
		if (!IsEnabled(logLevel))
		{
			return;
		}

		try
		{
			_output.WriteLine($"[{logLevel}] {formatter(state, exception)}");
			if (exception != null)
			{
				_output.WriteLine(exception.ToString());
			}
		}
		catch
		{
			// Ignore any exceptions from writing to output
		}
	}
}
