﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.7.2.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands
{
    /// <inheritdoc />
    public class InheritanceCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public InheritanceCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.InheritanceCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.InheritanceCliCommand CreateInstance()
        {
            return new TestApp.Commands.InheritanceCliCommand();
        }

        /// <inheritdoc />
        public override System.CommandLine.Command Build()
        {
            // Command for 'InheritanceCliCommand' class
            var rootCommand = new System.CommandLine.RootCommand()
            {
            };

            var defaultClass = CreateInstance();

            // Option for 'Username' property
            var option0 = new System.CommandLine.Option<string>
            (
                "--username",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Username of the identity performing the command",
                IsRequired = false,
            };
            option0.SetDefaultValue(defaultClass.Username);
            option0.AddAlias("-u");
            rootCommand.Add(option0);

            // Option for 'Password' property
            var option1 = new System.CommandLine.Option<string>
            (
                "--password",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Password of the identity performing the command",
                IsRequired = true,
            };
            option1.AddAlias("-p");
            rootCommand.Add(option1);

            // Option for 'Department' property
            var option2 = new System.CommandLine.Option<string>
            (
                "--department",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Department of the identity performing the command (interface)",
                IsRequired = false,
            };
            option2.SetDefaultValue(defaultClass.Department);
            option2.AddAlias("-d");
            rootCommand.Add(option2);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                rootCommand.Add(child.Build());
            }

            BindFunc = (parseResult) =>
            {
                var targetClass = CreateInstance();

                //  Set the parsed or default values for the options
                targetClass.Username = GetValueForOption(parseResult, option0);
                targetClass.Password = GetValueForOption(parseResult, option1);
                targetClass.Department = GetValueForOption(parseResult, option2);

                //  Set the parsed or default values for the arguments

                return targetClass;
            };

            System.CommandLine.Handler.SetHandler(rootCommand, context =>
            {
                var targetClass = (TestApp.Commands.InheritanceCliCommand) BindFunc(context.ParseResult);

                //  Call the command handler
                targetClass.Run();
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.InheritanceCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
