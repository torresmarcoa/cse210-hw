using System;
using System.Collections.Generic;
public class PromptGenerator
{
    // list of prompts to chose from
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day",
        "How did I see the hand of the Lord in my life today",
        "What is a decision I made today that I am proud of?",
        "What is a goal I accomplished today?",
        "What is something new I learned today",
        "What is a mistake I made today and what did I learn from it?",
        "What is something I can do different tomorrow?",
        "What is something I'm grateful for today?",
        "What is a piece of feedback I received today, and how do I want to act on it?"
    };

    // method that returns a random prompt
    public string GetRandomPrompt()
    {
        // create a new instance of Random to generate random numbers
        Random random = new Random();

        // generate a random index within the range of prompt list
        int randomIndex = random.Next(0, _prompts.Count);

        // return the random prompt at the generated index
        return _prompts[randomIndex];
    }
}