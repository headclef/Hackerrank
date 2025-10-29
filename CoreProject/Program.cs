/* Algorithm
 * a = 7
 * b = 3
 * 
 * static void Main(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
 * 
 * Define a solveMeFirst method that sums the value of two different integers
 */

// There are few ways to solve the problem.
// I'll just do the version that comes to my mind.

// Flow
static async Task Main()
{
    int a = 7;
    int b = 3;
    int sum = 0;
    Console.WriteLine(await SolveMeFirst(a, b, Approach.First));
    Console.WriteLine(await SolveMeFirst(a, b, Approach.Second));
    Console.WriteLine(await SolveMeFirst(a, b, Approach.Third));
    Console.WriteLine(await SolveMeFirst(a, b, Approach.Fourth));
}

/// <summary>
/// Pick which one you'll choose and return the answer
/// </summary>
static async Task<int> SolveMeFirst(int a, int b, Approach approach)
{
    switch (approach)
    {
        case Approach.First:
            return await ApproachOne(a, b);
        case Approach.Second:
            return await ApproachTwo(a, b);
        case Approach.Third:
            return await ApproachThree(a, b);
        case Approach.Fourth:
            return await ApproachFour(a, b);
        default:
            return await Task.FromResult(0);
    }
}

/// <summary>
/// First approach
/// </summary>
static async Task<int> ApproachOne(int a, int b)
{
    return await Task.FromResult(a + b);
}

/// <summary>
/// Second approach
/// </summary>
static async Task<int> ApproachTwo(int a, int b)
{
    int response = 0;
    response += a;
    response += b;
    return await Task.FromResult(response);
}

/// <summary>
/// Third approach
/// </summary>
static async Task<int> ApproachThree(int a, int b)
{
    int response = 0;
    response = a + b;
    return await Task.FromResult(response);
}

/// <summary>
/// Fourth approach
/// </summary>
static async Task<int> ApproachFour(int a, int b)
{
    int response = a + b;
    return await Task.FromResult(response);
}

enum Approach
{
    First,
    Second,
    Third,
    Fourth
}