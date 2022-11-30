namespace Compiler.Nodes
{
    public class LoopCommandNode : ICommandNode
    {

        public ICommandNode LoopCommand { get; }

        public IExpressionNode WhileExpression { get; }

        public ICommandNode WhileCommand { get; }

        public Position Position { get; }

        public LoopCommandNode(ICommandNode loopCommand, IExpressionNode whileExpression, ICommandNode whileCommand, Position position)
        {
            LoopCommand = loopCommand;
            WhileExpression = whileExpression;
            WhileCommand = whileCommand;
            Position = position;
        }

    }
}