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