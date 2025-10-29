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
    Console.WriteLine($"{nameof(Approach.First)} " + Convert.ToString(await SolveMeFirst(a, b, Approach.First)));
    Console.WriteLine($"{nameof(Approach.Second)} " + Convert.ToString(await SolveMeFirst(a, b, Approach.Second)));
    Console.WriteLine($"{nameof(Approach.Third)} " + Convert.ToString(await SolveMeFirst(a, b, Approach.Third)));
    Console.WriteLine($"{nameof(Approach.Fourth)} " + Convert.ToString(await SolveMeFirst(a, b, Approach.Fourth)));
    Console.WriteLine($"{nameof(Approach.Fifth)} " + Convert.ToString(await SolveMeFirst(a, b, Approach.Fifth)));
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
        case Approach.Fifth:
            return await ApproachFive(a, b);
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

/// <summary>
/// Fifth approach
/// </summary>
static async Task<int> ApproachFive(int a, int b) => await Task.FromResult(a + b);

enum Approach
{
    First,
    Second,
    Third,
    Fourth,
    Fifth
}