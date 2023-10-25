using System.Collections.Generic;

namespace Libreria_Workflow
{
    public class Workflow
    {
        private List<IWorkflowActivity> listOfActivities = new List<IWorkflowActivity>();

        public void AddActivities(IWorkflowActivity[] activity)
        {
            listOfActivities.AddRange(activity);
        }

        public List<IWorkflowActivity> GetList()
        {
            return this.listOfActivities;
        }
    }
}