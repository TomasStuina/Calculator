namespace Calculator;

public class Division : BinaryOperation<double>
{
    public Division(NumericExpression<double> firstOperand, NumericExpression<double> secondOperand)
        : base(firstOperand, secondOperand.ThrowIfZero())
    {
    }

    protected override string? CreateExpression(string? firstExpression, string? secondExpression) =>
        $"({firstExpression} / {secondExpression})";

    protected override string? CreateExpressionSentence(string? firstSentence, string? secondSentence) =>
        $"division of {firstSentence} and {secondSentence}";

    protected override double ToResult(double firstValue, double secondValue) => firstValue / secondValue;
}
