using Newtonsoft.Json;
using System.Diagnostics;

public class Frame : Form
{
    StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
    
    private class WordList
    {
        public string[] English;
        public string[] EBulgarian;
        public string[] Deutsch;
        public string[] DBulgarian;
    }
    
    public Frame()
    {
        Text = " Word Tester";
        Icon = Icon.ExtractAssociatedIcon(Path.GetDirectoryName(stackFrame.GetFileName()) + "\\Images\\WordTester.ico");
        ClientSize = new Size(500, 500);
        StartPosition = FormStartPosition.CenterScreen;

        string jsonFile =
            File.ReadAllText(Path.GetDirectoryName(stackFrame.GetFileName()) + @"\Word Lists\Word List.json");

        WordList deserialized = JsonConvert.DeserializeObject<WordList>(jsonFile);

        string visualize = "";
        for (int i = 0; i < deserialized.English.Length; i++)
        {
            visualize += deserialized.English[i] + " - ";
            visualize += deserialized.EBulgarian[i] + "     ";
            visualize += deserialized.Deutsch[i] + " - ";
            visualize += deserialized.DBulgarian[i] + "\n";
        }
        
        Label label = new Label();
        label.Text = visualize;
        label.BackColor = Color.Bisque;
        label.Location = new Point(25, 25);
        label.Size = new Size(450, 450);
        
        Controls.Add(label);
    }
    
}

static class Program
{
    static void Main()
    {
        Application.Run(new Frame());
    }
}