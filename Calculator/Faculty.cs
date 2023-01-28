namespace Calculator;

public class Faculty : UnaryOperation<double>
{
    public Faculty(NumericExpression<double> operand) : base(EnsureIsPositiveInteger(operand))
    {
    }

    protected override string? Print(string? expression)
    {
        return $"({expression}!)";
    }

    protected override string? PrintSentence(string? sentence)
    {
        return $"faculty of {sentence}";
    }

    protected override double ToResult(double value)
    {
        var factorial = 1;
        for (var i = 1; i <= value; i++) 
        { 
            factorial *= i;
        }

        return factorial;
    }

    private static NumericExpression<double> EnsureIsPositiveInteger(NumericExpression<double> operand)
    {
        var operandValue = operand.ToResult();
        var isPositiveInteger = BitConverter.DoubleToInt64Bits(operandValue) >= 0 
            && double.IsFinite(operandValue) && operandValue == Math.Truncate(operandValue);

        if (!isPositiveInteger)
        {
            throw new ArgumentException("Operand must be a positive integer", nameof(operand));
        }

        return operand;
    }
}