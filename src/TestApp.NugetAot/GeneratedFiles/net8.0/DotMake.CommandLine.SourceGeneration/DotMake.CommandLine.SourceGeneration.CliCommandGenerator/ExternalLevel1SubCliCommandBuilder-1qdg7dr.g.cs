﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.7.2.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands.External
{
    /// <inheritdoc />
    public class ExternalLevel1SubCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public ExternalLevel1SubCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.External.ExternalLevel1SubCliCommand);
            ParentDefinitionType = typeof(TestApp.Commands.RootWithExternalChildrenCliCommand);
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.External.ExternalLevel1SubCliCommand CreateInstance()
        {
            return new TestApp.Commands.External.ExternalLevel1SubCliCommand();
        }

        /// <inheritdoc />
        public override System.CommandLine.Command Build()
        {
            // Command for 'ExternalLevel1SubCliCommand' class
            var command = new System.CommandLine.Command("Level1External")
            {
                Description = "An external level 1 sub-command",
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
            command.Add(option0);

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
            command.Add(argument0);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                command.Add(child.Build());
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

            System.CommandLine.Handler.SetHandler(command, context =>
            {
                var targetClass = (TestApp.Commands.External.ExternalLevel1SubCliCommand) BindFunc(context.ParseResult);

                //  Call the command handler
                targetClass.Run(context);
            });

            return command;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.External.ExternalLevel1SubCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }

        /// <inheritdoc />
        public class Level2SubCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
        {
            /// <inheritdoc />
            public Level2SubCliCommandBuilder()
            {
                DefinitionType = typeof(TestApp.Commands.External.ExternalLevel1SubCliCommand.Level2SubCliCommand);
                ParentDefinitionType = typeof(TestApp.Commands.External.ExternalLevel1SubCliCommand);
                NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
                NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
                ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
                ShortFormAutoGenerate = true;
            }

            private TestApp.Commands.External.ExternalLevel1SubCliCommand.Level2SubCliCommand CreateInstance()
            {
                return new TestApp.Commands.External.ExternalLevel1SubCliCommand.Level2SubCliCommand();
            }

            /// <inheritdoc />
            public override System.CommandLine.Command Build()
            {
                // Command for 'Level2SubCliCommand' class
                var command = new System.CommandLine.Command("level-2")
                {
                    Description = "A nested level 2 sub-command",
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
                command.Add(option0);

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
                command.Add(argument0);

                // Add nested or external registered children
                foreach (var child in Children)
                {
                    command.Add(child.Build());
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

                System.CommandLine.Handler.SetHandler(command, context =>
                {
                    var targetClass = (TestApp.Commands.External.ExternalLevel1SubCliCommand.Level2SubCliCommand) BindFunc(context.ParseResult);

                    //  Call the command handler
                    targetClass.Run(context);
                });

                return command;
            }

            [System.Runtime.CompilerServices.ModuleInitializerAttribute]
            internal static void Initialize()
            {
                var commandBuilder = new TestApp.Commands.External.ExternalLevel1SubCliCommandBuilder.Level2SubCliCommandBuilder();

                // Register this command builder so that it can be found by the definition class
                // and it can be found by the parent definition class if it's a nested/external child.
                commandBuilder.Register();
            }
        }
    }
}
