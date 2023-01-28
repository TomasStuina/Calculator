namespace Calculator;

public class Sum : BinaryOperation<double>
{
    public Sum(NumericExpression<double> firstOperand, NumericExpression<double> secondOperand)
        : base(firstOperand, secondOperand)
    {
    }

    protected override string? PrintExpression(string? firstExpression, string? secondExpression) => $"({firstExpression} + {secondExpression})";

    protected override string? PrintExpressionSentence(string? firstSentence, string? secondSentence) => $"sum of {firstSentence} and {secondSentence}";

    protected override double ToResult(double firstValue, double secondValue) => firstValue + secondValue;
}
