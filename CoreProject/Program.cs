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
    sum = await SolveMeFirst(a, b, Approach.First);
    sum = await SolveMeFirst(a, b, Approach.Second);
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
            return await Approachtwo(a, b);
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
static async Task<int> Approachtwo(int a, int b)
{
    int response = 0;
    response += a;
    response += b;
    return await Task.FromResult(response);
}

enum Approach
{
    First,
    Second
}