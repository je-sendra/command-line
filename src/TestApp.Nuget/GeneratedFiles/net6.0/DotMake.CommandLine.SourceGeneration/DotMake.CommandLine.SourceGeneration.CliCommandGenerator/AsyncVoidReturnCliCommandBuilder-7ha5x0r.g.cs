﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.6.9.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands
{
    /// <inheritdoc />
    public class AsyncVoidReturnCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public AsyncVoidReturnCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.AsyncVoidReturnCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.AsyncVoidReturnCliCommand CreateInstance()
        {
            return new TestApp.Commands.AsyncVoidReturnCliCommand();
        }

        /// <inheritdoc />
        public override System.CommandLine.Command Build()
        {
            // Command for 'AsyncVoidReturnCliCommand' class
            var rootCommand = new System.CommandLine.RootCommand()
            {
                Description = "A root cli command with async handler with Task (return void)",
            };

            var defaultClass = CreateInstance();

            // Option for 'Option1' property
            var option0 = new System.CommandLine.Option<string>
            (
                "--option-1",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Description for Option1",
                IsRequired = false,
            };
            option0.SetDefaultValue(defaultClass.Option1);
            option0.AddAlias("-o");
            rootCommand.Add(option0);

            // Argument for 'Argument1' property
            var argument0 = new System.CommandLine.Argument<string>
            (
                "argument-1",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Description for Argument1",
            };
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

            System.CommandLine.Handler.SetHandler(rootCommand, async context =>
            {
                var targetClass = (TestApp.Commands.AsyncVoidReturnCliCommand) BindFunc(context.ParseResult);

                //  Call the command handler
                await targetClass.RunAsync();
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.AsyncVoidReturnCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
