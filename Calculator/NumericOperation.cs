namespace Calculator;

public class NumericOperation<T> : NumericExpression<T> where T : struct
{
    protected NumericOperation() : base(default)
    {
    }

    public sealed override string? PrintSentence() => $"{PrintExpressionSentence()} is {ToResult()}";

    public sealed override string? Print() => $"{PrintExpression()} = {ToResult()}";
}
