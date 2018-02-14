using System;
using System.Diagnostics;

namespace JavaRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			var proc = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					// IMPORTANT: check if java.exe is in the PATH environment variable(%PATH%)
					FileName = "java.exe",
					// IMPORTANT: Main.class must be at the same directory
					Arguments = "Main We are from C#",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}

			};

			proc.Start();
			while (!proc.StandardOutput.EndOfStream)
			{
				string line = proc.StandardOutput.ReadLine();
				Console.WriteLine(line);
			}
		}
	}
}
