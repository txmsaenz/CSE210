
class PromptGenerator
{
    List<string> prompts;
    string prompt;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I do well today?",
            "What is something I struggled with today?",
            "What was the main priority today?  Did I complete it?",
            "What was a challenge today?  How did I work through it?",
            "Did I find time to relax today?  What did I do?",
        };    
    }

    public string GetRandomPrompt()
    {
        Random ran = new Random();
        int index = ran.Next(0,9);    
        prompt = prompts[index];
        
        return prompt;
    }
}