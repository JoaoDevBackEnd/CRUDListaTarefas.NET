using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebAPIListaTarefas.Data.Enum;

namespace WebAPIListaTarefas.Data.Entity
{
    public class ListTask
    {
        public int id {get;set;}
        public int taskId {get;set;}
        public Status status{get;set;}
        [Required]
        public string descriptionTask{get;set;}
    }
}