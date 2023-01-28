namespace Calculator;

public class NumericExpression<T> where T : struct
{
    private readonly T _numericValue;

    public NumericExpression(T numericValue)
    {
        _numericValue = numericValue;
    }

    public virtual string? PrintSentence() => PrintExpressionSentence();

    public virtual string? Print() => PrintExpression();

    public virtual string? PrintExpressionSentence() => PrintExpression();

    public virtual string? PrintExpression() => ToResult().ToString();

    public virtual T ToResult() => _numericValue;


    public static implicit operator NumericExpression<T>(T value) => new(value);


    public static implicit operator T(NumericExpression<T> value) => value.ToResult();
}