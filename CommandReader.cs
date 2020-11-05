using System;
using System.Collections.Generic;
using System.IO;
using BigMammaUML3;

public class CommandReader : ICommandReader {
	private string _location;

	private List<string> _commands;

	public List<string> Commands => _commands;

	public CommandReader(string location) {
		_location = location;
		_commands = new List<string>();
		ReadCommands();
	}

	private void ReadCommands() {
		StreamReader file = null;
		string path = Directory.GetCurrentDirectory();
		string fullLocation = path + "\\" + _location;
		try {
			file = new StreamReader(fullLocation);
			while (!file.EndOfStream) {
				_commands.Add(file.ReadLine());
			}
		} catch (Exception e) {
			Program.print("Reading file at " + _location + " failed: " + e.ToString());
		} finally {
			file?.Close();
		}
	}
}