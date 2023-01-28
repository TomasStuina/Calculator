namespace Calculator;

public abstract class UnaryOperation<T> : NumericOperation<T> where T : struct
{
    private readonly NumericExpression<T> _operand;

    public UnaryOperation(NumericExpression<T> operand)
    {
        _operand = operand;
    }

    public sealed override T ToResult() => ToResult(_operand.ToResult());

    public sealed override string? PrintExpression() => Print(_operand.PrintExpression());

    public sealed override string? PrintExpressionSentence() => PrintSentence(_operand.PrintExpressionSentence());

    protected abstract string? Print(string? expression);

    protected abstract string? PrintSentence(string? sentence);

    protected abstract T ToResult(T value);
}
