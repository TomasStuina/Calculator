namespace Calculator;

public class Multiplication : BinaryOperation<double>
{
    public Multiplication(NumericExpression<double> firstOperand, NumericExpression<double> secondOperand)
        : base(firstOperand, secondOperand)
    {
    }

    protected override string? PrintExpression(string? firstExpression, string? secondExpression)
    {
        return $"({firstExpression} * {secondExpression})";
    }

    protected override string? PrintExpressionSentence(string? firstSentence, string? secondSentence)
    {
        return $"multiplication of {firstSentence} and {secondSentence}";
    }

    protected override double ToResult(double firstValue, double secondValue)
    {
        return firstValue * secondValue;
    }
}