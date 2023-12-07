using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

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
        
        ListDisplayCheck();
        
        SaveJsonFile();
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

    private void ListDisplayCheck()
    {
        Console.WriteLine("\n");
        
        for (int i = 0; i < Math.Max(jsonList.Term.Count, jsonList.Meaning.Count); i++)
        {
            if (i < jsonList.Term.Count)
            {
                for (int j = 0; j < jsonList.Term[i].Length; j++)
                {
                    Console.Write(jsonList.Term[i][j] + " ");
                }
            }
            else
            {
                Console.Write("term");
            }
            
            Console.Write("- ");

            if (i < jsonList.Meaning.Count)
            {
                for (int j = 0; j < jsonList.Meaning[i].Length; j++)
                {
                    Console.Write(jsonList.Meaning[i][j] + " ");
                }
            }
            else
            {
                Console.Write("meaning");
            }
            

            Console.WriteLine();
            
        }
    }

    private void SaveJsonFile()
    {
        Console.WriteLine("Do you want to save the file? ('yes' or 'no')");

        string scanner = Console.ReadLine();
        
        if (scanner.ToLower().Equals("yes"))
        {
            File.WriteAllText(
                Script.wordListDirectory + wordListName +".json" , 
                JsonConvert.SerializeObject(jsonList));
            
            Console.WriteLine("saved!");
        }
        else if(scanner.ToLower().Equals("no"))
        {
            Console.WriteLine("did not save!");
        }
        else
        {
            SaveJsonFile();
        }
    }
}

public class AddWords
{
    private List<string[]> wordList;
    private List<string> currentSynList = new List<string>();
    private string allWords;
    private int currentChar, startingChar;
    private int currentWordStart, currentWordEnd;
        
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

            RemoveUnnecessary(currentSynList[currentSynList.Count - 1]);
            
            startingChar = currentChar + 1;
        }
    }
    private void CheckNewWord(bool lastTerm = false)
    {
        if (lastTerm || allWords[currentChar] == ';')
        {
            CheckWordSyn(true);

            if (currentSynList.Count != 0)
            {
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

    private void RemoveUnnecessary(string word) //checks for unnecessary spaces and empty words
    {
        int pos = 0;
        
        for(int i = 0; i < word.Length; i++)
        {
            if (!word[i].Equals(' '))
            {
                break;
            }
            pos++;
        }
        word = word.Substring(pos, word.Length - pos);
        
        pos = 0;
        for(int i = 0; i < word.Length; i++)
        {
            if (!word[word.Length - i - 1].Equals(' '))
            {
                break;
            }
            pos++;
        }
        word = word.Substring(0, word.Length - pos);

        if (word.Equals(""))
        {
            currentSynList.RemoveAt(currentSynList.Count - 1);
        }
        else
        {
            currentSynList[currentSynList.Count - 1] = word;
        }
    }
}