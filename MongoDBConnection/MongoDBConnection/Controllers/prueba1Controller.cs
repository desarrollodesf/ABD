using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDBConnection.Models;

namespace MongoDBConnection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class prueba1Controller : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public prueba1Controller(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        [HttpGet]
        public JsonResult Get()
        {
            //var settings = MongoClientSettings.FromConnectionString("mongodb+srv://User1:Lisa2015#@cluster0.53plr.mongodb.net/prueba?retryWrites=true&w=majority");
            //var client = new MongoClient(settings);
            //var database = client.GetDatabase("prueba");
            //var collection = database.GetCollection<Models.prueba1>("prueba1");
            //var asquerybale = collection.AsQueryable();

            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("Taller1"));
            var dbList = dbClient.GetDatabase("prueba").GetCollection<prueba1>("prueba1").AsQueryable();
            return new JsonResult(dbList);
        }
    }
}
