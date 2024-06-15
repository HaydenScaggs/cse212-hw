public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    /// Plan 1
    /// Desired Outcome: Generate an array of doubles starting from a given number and including its multiples up to a specified length.
    ///  Return
    ///  Loop to Populate Array
    /// Initialization
    /// Parameters What we need
    private static double[] MultiplesOf(double number, int length)
{
    if (length <= 0)/// Check for valid input if Greater than O
    {
        throw new ArgumentException("Length must be a positive integer greater than 0.");/// Show invalid if not correct
    }

    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = number * (i + 1);
    }
    return result;
}
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 and 
    /// data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list, rather than returning a new list.
    /// </summary>

    /// Plan 2 rotate 
    /// Desired Outcome: Rotate a List<int> to the right by a specified number of positions.
    /// Since the function modifies the list in place, it should return void.
    /// Check if amount is 0 or equals data.Count to handle no rotation scenario.
    /// Modifying using Insert and Remove offers a clear solutions 
    /// Calculate the starting index from which to begin the rotation (rotationIndex = data.Count - amount).
    /// Ensure the function correctly receives and uses the List<int> and amount parameters
    private static void RotateListRight(List<int> data, int amount)
{
    if (amount == 0 || amount == data.Count)
        return; // If amount is 0 or equal to data.Count, no rotation is needed
        
    int rotationIndex = data.Count - amount;// Calculate the index from where rotation should start

    List<int> rotatedPart = data.GetRange(rotationIndex, amount);// Step 1: Extract the elements to rotate

    data.InsertRange(0, rotatedPart);// Step 2: Insert the rotated elements at the beginning of the list

    data.RemoveRange(data.Count - amount, amount);   // Step 3: Remove the original elements from their previous position after rotation
}

}
