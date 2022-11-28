using System;

namespace Compiler.Nodes
{
    public class BeginCommandNode : ICommandNode
    {
        public ICommandNode BeginCommand { get; }

        public ICommandNode EndCommand { get; }

        public ICommandNode Command { get; }

        public Position Position { get; }

        public BeginCommandNode(ICommandNode beginCommand, ICommandNode endCommand, ICommandNode command, Position position)
        {
            BeginCommand = beginCommand;
            Command = command;
            EndCommand = endCommand;
            Position = position;
        }
    }
}