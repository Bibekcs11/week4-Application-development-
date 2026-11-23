namespace week4workshop;

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Ram Bahadur Thapa";   // put your own full name
    }

    public int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total = total + n;
        }
        return total;
    }
    
}