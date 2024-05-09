using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIListaTarefas.Data.Entity
{
    public class Datas
    {
        public int id {get;set;}
        public List<Tasks> listTask {get;set;}
        public DateTime datatask {get;set;}
        public DateTime horatask {get;set;}    
    }
}