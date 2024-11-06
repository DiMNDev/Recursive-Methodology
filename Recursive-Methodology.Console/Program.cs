using Recursive_Methodology.Library;
Console.WriteLine("Hello, World!");


SumThyNeighbor sumThyNeighbor = new SumThyNeighbor();

int sum = sumThyNeighbor.SumNeighbors(1000);

Console.WriteLine($"Sum: {sum}");

Fibonacci fibonacci = new Fibonacci();

int fibNum = fibonacci.fibonacciRecursionMethod(10);

Console.WriteLine($"Fibonacci: {fibNum}");

FindTheIndex findTheIndex = new FindTheIndex();
int index = findTheIndex.FindTheIndexOf(10);

Console.WriteLine($"index of 10: {index}");