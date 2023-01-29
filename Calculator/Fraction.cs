namespace Calculator;

public class Fraction : NumericExpression<double>
{
    private readonly NumericExpression<double> _numerator;
    private readonly NumericExpression<double> _denominator;

    public Fraction(NumericExpression<double> numerator, NumericExpression<double> denominator)
    {
        _numerator = numerator.ThrowIfNotInteger();
        _denominator = denominator.ThrowIfNotInteger().ThrowIfZero();
    }

    public override double ToResult() => _numerator.ToResult() / _denominator.ToResult();

    protected override string? CreateExpression() => $"{_numerator.ToResult()}/{_denominator.ToResult()}";

    protected override string? CreateExpressionSentence() => CreateExpression();
}