using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using WebAPIListaTarefas.Data.Database;
using WebAPIListaTarefas.Data.Entity;

namespace WebAPIListaTarefas.Services
{
    public class UserServices
    {
        public DataContext _db;
        public UserServices(IConfiguration configuration){
            _db=new DataContext(configuration);
        }

        //public async Task<Users> userId() => await _db.GetAll();
        public Users userId(int id){
              var account = _db.UsersEntity.FirstOrDefault(x=> x.id ==id);
              if(account==null){
                    throw new Exception("Usuário não encontrado");
                 }
                return account;
        }
     }
}