namespace Calculator;

public abstract class NumericExpression<T> : INumericExpression where T : struct
{
    public virtual string? Print() => CreateExpression();

    public virtual string? PrintSentence() => CreateExpressionSentence();

    public abstract T ToResult();

    string? INumericExpression.ToExpression() => CreateExpression();

    string? INumericExpression.ToExpressionSentence() => CreateExpressionSentence();

    protected abstract string? CreateExpression();

    protected abstract string? CreateExpressionSentence();

    public static implicit operator NumericExpression<T>(T value) => new NumericValueExpression(value);

    private class NumericValueExpression : NumericExpression<T>
    {
        private readonly T _value;

        public NumericValueExpression(T value)
        {
            _value = value;
        }

        public override T ToResult() => _value;

        protected override string? CreateExpression() => _value.ToString();

        protected override string? CreateExpressionSentence() => _value.ToString();
    }
}
