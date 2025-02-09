namespace ConsoleApp1.src.BehavioralPatterns.Interpreter
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}