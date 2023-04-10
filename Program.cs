int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
    14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };

Console.Write("Prime numbers: ");

foreach (int num in nums)
{
    //by definition, 1 is not a prime
    if (num == 1) continue;

    //skip the calculations for 2 and 3, because they are primes
    if (num == 2 || num == 3)
    {
        Console.Write(num + " ");
        continue;
    }
    //square root calculation of number in question
    int i = (int)Math.Sqrt(num);
    bool isPrime = true;
    //when i is smaller than 1 we terminate the loop 
    while (i > 1)
    {
        //if the remainder division operator returns 0 for any of the i values then the number in question is not a prime
        if (num % i == 0)
        {
            isPrime = false;
        }
        //we use the decrement operator to decrease the i by one each loop cycle 
        i--;
    }

    if (isPrime)
    {
        Console.Write(num + " ");
    }
}

Console.Write('\n');