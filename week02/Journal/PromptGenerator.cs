public class PromptGenerator
{
    //Note that in C#, the list variable can be created and initialized in the same step.
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        string randomPrompt = _prompts[number];
        return randomPrompt;
    }
}