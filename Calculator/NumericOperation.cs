namespace Calculator;

public abstract class NumericOperation<T> : NumericExpression<T> where T : struct
{
    public sealed override string? Print() => $"{CreateExpression()} = {ToResult()}";

    public sealed override string? PrintSentence() => $"{CreateExpressionSentence()} is {ToResult()}";
}