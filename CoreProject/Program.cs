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
}

// First approach
static async Task<int> SolveMeFirst(int a, int b, Approach approach)
{
    switch (approach)
    {
        case Approach.First:
            return await ApproachOne(a, b);
        default:
            return await Task.FromResult(0);
    }
}

static async Task<int> ApproachOne(int a, int b)
{
    return await Task.FromResult(a + b);
}

enum Approach
{
    First
}