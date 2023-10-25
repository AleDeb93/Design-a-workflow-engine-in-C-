using System;
using System.IO;
using Libreria_Workflow;

namespace Attività
{
    public class FileActivity : IWorkflowActivity
    {
        private readonly string _path;

        public FileActivity(string path)
        {
            _path = path;
        }
        
        public void Execute()
        {
            try
            {
                if (File.Exists(_path))
                    using (var streamWriter = new StreamWriter(_path, true))
                    {
                        streamWriter.WriteLine("Ho scritto sul File con FileActivity");
                    }
                else
                    using (var streamWriter = File.CreateText(_path))
                    {
                        streamWriter.WriteLine("Ho scritto sul file con FileActivity");
                    }
            }
            catch
            {
                throw new Exception($"Non è stato possibile completare l'esecuzione del comando:\n{this.ToString()}");
            }
        }
    }
}