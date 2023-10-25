using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attività;
using Libreria_Workflow;

namespace Design_a_Workflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomeUtente = "yourUserName"; 

            var workflow = new Workflow();
            workflow.AddActivities(new IWorkflowActivity[] {new ConsoleActivity(), new FileActivity($"C:\\Users\\{nomeUtente}\\file.txt")}); 
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
