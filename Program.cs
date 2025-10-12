public class Program
{
    public static void Main()
    {
        string endpoint = "https://rg-ai-language-service.cognitiveservices.azure.com/";
        string key = "";

        var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(key));

        Console.WriteLine("Enter some text to analyze:");
        string text = Console.ReadLine();

        DocumentSentiment sentiment = client.AnalyzeSentiment(text);

        Console.WriteLine($"\nOverall sentiment: {sentiment.Sentiment}");
        Console.WriteLine($"Positive: {sentiment.ConfidenceScores.Positive:P}");
        Console.WriteLine($"Neutral: {sentiment.ConfidenceScores.Neutral:P}");
        Console.WriteLine($"Negative: {sentiment.ConfidenceScores.Negative:P}");
    }
}
