using System.Runtime.CompilerServices;

namespace Calculator;

public static class NumericExpressionExtensions
{
    public static NumericExpression<double> ThrowIfZero(this NumericExpression<double> expression,
        [CallerArgumentExpression(nameof(expression))] string paramName = "")
    {
        if (Math.Abs(expression) < double.Epsilon)
        {
            throw new ArgumentException("Cannot be zero.", paramName);
        }

        return expression;
    }

    public static NumericExpression<double> ThrowIfNotPositiveInteger(this NumericExpression<double> expression,
        [CallerArgumentExpression(nameof(expression))] string paramName = "")
    {
        var expressionValue = expression.ToResult();

        if (!double.IsPositive(expressionValue) || !double.IsInteger(expressionValue))
        {
            throw new ArgumentException("Must be a positive integer.", paramName);
        }

        return expression;
    }
}