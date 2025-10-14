using Azure;
using Azure.AI.TextAnalytics;

public class Program
{
    public static void Main()
    {
        Uri endpoint = new("https://rg-ai-language-service.cognitiveservices.azure.com/");
        AzureKeyCredential credential = new("");
        TextAnalyticsClient client = new(endpoint, credential);

        Console.WriteLine("Enter some text to analyze:");
        string text = Console.ReadLine();

        if (!string.IsNullOrEmpty(text))
        {
            DocumentSentiment sentiment = client.AnalyzeSentiment(text);
        
            Console.WriteLine($"\nOverall sentiment: {sentiment.Sentiment}");
            Console.WriteLine($"Positive: {sentiment.ConfidenceScores.Positive:P}");
            Console.WriteLine($"Neutral: {sentiment.ConfidenceScores.Neutral:P}");
            Console.WriteLine($"Negative: {sentiment.ConfidenceScores.Negative:P}");
        }
    }
}
