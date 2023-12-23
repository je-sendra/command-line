﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.5.2.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands.PrefixConvention
{
    public class SingleHyphenCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        public SingleHyphenCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.PrefixConvention.SingleHyphenCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        public override System.CommandLine.RootCommand Build()
        {
            // Command for 'SingleHyphenCliCommand' class
            var rootCommand = new System.CommandLine.RootCommand()
            {
                Description = "A cli command with single hyphen prefix convention",
            };

            var defaultClass = new TestApp.Commands.PrefixConvention.SingleHyphenCliCommand();

            // Option for 'Option1' property
            var option0 = new System.CommandLine.Option<string>("-option-1")
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
            rootCommand.Add(argument0);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                rootCommand.Add(child.Build());
            }

            BindFunc = (parseResult) =>
            {
                var targetClass = new TestApp.Commands.PrefixConvention.SingleHyphenCliCommand();

                //  Set the parsed or default values for the options
                targetClass.Option1 = parseResult.GetValueForOption(option0);

                //  Set the parsed or default values for the arguments
                targetClass.Argument1 = parseResult.GetValueForArgument(argument0);

                return targetClass;
            };

            System.CommandLine.Handler.SetHandler(rootCommand, context =>
            {
                var targetClass = (TestApp.Commands.PrefixConvention.SingleHyphenCliCommand) BindFunc(context.ParseResult);

                //  Call the command handler
                targetClass.Run();
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        public static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.PrefixConvention.SingleHyphenCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
