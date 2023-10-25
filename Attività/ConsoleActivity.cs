using System;
using Libreria_Workflow;

namespace Attività
{
    public class ConsoleActivity : IWorkflowActivity
    {
        public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ho scritto sulla Concole con ConsoleActivity");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}