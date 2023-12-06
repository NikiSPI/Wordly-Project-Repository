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

            for (int i = 0; i < shownWords[currentPos].Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                
                Console.Write(shownWords[currentPos][i]);
            }
            Console.Write(" - ");

            string answer = Console.ReadLine();
            
            for (int i = 0; i < shownWords[currentPos].Length; i++)
            {
                if (shownWords[currentPos][i].Equals(answer))
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }

        }
    }
        
}