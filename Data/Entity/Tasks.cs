using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAPIListaTarefas.Data.Enum;

namespace WebAPIListaTarefas.Data.Entity
{
    
    public class Tasks
    {
        public int id {get;set;}
        public int userId{get;set;}
        public string titile{get;set;}
        public  Status status{get;set;}
        public List<Tasks> taskDescription {get;set;}
    }
}