﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.8.1.0
// Roslyn (Microsoft.CodeAnalysis) v4.900.24.8111
// Generation: 1

namespace TestApp.Commands
{
    /// <inheritdoc />
    public class ValidationCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public ValidationCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.ValidationCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.ValidationCliCommand CreateInstance()
        {
            return new TestApp.Commands.ValidationCliCommand();
        }

        /// <inheritdoc />
        public override System.CommandLine.CliCommand Build()
        {
            // Command for 'ValidationCliCommand' class
            var rootCommand = new System.CommandLine.CliRootCommand()
            {
            };

            var defaultClass = CreateInstance();

            // Option for 'OptFile1' property
            var option0 = new System.CommandLine.CliOption<System.IO.FileInfo>
            (
                "--opt-file-1"
            )
            {
                Required = false,
            };
            option0.CustomParser = GetParseArgument<System.IO.FileInfo>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option0, DotMake.CommandLine.CliValidationRules.ExistingFile);
            option0.DefaultValueFactory = _ => defaultClass.OptFile1;
            option0.Aliases.Add("-o");
            rootCommand.Add(option0);

            // Option for 'OptFile2' property
            var option1 = new System.CommandLine.CliOption<string>
            (
                "--opt-file-2"
            )
            {
                Required = false,
            };
            option1.CustomParser = GetParseArgument<string>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option1, DotMake.CommandLine.CliValidationRules.None | DotMake.CommandLine.CliValidationRules.NonExistingFile | DotMake.CommandLine.CliValidationRules.LegalPath);
            option1.DefaultValueFactory = _ => defaultClass.OptFile2;
            rootCommand.Add(option1);

            // Option for 'OptDir' property
            var option2 = new System.CommandLine.CliOption<System.IO.DirectoryInfo>
            (
                "--opt-dir"
            )
            {
                Required = false,
            };
            option2.CustomParser = GetParseArgument<System.IO.DirectoryInfo>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option2, DotMake.CommandLine.CliValidationRules.ExistingDirectory);
            option2.DefaultValueFactory = _ => defaultClass.OptDir;
            rootCommand.Add(option2);

            // Option for 'OptPattern1' property
            var option3 = new System.CommandLine.CliOption<string>
            (
                "--opt-pattern-1"
            )
            {
                Required = false,
            };
            option3.CustomParser = GetParseArgument<string>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option3, "(?i)^[a-z]+$");
            option3.DefaultValueFactory = _ => defaultClass.OptPattern1;
            rootCommand.Add(option3);

            // Option for 'OptPattern2' property
            var option4 = new System.CommandLine.CliOption<string>
            (
                "--opt-pattern-2"
            )
            {
                Required = false,
            };
            option4.CustomParser = GetParseArgument<string>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option4, "(?i)^[a-z]+$", "Custom error message");
            option4.DefaultValueFactory = _ => defaultClass.OptPattern2;
            rootCommand.Add(option4);

            // Option for 'OptUrl' property
            var option5 = new System.CommandLine.CliOption<string>
            (
                "--opt-url"
            )
            {
                Required = false,
            };
            option5.CustomParser = GetParseArgument<string>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option5, DotMake.CommandLine.CliValidationRules.LegalUrl);
            option5.DefaultValueFactory = _ => defaultClass.OptUrl;
            rootCommand.Add(option5);

            // Option for 'OptUri' property
            var option6 = new System.CommandLine.CliOption<string>
            (
                "--opt-uri"
            )
            {
                Required = false,
            };
            option6.CustomParser = GetParseArgument<string>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(option6, DotMake.CommandLine.CliValidationRules.LegalUri);
            option6.DefaultValueFactory = _ => defaultClass.OptUri;
            rootCommand.Add(option6);

            // Argument for 'OptFileName' property
            var argument0 = new System.CommandLine.CliArgument<string>
            (
                "opt-file-name"
            )
            {
            };
            argument0.CustomParser = GetParseArgument<string>
            (
                null
            );
            DotMake.CommandLine.CliValidationExtensions.AddValidator(argument0, DotMake.CommandLine.CliValidationRules.LegalFileName);
            argument0.DefaultValueFactory = _ => defaultClass.OptFileName;
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
                targetClass.OptFile1 = GetValueForOption(parseResult, option0);
                targetClass.OptFile2 = GetValueForOption(parseResult, option1);
                targetClass.OptDir = GetValueForOption(parseResult, option2);
                targetClass.OptPattern1 = GetValueForOption(parseResult, option3);
                targetClass.OptPattern2 = GetValueForOption(parseResult, option4);
                targetClass.OptUrl = GetValueForOption(parseResult, option5);
                targetClass.OptUri = GetValueForOption(parseResult, option6);

                //  Set the parsed or default values for the arguments
                targetClass.OptFileName = GetValueForArgument(parseResult, argument0);

                return targetClass;
            };

            rootCommand.SetAction(parseResult =>
            {
                var targetClass = (TestApp.Commands.ValidationCliCommand) BindFunc(parseResult);

                //  Call the command handler
                var cliContext = new DotMake.CommandLine.CliContext(parseResult);
                var exitCode = 0;
                targetClass.Run(cliContext);
                return exitCode;
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.ValidationCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
