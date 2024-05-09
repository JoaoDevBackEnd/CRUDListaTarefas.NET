using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIListaTarefas.Data.Entity
{
    [Table("users")]
    public class Users
    {
        public int id {get; set;}
        public string name {get;set;}
        public string password {get; set;}

    }
}