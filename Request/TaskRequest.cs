using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIListaTarefas.Data.Entity;

namespace WebAPIListaTarefas.Request
{
    public class TaskRequest
    {
        public String title {get;set;}
        public List<ListTask> descriptionTask {get;set;}
    }
}