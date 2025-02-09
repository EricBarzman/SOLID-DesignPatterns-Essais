namespace ConsoleApp1.src.BehavioralPatterns.Interpreter
{
    public class Interpreter
    {
        private Context _context;

        public Interpreter(Context context)
        {
            _context = context;
        }

        public int Interpret(string input) {
            IExpression expressionTree = BuildExpressionTree(input);
            return expressionTree.Interpret(_context);
        }

        private IExpression BuildExpressionTree(string input) {
            // Hardcoded parser
            input = "1 + 2 * 3";
            IExpression expressionTree = new AdditionExpression(
                new MultiplicationExpression(
                    new NumberExpression("2"),
                    new NumberExpression("3")
                ),
                new NumberExpression("1")
            );
            return expressionTree;
        }
    }
}