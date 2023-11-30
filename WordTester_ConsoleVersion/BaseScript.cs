

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
        
        InitiateScript();
    }

    private void InitiateMainFunction()
    {
        
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