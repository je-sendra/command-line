﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.0.0.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Time: 2023-12-14T17:14:35.0697337+03:00, Generation: 1

namespace TestApp.Commands
{
	public class PartialCliCommandBuilder : DotMake.CommandLine.DotMakeCommandBuilder
	{
		public PartialCliCommandBuilder()
		{
			DefinitionType = typeof(TestApp.Commands.PartialCliCommand);
			ParentDefinitionType = null;
			NameCasingConvention = DotMake.CommandLine.DotMakeCliCasingConvention.KebabCase;
			NamePrefixConvention = DotMake.CommandLine.DotMakeCliPrefixConvention.DoubleHyphen;
			ShortFormPrefixConvention = DotMake.CommandLine.DotMakeCliPrefixConvention.SingleHyphen;
			ShortFormAutoGenerate = true;
		}

		public override System.CommandLine.RootCommand Build()
		{
			// Command for 'PartialCliCommand' class
			var rootCommand = new System.CommandLine.RootCommand()
			{
				Description = "A cli command with partial class",
			};

			var defaultClass = new TestApp.Commands.PartialCliCommand();

			// Option for 'Option1' property
			var option0 = new System.CommandLine.Option<string>("--option-1")
			{
				Description = "Description for Option1",
			};
			option0.SetDefaultValue(defaultClass.Option1);
			option0.AddAlias("-o");
			rootCommand.Add(option0);

			// Argument for 'Argument1' property
			var argument0 = new System.CommandLine.Argument<string>("argument-1")
			{
				Description = "Description for Argument1",
			};
			argument0.SetDefaultValue(defaultClass.Argument1);
			rootCommand.Add(argument0);

			// Add nested or external registered children
			foreach (var child in Children)
			{
				rootCommand.Add(child.Build());
			}

			System.CommandLine.Handler.SetHandler(rootCommand, context =>
			{
				var targetClass = new TestApp.Commands.PartialCliCommand();

				//  Set the parsed or default values for the options
				targetClass.Option1 = context.ParseResult.GetValueForOption(option0);

				//  Set the parsed or default values for the arguments
				targetClass.Argument1 = context.ParseResult.GetValueForArgument(argument0);

				//  Call the command handler
				targetClass.Run();
			});

			return rootCommand;
		}

		[System.Runtime.CompilerServices.ModuleInitializerAttribute]
		public static void Initialize()
		{
			var commandBuilder = new TestApp.Commands.PartialCliCommandBuilder();

			// Register this command builder so that it can be found by the definition class
			// and it can be found by the parent definition class if it's a nested/external child.
			commandBuilder.Register();
		}
	}
}
