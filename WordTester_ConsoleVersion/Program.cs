

using System;
using System.Collections.Generic;

class Script
{
    public void InitiateScript()
    {
        
        Console.Write("'a' - add word list\n's' - start: ");

        switch (Console.ReadLine())
        {
            case "a": 
                InitiateWordList();
                break;
            
            case "s": 
                InitiateMainFunction();
                break;
            
            default: 
                InitiateScript();
                break;
        }

    }

    private void InitiateWordList()
    {
        CreateNewWordList createWL = new CreateNewWordList();
        createWL.Create();
    }

    private void InitiateMainFunction()
    {
        
    }

}

class CreateNewWordList
{
    private class WordList
    {
        public List<string[]> Term;
        public List<string[]> Meaning;
    }

    private WordList jsonList = new WordList();
    private string wordListName, allTerms, allMeanings;
    
    public void Create()
    {
        EnterDetails();
        EnterAllWords();

        AddWords addTerms = new AddWords();
        
        jsonList.Term = addTerms.Start(allTerms);
        jsonList.Meaning = addTerms.Start(allMeanings);
        
        ListCheck();
        
        
    }

    private void EnterDetails()
    {
        Console.Write("Enter the name of your word list: ");
        wordListName = Console.ReadLine();
    }

    private void EnterAllWords()
    {
        Console.WriteLine("\n\nEnter all of your terms separated with ';' and the synonyms with ',': ");
        allTerms = Console.ReadLine();
        
        Console.WriteLine("\n\nEnter all of your meanings: ");
        allMeanings = Console.ReadLine();
    }

    private class AddWords
    {
        private List<string[]> wordList;
        private List<string> currentSynList = new List<string>();
        private string allWords;
        private int currentChar, startingChar;
        
        public List<string[]> Start(string words)
        {
            allWords = words;
            SetDefaultValues();
            
            while (true)
            {
                if (currentChar == allWords.Length)
                {
                    CheckNewWord(true);
                
                    break;
                }
            
                CheckWordSyn();

                CheckNewWord();
            
                currentChar++;
            }

            return wordList;
        }

        private void SetDefaultValues()
        {
            wordList = new List<string[]>();
            currentChar = 0;
            startingChar = 0;
        }
        
        private void CheckWordSyn(bool lastSyn = false)
        {
            if (lastSyn || allWords[currentChar] == ',')
            {
                currentSynList.Add(allWords.Substring(startingChar, currentChar - startingChar));

                startingChar = currentChar + 1;
            }
        }
        
        private void CheckNewWord(bool lastTerm = false)
        {
            if (lastTerm || allWords[currentChar] == ';')
            {
                CheckWordSyn(true);

                string[] currentStr = new string[currentSynList.Count];

                for (int i = 0; i < currentSynList.Count; i++)
                {
                    currentStr[i] = currentSynList[i];
                }
                
                wordList.Add(currentStr);

                currentSynList = new List<string>();
            }
        }
    }

    private void ListCheck()
    {
        for (int i = 0; i < jsonList.Term.Count; i++)
        {
            for (int j = 0; j < jsonList.Term[i].Length; j++)
            {
                Console.Write(jsonList.Term[i][j] + " ");
            }
            
            Console.Write("- ");
            
            for (int j = 0; j < jsonList.Meaning[i].Length; j++)
            {
                Console.Write(jsonList.Meaning[i][j] + " ");
            }

            Console.WriteLine();
            
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Script script = new Script();
        script.InitiateScript();

    }
}