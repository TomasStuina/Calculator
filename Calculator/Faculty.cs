namespace Calculator;

public class Faculty : UnaryOperation<double>
{
    public Faculty(NumericExpression<double> operand) : base(operand.ThrowIfNotPositiveInteger())
    {
    }

    protected override string? CreateExpression(string? expression) => $"({expression}!)";

    protected override string? CreateExpressionSentence(string? sentence) => $"faculty of {sentence}";

    protected override double ToResult(double value)
    {
        var factorial = 1;
        for (var i = 1; i <= value; i++) 
        { 
            factorial *= i;
        }

        return factorial;
    }
}