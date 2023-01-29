namespace Calculator;

public class Sum : BinaryOperation<double>
{
    public Sum(NumericExpression<double> firstOperand, NumericExpression<double> secondOperand)
        : base(firstOperand, secondOperand)
    {
    }

    protected override string? CreateExpression(string? firstExpression, string? secondExpression) =>
        $"({firstExpression} + {secondExpression})";

    protected override string? CreateExpressionSentence(string? firstExpressionSentence, string? secondExpressionSentence) =>
        $"sum of {firstExpressionSentence} and {secondExpressionSentence}";

    protected override double ToResult(double firstOperandValue, double secondOperandValue) => firstOperandValue + secondOperandValue;
}
