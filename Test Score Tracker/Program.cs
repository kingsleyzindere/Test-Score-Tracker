

// Collect 3 valid test scores from the user and calculate the total and average score.
//Heading
Console.WriteLine("Test Score Tracker");


//Creating Our List to hold the scores
List<int> scores = new List<int>();




do
{
    

        Console.WriteLine("Enter a number between 0 and 100");

        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num > 100)
            {
                Console.WriteLine("Invalid number. Please enter a number between 0 and 100.");

            }
            else { scores.Add(num); }
        }

        catch
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }



    
}
while (scores.Count < 3);



int total = 0;

foreach (int score in scores)
{
    Console.WriteLine(score);
    total += score;
}

Console.WriteLine($"Total Score: {total}");
    if (scores.Count > 0)
    {
        double avg = (double)total / scores.Count;
        Console.WriteLine($"Average Score: {avg}");
    }
    else
    {
        Console.WriteLine("No scores to calculate average.");
    }

