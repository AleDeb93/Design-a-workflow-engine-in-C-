using System;

namespace Libreria_Workflow
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            var activitiesToRun = workflow.GetList();
            if (activitiesToRun.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                throw new Exception($"NON CI SONO ATTIVITA NEL WORKFLOW SELEZIONATO {workflow}");
            }

            foreach (var activity in activitiesToRun)
            {
                activity.Execute();
            }
        }
    }
}