using System.Text.RegularExpressions;

namespace JanuaryUnitedProject2024.OtherTest;

public class CSharpBasics
{
    [Test]
    public void GetNumberFromText()
    {
        //The below code helps to extract the number '1000002711' out from the whole sentence
        string sentence = "Your reference is '1000002711'. c#";
        string pattern = @"\d+";
        string pattern2 = @"(.*)";

        Match match = Regex.Match(sentence, pattern2);
        Console.WriteLine(match.Success ? match.Value : "Not a match");
    }

    [Test]
    public void GetTextFrom()
    {
        //The below code helps to extract 'Your reference is' out from the whole sentence
        string sentence = "Your reference is \"1000002711\". c#";

        // Define the target phrase
        string targetPhrase = "Your reference is";

        // Find the index of the target phrase in the sentence
        int startIndex = sentence.IndexOf(targetPhrase);

        // Check if the target phrase is found
        if (startIndex != -1)
        {
            // Extract the substring containing the target phrase
            string extractedPhrase = sentence.Substring(startIndex, targetPhrase.Length);

            // Output the extracted phrase
            Console.WriteLine("Extracted phrase: " + extractedPhrase);
        }
        else
        {
            Console.WriteLine("Target phrase not found in the sentence.");
        }
    }

    [Test]
    public void GetTextFromWholeSentence()
    {
        //The below code helps to extract 'reference is \"1000002711\".' out from the whole sentence
        string sentence = "Your reference is '1000002711'. c#";
        string targetPhrase = "reference is \"1000002711\".";

        int startIndex = sentence.IndexOf(targetPhrase);
        string extractedPhrase =
            startIndex != -1
            ? sentence.Substring(startIndex, targetPhrase.Length)
            : sentence;
        Console.WriteLine(extractedPhrase);
    }
}
