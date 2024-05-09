using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WebAPIListaTarefas.Data.Database;
using WebAPIListaTarefas.Data.Entity;
using WebAPIListaTarefas.Request;
using WebAPIListaTarefas.Services;

namespace WebAPIListaTarefas.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext _db;
        public UserServices userServices;
        public UsersController(IConfiguration configuration){
            _db= new DataContext(configuration);
            userServices = new UserServices(configuration);
        }
        [HttpPost]
        [Route("createAccount")]
          public IActionResult Post([FromQuery] AccountRequest account){
                var user = new Users();
                user.name=account.nome;
                user.password=account.password;
                _db.Add(user);
                _db.SaveChanges();
                return Ok();
        }
        [HttpGet]
        [Route("Login")]
        public IActionResult Get(int id){
            var account = userServices.userId(id);
           return Ok(account);
        }
        

    }
   
  
}