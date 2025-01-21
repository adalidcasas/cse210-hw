public class PromptGenerator
{
    public static List<string> _prompts = new List<string>(){
        "Write a word or phrase that represents or that you learned yesterday.",
        "Is there anything you would like to change or improve about today?",
        "What was the best moment of the day?",
        "How did you feel today?",
        "Did you meet someone special?",
        "On a scale from 1 to 10, how would you rate your day?",
        "Is there anything you are thankful for today?",
        "Were there any challenges or difficulties today?",
        "Have you felt God's hand in your life today?",
        "What blessings did you receive today?",
        "Did you help someone today or provide some kind of service?",
        "How was work?",
        "How is your family today?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }
}