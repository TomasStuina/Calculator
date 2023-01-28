namespace Calculator;

public abstract class NumericOperation<T> : NumericExpression<T> where T : struct
{
    protected NumericOperation() : base(default)
    {
    }

    public override sealed string? PrintSentence() => $"{PrintExpressionSentence()} is {ToResult()}";

    public override sealed string? Print() => $"{PrintExpression()} = {ToResult()}";
}
