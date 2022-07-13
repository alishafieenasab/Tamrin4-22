Console.WriteLine("Hello, World!");

Console.WriteLine(RomanInt("MCMXCIV"));

int RomanInt(string aString)
{
    int sum = 0;
    int x = 0;
    int[] Roman = new int[aString.Length];
    for (int i = 0; i < aString.Length; i++)
    {
        switch (aString[i])
        {
            case 'I':
                Roman[i] = 1;
                break;
            case 'V':
                Roman[i] = 5;
                break;
            case 'X':
                Roman[i] = 10;
                break;
            case 'L':
                Roman[i] = 50;
                break;
            case 'C':
                Roman[i] = 100;
                break;
            case 'D':
                Roman[i] = 500;
                break;
            case 'M':
                Roman[i] = 1000;
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
    for (int i = Roman.Length - 1; i >= 0; i--)
    {
        if (i == 0)
        {
            if (Roman[0] < Roman[1])
                continue;
            else
                sum += Roman[0];
        }
        else
        {
            if (Roman[i] <= Roman[i - 1])
            {
                sum += Roman[i];
            }
            else
            {
                x = Roman[i] - Roman[i - 1];
                sum += x;
                i--;
            }
        }
    }
    return sum;
}