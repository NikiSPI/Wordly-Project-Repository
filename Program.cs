
using System.Diagnostics;

public class Frame : Form
{
    StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
    
    public Frame()
    {

        Text = " Word Tester";
        Icon = Icon.ExtractAssociatedIcon(Path.GetDirectoryName(stackFrame.GetFileName()) + "\\Images\\WordTester.ico");
        ClientSize = new Size(300, 300);

    }
    
}

static class Program
{
    static void Main()
    {
        Application.Run(new Frame());
    }
}