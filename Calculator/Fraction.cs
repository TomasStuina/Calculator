namespace Calculator;

public class Fraction : NumericExpression<double>
{
    private readonly NumericExpression<double> _numerator;
    private readonly NumericExpression<double> _denominator;

    public Fraction(NumericExpression<double> numerator, NumericExpression<double> denominator)
        : base(numerator / denominator.ThrowIfZero())
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public override string? PrintExpressionSentence() => $"{_numerator.ToResult()}/{_denominator.ToResult()}";

    public override string? PrintExpression() => $"({PrintExpressionSentence()})";
}