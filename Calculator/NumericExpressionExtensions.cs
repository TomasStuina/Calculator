using System.Runtime.CompilerServices;

namespace Calculator;

public static class NumericExpressionExtensions
{
    public static NumericExpression<double> ThrowIfZero(this NumericExpression<double> expression,
        [CallerArgumentExpression(nameof(expression))] string paramName = "")
    {
        if (Math.Abs(expression.ToResult()) < double.Epsilon)
        {
            throw new ArgumentException("Cannot be zero.", paramName);
        }

        return expression;
    }

    public static NumericExpression<double> ThrowIfNotPositiveInteger(this NumericExpression<double> expression,
        [CallerArgumentExpression(nameof(expression))] string paramName = "")
    {
        if (!double.IsPositive(expression.ThrowIfNotInteger().ToResult()))
        {
            throw new ArgumentException("Must be a positive integer.", paramName);
        }

        return expression;
    }

    public static NumericExpression<double> ThrowIfNotInteger(this NumericExpression<double> expression,
    [CallerArgumentExpression(nameof(expression))] string paramName = "")
    {
        if (!double.IsInteger(expression.ToResult()))
        {
            throw new ArgumentException("Must be an integer.", paramName);
        }

        return expression;
    }
}