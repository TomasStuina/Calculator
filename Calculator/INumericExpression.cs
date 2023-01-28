namespace Calculator;

public interface INumericExpression<T> where T : struct
{
    string? Print();
    string? PrintSentence();

    T ToResult();

}
