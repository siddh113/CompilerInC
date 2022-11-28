using MiniTriangleCompiler.Compiler;
using System;
namespace Compiler.Nodes
{
    public class QuickIfCommandNode : ICommandNode
    {
        public IExpressionNode Expression { get; }

        public ICommandNode EqualCommand { get; }

        public Position Position { get; }

        public QuickIfCommandNode(IExpressionNode expression, ICommandNode equalCommand, Position position)
        {
            Expression = expression;
            EqualCommand = equalCommand;
            Position = position;
        }
    }
}
