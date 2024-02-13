﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.8.0.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands.CasingConvention
{
    /// <inheritdoc />
    public class NoCaseCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public NoCaseCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.CasingConvention.NoCaseCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.None;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.CasingConvention.NoCaseCliCommand CreateInstance()
        {
            return new TestApp.Commands.CasingConvention.NoCaseCliCommand();
        }

        /// <inheritdoc />
        public override System.CommandLine.CliCommand Build()
        {
            // Command for 'NoCaseCliCommand' class
            var rootCommand = new System.CommandLine.CliRootCommand()
            {
                Description = "A cli command with no case convention",
            };

            var defaultClass = CreateInstance();

            // Option for 'Option1' property
            var option0 = new System.CommandLine.CliOption<string>
            (
                "--Option1"
            )
            {
                Description = "Description for Option1",
                Required = false,
            };
            option0.CustomParser = GetParseArgument<string>
            (
                null
            );
            option0.DefaultValueFactory = _ => defaultClass.Option1;
            option0.Aliases.Add("-O");
            rootCommand.Add(option0);

            // Argument for 'Argument1' property
            var argument0 = new System.CommandLine.CliArgument<string>
            (
                "Argument1"
            )
            {
                Description = "Description for Argument1",
            };
            argument0.CustomParser = GetParseArgument<string>
            (
                null
            );
            rootCommand.Add(argument0);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                rootCommand.Add(child.Build());
            }

            BindFunc = (parseResult) =>
            {
                var targetClass = CreateInstance();

                //  Set the parsed or default values for the options
                targetClass.Option1 = GetValueForOption(parseResult, option0);

                //  Set the parsed or default values for the arguments
                targetClass.Argument1 = GetValueForArgument(parseResult, argument0);

                return targetClass;
            };

            rootCommand.SetAction(parseResult =>
            {
                var targetClass = (TestApp.Commands.CasingConvention.NoCaseCliCommand) BindFunc(parseResult);

                //  Call the command handler
                var cliContext = new DotMake.CommandLine.CliContext(parseResult);
                var exitCode = 0;
                cliContext.ShowHelp();
                return exitCode;
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.CasingConvention.NoCaseCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}