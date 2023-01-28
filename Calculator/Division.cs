﻿namespace Calculator;

public class Division : BinaryOperation<double>
{
    public Division(NumericExpression<double> firstOperand, NumericExpression<double> secondOperand)
        : base(firstOperand, secondOperand.ThrowIfZero())
    {
    }

    protected override string? PrintExpression(string? firstExpression, string? secondExpression)
    {
        return $"({firstExpression} / {secondExpression})";
    }

    protected override string? PrintExpressionSentence(string? firstSentence, string? secondSentence)
    {
        return $"division of {firstSentence} and {secondSentence}";
    }

    protected override double ToResult(double firstValue, double secondValue)
    {
        return firstValue / secondValue;
    }
}
