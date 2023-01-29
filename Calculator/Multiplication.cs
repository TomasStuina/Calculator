namespace Calculator;

public class Multiplication : BinaryOperation<double>
{
    public Multiplication(NumericExpression<double> firstOperand, NumericExpression<double> secondOperand)
        : base(firstOperand, secondOperand)
    {
    }

    protected override string? CreateExpression(string? firstExpression, string? secondExpression) =>
        $"({firstExpression} * {secondExpression})";

    protected override string? CreateExpressionSentence(string? firstSentence, string? secondSentence) =>
        $"multiplication of {firstSentence} and {secondSentence}";

    protected override double ToResult(double firstValue, double secondValue) => firstValue * secondValue;
}