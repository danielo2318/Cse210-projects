using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What is one thing you're grateful for?",
        "Describe a challenging moment and how you overcame it.",
        "What are your goals for tomorrow?"
    };

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}