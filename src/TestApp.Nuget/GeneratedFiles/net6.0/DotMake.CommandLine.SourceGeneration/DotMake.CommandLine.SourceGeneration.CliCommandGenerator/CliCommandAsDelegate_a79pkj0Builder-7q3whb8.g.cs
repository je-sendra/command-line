﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.7.2.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace GeneratedCode
{
    /// <inheritdoc />
    public class CliCommandAsDelegate_a79pkj0Builder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public CliCommandAsDelegate_a79pkj0Builder()
        {
            DefinitionType = typeof(GeneratedCode.CliCommandAsDelegate_a79pkj0);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private GeneratedCode.CliCommandAsDelegate_a79pkj0 CreateInstance()
        {
            return new GeneratedCode.CliCommandAsDelegate_a79pkj0();
        }

        /// <inheritdoc />
        public override System.CommandLine.Command Build()
        {
            // Command for 'CliCommandAsDelegate_a79pkj0' class
            var rootCommand = new System.CommandLine.RootCommand()
            {
            };

            var defaultClass = CreateInstance();

            // Option for 'option1' property
            var option0 = new System.CommandLine.Option<bool>
            (
                "--option-1",
                GetParseArgument<bool>
                (
                    null
                )
            )
            {
                IsRequired = false,
            };
            option0.SetDefaultValue(defaultClass.option1);
            option0.AddAlias("-o");
            rootCommand.Add(option0);

            // Argument for 'argument1' property
            var argument0 = new System.CommandLine.Argument<string>
            (
                "argument-1",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
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
                targetClass.option1 = GetValueForOption(parseResult, option0);

                //  Set the parsed or default values for the arguments
                targetClass.argument1 = GetValueForArgument(parseResult, argument0);

                return targetClass;
            };

            System.CommandLine.Handler.SetHandler(rootCommand, async context =>
            {
                var targetClass = (GeneratedCode.CliCommandAsDelegate_a79pkj0) BindFunc(context.ParseResult);

                //  Call the command handler
                context.ExitCode = await targetClass.RunAsync();
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new GeneratedCode.CliCommandAsDelegate_a79pkj0Builder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
