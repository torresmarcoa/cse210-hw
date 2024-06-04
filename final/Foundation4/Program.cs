using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("6/3/2024", 30, "Running", 5);
        Biking biking = new Biking("6/7/2024", 40, "Biking", 30);
        Swimming swimming = new Swimming("6/10/2024", 20, "Swimming", 5);

        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}