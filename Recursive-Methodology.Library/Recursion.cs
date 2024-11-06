
namespace Recursive_Methodology.Library;

public class FindTheIndex
{
    public List<int> list = [1, 2, 3, 4, 5, 10, 7, 8, 9, 6];

    public int FindTheIndexOf(int numberToFind)
    {
        return FindTheIndexOf(list.Count() - 1, numberToFind);
    }
    public int FindTheIndexOf(int index, int numberToFind)
    {
        if (list[index] == numberToFind)
        {
            return index;
        }
        return FindTheIndexOf(index - 1, numberToFind);
    }
}

public class SumThyNeighbor
{

    public int SumNeighbors(int currentNumber)
    {

        if (currentNumber == 0)
        {
            return 0;
        }
        else if (currentNumber == 1)
        {
            return 1;
        }
        else
        {
            return currentNumber + SumNeighbors(currentNumber - 1);
        }

    }
}

public class Fibonacci
{
    public int fibonacciRecursionMethod(int currentNumber)
    {

        if (currentNumber == 0)
        {
            return 0;
        }
        else if (currentNumber == 1)
        {
            return 1;
        }
        else
        {
            return fibonacciRecursionMethod(currentNumber - 1) + fibonacciRecursionMethod(currentNumber - 2);
        }
    }
}

public class RecursiveMath {
    public static int Factorial(int number) {

        if(number <= 0) {
            throw new DoneDidMessedUpException("Must be a positive integer!");
        }
        if(number <=1) {
            return number;
        }
        return number * Factorial(number -1);
    }
}

[Serializable]
public class DoneDidMessedUpException : Exception
{
    public DoneDidMessedUpException()
    {
    }

    public DoneDidMessedUpException(string? message) : base(message)
    {
    }

    public DoneDidMessedUpException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}