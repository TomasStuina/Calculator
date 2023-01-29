namespace Calculator;

public abstract class UnaryOperation<T> : NumericOperation<T> where T : struct
{
    private readonly INumericExpression? _operand;
    private readonly T _operandValue;

    protected UnaryOperation(NumericExpression<T> operand)
    {
        _operand = operand;
        _operandValue = operand.ToResult();
    }

    public sealed override T ToResult() => ToResult(_operandValue);

    protected sealed override string? CreateExpression() => CreateExpression(_operand?.ToExpression());

    protected sealed override string? CreateExpressionSentence() => CreateExpressionSentence(_operand?.ToExpressionSentence());

    protected abstract T ToResult(T operandValue);

    protected abstract string? CreateExpression(string? expression);

    protected abstract string? CreateExpressionSentence(string? expressionSentence);
}
