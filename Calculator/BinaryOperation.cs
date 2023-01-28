namespace Calculator;

public abstract class BinaryOperation<T> : NumericOperation<T> where T : struct
{
    private readonly NumericExpression<T> _firstOperand;
    private readonly NumericExpression<T> _secondOperand;

    protected BinaryOperation(NumericExpression<T> firstOperand, NumericExpression<T> secondOperand)
    {
        _firstOperand = firstOperand;
        _secondOperand = secondOperand;
    }

    public sealed override string? PrintExpression() => PrintExpression(_firstOperand.PrintExpression(), _secondOperand.PrintExpression());

    public sealed override string? PrintExpressionSentence() => PrintExpressionSentence(_firstOperand.PrintExpressionSentence(), _secondOperand.PrintExpressionSentence());

    public sealed override T ToResult() => ToResult(_firstOperand.ToResult(), _secondOperand.ToResult());

    protected abstract string? PrintExpression(string? firstExpression, string? secondExpression);

    protected abstract string? PrintExpressionSentence(string? firstSentence, string? secondSentence);

    protected abstract T ToResult(T firstValue, T secondValue);
}
