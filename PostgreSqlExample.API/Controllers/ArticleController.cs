using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostgreSqlExample.API.Request;
using PostgreSqlExample.Data;
using PostgreSqlExample.Data.Entities;

namespace PostgreSqlExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        /// <summary>
        /// Oluşturmuş olduğumuz context. Controller tarafında direkt bu şekilde context kullanımı ve data katmanını direkt presentation kısmına açmak yanlış!!
        /// </summary>
        private readonly PostgreSqlExampleDbContext _postgreSqlExampleDbContext;

        public ArticleController(PostgreSqlExampleDbContext postgreSqlExampleDbContext)
        {
            _postgreSqlExampleDbContext = postgreSqlExampleDbContext;
        }

        /// <summary>
        /// HttpPost olarak çalışır. Body'den verileri okur. Ve Article tablosuna kayıt yazar.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add([FromBody] ArticleRequestModel request)
        {
            _postgreSqlExampleDbContext.Add(new Article { Title = request.Title, Description = request.Description });
            _postgreSqlExampleDbContext.SaveChanges();
            return Ok("Başarılı");
        }
    }
}