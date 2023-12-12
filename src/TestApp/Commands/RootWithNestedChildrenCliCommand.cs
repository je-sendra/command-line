﻿using System;
using DotMake.CommandLine;

namespace TestApp.Commands
{
	[DotMakeCliCommand(Description = "A root cli command with nested children")]
	public class RootWithNestedChildrenCliCommand
	{
		[DotMakeCliOption(Description = "Description for Option1")]
		public string Option1 { get; set; } = "DefaultForOption1";

		[DotMakeCliArgument(Description = "Description for Argument1")]
		public string Argument1 { get; set; } = "DefaultForArgument1";

		public void Run()
		{
			Console.WriteLine($@"Handler for '{GetType().FullName}' is run:");
			Console.WriteLine($@"Value for {nameof(Option1)} property is '{Option1}'");
			Console.WriteLine($@"Value for {nameof(Argument1)} property is '{Argument1}'");
			Console.WriteLine();
		}

		[DotMakeCliCommand(Description = "A nested level 1 sub-command")]
		public class Level1SubCliCommand
		{
			[DotMakeCliOption(Description = "Description for Option1")]
			public string Option1 { get; set; } = "DefaultForOption1";

			[DotMakeCliArgument(Description = "Description for Argument1")]
			public string Argument1 { get; set; } = "DefaultForArgument1";

			public void Run()
			{
				Console.WriteLine($@"Handler for '{GetType().FullName}' is run:");
				Console.WriteLine($@"Value for {nameof(Option1)} property is '{Option1}'");
				Console.WriteLine($@"Value for {nameof(Argument1)} property is '{Argument1}'");
				Console.WriteLine();
			}

			[DotMakeCliCommand(Description = "A nested level 2 sub-command")]
			public class Level2SubCliCommand
			{
				[DotMakeCliOption(Description = "Description for Option1")]
				public string Option1 { get; set; } = "DefaultForOption1";

				[DotMakeCliArgument(Description = "Description for Argument1")]
				public string Argument1 { get; set; } = "DefaultForArgument1";

				public void Run()
				{
					Console.WriteLine($@"Handler for '{GetType().FullName}' is run:");
					Console.WriteLine($@"Value for {nameof(Option1)} property is '{Option1}'");
					Console.WriteLine($@"Value for {nameof(Argument1)} property is '{Argument1}'");
					Console.WriteLine();
				}
			}
		}
	}
}