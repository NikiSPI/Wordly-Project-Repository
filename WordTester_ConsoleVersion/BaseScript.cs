

using System;
using System.Diagnostics;
using System.IO;
using System.Net;

class Script
{
    private static StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
    public static string wordListDirectory = Path.GetDirectoryName(stackFrame.GetFileName()) + @"\Word Lists\";
    
    public void InitiateScript()
    {
        
        Console.Write("'a' to create new word list\n's' to start\n'e' to exit\n - ");

        switch (Console.ReadLine())
        {
            case "a": 
                InitiateWordList();
                break;
            
            case "s": 
                InitiateMainFunction();
                InitiateScript();
                break;
            
            case "e" :
                Environment.Exit(0);
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
        
        InitiateScript();
    }

    private void InitiateMainFunction()
    {
        SetUpQuiz quiz = new SetUpQuiz();
        quiz.Initiate();
    }

}



class BaseScript
{
    public static void Main(string[] args)
    {

        Script script = new Script();
        script.InitiateScript();
        
    }
}