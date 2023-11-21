using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;

public class Frame : Form
{
    StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
    
    private class WordList
    {
        public IList<string[]> English;
        public string[] EBulgarian;
        //public IList<IList<string>> Deutsch;
        //public List<List<string>> DBulgarian;
    }
    
    public Frame()
    {
        string jsonFile =
            File.ReadAllText(Path.GetDirectoryName(stackFrame.GetFileName()) + @"\Word Lists\Word List.json");

        var deserialized = JsonConvert.DeserializeObject<WordList>(jsonFile); //how to deserialize

        for(int i = 0; i < deserialized.English.Count; i++)
        {
            Console.Write(deserialized.EBulgarian[i] + " - ");
            
            foreach (var word in deserialized.English[i])
            {
                Console.Write(word);
                if ( ! word.Equals( (deserialized.English[i])[deserialized.English[i].Length - 1] ) )
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
        
        
        
    }
    
}

static class Program
{
    static void Main()
    {
        new Frame();
    }
}