namespace Calculator;

public abstract class UnaryOperation<T> : NumericOperation<T> where T : struct
{
    private readonly NumericExpression<T> _operand;

    public UnaryOperation(NumericExpression<T> operand)
    {
        _operand = operand;
    }

    public sealed override T ToResult() => ToResult(_operand.ToResult());

    public sealed override string? PrintExpression() => PrintExpression(_operand.PrintExpression());

    public sealed override string? PrintExpressionSentence() => PrintExpressionSentence(_operand.PrintExpressionSentence());

    protected abstract string? PrintExpression(string? expression);

    protected abstract string? PrintExpressionSentence(string? sentence);

    protected abstract T ToResult(T value);
}
