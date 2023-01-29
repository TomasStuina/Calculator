namespace Calculator;

public abstract class BinaryOperation<T> : NumericOperation<T> where T : struct
{
    private readonly INumericExpression? _firstOperand;
    private readonly INumericExpression? _secondOperand;
    private readonly T _firstOperandValue;
    private readonly T _secondOperandValue;

    protected BinaryOperation(NumericExpression<T> firstOperand, NumericExpression<T> secondOperand)
    {
        _firstOperand = firstOperand;
        _secondOperand = secondOperand;
        _firstOperandValue = firstOperand.ToResult();
        _secondOperandValue = secondOperand.ToResult();
    }

    public sealed override T ToResult() => ToResult(_firstOperandValue, _secondOperandValue);

    protected sealed override string? CreateExpression() =>
        CreateExpression(_firstOperand?.ToExpression(), _secondOperand?.ToExpression());

    protected sealed override string? CreateExpressionSentence() =>
        CreateExpressionSentence(_firstOperand?.ToExpressionSentence(), _secondOperand?.ToExpressionSentence());

    protected abstract T ToResult(T firstOperandValue, T secondOperandValue);

    protected abstract string? CreateExpression(string? firstExpression, string? secondExpression);

    protected abstract string? CreateExpressionSentence(string? firstExpressionSentence, string? secondExpressionSentence);
}
