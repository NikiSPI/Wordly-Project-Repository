using System;
using System.Collections.Generic;

public class QuizScript
{
    public List<string[]> shownWords;
    public List<string[]> answerWords;

    private Random rand = new Random();
    
    public void StartQuiz()
    {
        while (true)
        {
            int currentPos = rand.Next(0, shownWords.Count);

            DisplayArray(shownWords[currentPos]);
            Console.Write(" - ");

            string answer = Console.ReadLine();
            
            for (int i = 0; i < answerWords[currentPos].Length; i++)
            {
                if (answerWords[currentPos][i].Equals(answer))
                {
                    answerWords.RemoveAt(currentPos);
                    
                    Console.WriteLine("Correct!");
                    break;
                }
            }

            if (shownWords.Count == answerWords.Count)
            {
                Console.WriteLine("Incorrect!\nThe correct word is ");
                DisplayArray(answerWords[currentPos]);
            }
            else
            {
                shownWords.RemoveAt(currentPos);
            }

            if(shownWords.Count <=  0)
            {
                Console.WriteLine("You went through all words!\n");
                break;
            }     
        }
    }

    private void DisplayArray(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (i != 0)
            {
                Console.Write(", ");
            }
            Console.Write(words[i]);
        }
    }

    private void EndCheck()
    {
        
    }
        
}