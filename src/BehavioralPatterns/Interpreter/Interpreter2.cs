namespace ConsoleApp1.src.BehavioralPatterns.Interpreter
{
    public class Interpreter2
    {
        private Context _context;

        public Interpreter2(Context context)
        {
            _context = context;
        }

        public int Interpret(string input) {
            IExpression expressionTree = BuildExpressionTree(input);
            return expressionTree.Interpret(_context);
        }

        private IExpression BuildExpressionTree(string input)
        {
            string[] tokens = input.Split(" ");
            var output = new Queue<string>();
            var operators = new Stack<string>();

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out _))
                    output.Enqueue(token);

                else if (token == "+" || token == "-") {
                    while (operators.Count > 0 && (operators.Peek() == "+" || operators.Peek() == "-"))
                        output.Enqueue(operators.Pop());
                    
                    operators.Push(token);
                }

                // not finished !!!!!!!!!!!!!!!!!!!!
            }

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