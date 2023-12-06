using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class SetUpQuiz
{
    private class WordList
    {
        public List<string[]> Term;
        public List<string[]> Meaning;
    }
    private WordList wl;
    private QuizScript quizScr;
    
    public void Initiate()
    {
        ChooseWordList();
        
        CheckListsEqual();
        DisplayList();

        quizScr = new QuizScript();
        AssignAnsweringList();
        
        
        
    }

    private void ChooseWordList()
    {
        Console.Write("Enter the name of the list: ");
        wl = JsonConvert.DeserializeObject<WordList>(File.ReadAllText(Script.wordListDirectory + Console.ReadLine() + ".json"));
    }
    
    private void CheckListsEqual()
    {
        if (wl.Term.Count != wl.Meaning.Count)
        {
            Console.WriteLine("The number of terms doesn't match the number of meanings!");
            
            int diff = Math.Max(wl.Term.Count, wl.Meaning.Count) - Math.Min(wl.Term.Count, wl.Meaning.Count);
            
            if (wl.Term.Count > wl.Meaning.Count)
            {
                Console.Write("Terms removed: ");
                wl.Term = RemoveWords(wl.Term, diff);
            }
            else
            {
                Console.Write("Meanings removed: ");
                wl.Meaning = RemoveWords(wl.Meaning, diff);
            }

            Console.WriteLine();
        }
        
    }
    private List<string[]> RemoveWords(List<string[]> list, int diff)
    {
        for (int i = 0; i < diff; i++)
        {
            Console.Write(list[list.Count - 1][0] + " ");
                    
            list.RemoveAt(list.Count - 1);
        }

        return list;
    }

    private void AssignAnsweringList()
    {
        Console.WriteLine("What do you what to answer with?\n('term' or 'meaning')");
        string answer = Console.ReadLine();

        if (answer.ToLower().Equals("term"))
        {
            quizScr.shownWords = wl.Meaning;
            quizScr.answerWords = wl.Term;
        }
        else if (answer.ToLower().Equals("meaning"))
        {
            quizScr.shownWords = wl.Term;
            quizScr.answerWords = wl.Meaning;
        }
        else
        {
            AssignAnsweringList();
        }

    }
    
    
    private void DisplayList()
    {
        Console.WriteLine("List:");
        
        for (int i = 0; i < wl.Term.Count; i++)
        {
            for (int j = 0; j < wl.Term[i].Length; j++)
            {
                Console.Write(wl.Term[i][j] + " ");
            }
            
            Console.Write("- ");
            
            for (int j = 0; j < wl.Meaning[i].Length; j++)
            {
                Console.Write(wl.Meaning[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    
}