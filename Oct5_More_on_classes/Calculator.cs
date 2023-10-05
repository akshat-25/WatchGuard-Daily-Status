public class Calculator
{

    /* The Params keyword lets us specify a parameter method that takes a variable
    number of arguements. We can send a comma seperated list of arguements, or an 
    array, or no arguements. Params keyword should be the last one in a method declaration,
    and only one params keyword is permitted in a method declaration.
     
     */
    public int Add(int X, params int[] numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}