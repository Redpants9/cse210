public class PromptGenerator{
    public List<string> prompts = new List<string>
    {
    "This is a question",
    "Here is another Question",
    "This is a third Question"
    };


    public string randomprompt()
    {
        int number = prompts.Count();
        Random rng = new Random();
        int index = rng.Next(0,number);
        string prompt = prompts[index];
        return prompt;
    }
}