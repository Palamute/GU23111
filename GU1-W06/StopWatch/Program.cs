using System.ComponentModel.Design;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        const int arraySize = 100000;
        int[]numbers = new int[arraySize];
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next();
        }
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        SlectionSort(numbers);
        stopWatch.Stop();
        long elapsedTime = stopWatch.GetElapsedTime();
        Console.WriteLine($"Elapsed Time: {elapsedTime} miliseconds");
    }
    static void SlectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int minIndex = i;
            for (int j = i+1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;
    public DateTime StartTime
    {
        get{return startTime;}
    }
    public DateTime EndTime
    {
        get{return endTime;}
    }
    public StopWatch()
    {
        startTime = DateTime.Now;
    }
    public void Start()
    {
        startTime = DateTime.Now;
    }
    public void Stop()
    {
        endTime = DateTime.Now;
    }
    public long GetElapsedTime()
    {
        TimeSpan elapsed = endTime - startTime;
        return (long)elapsed.TotalMilliseconds;
    }
}