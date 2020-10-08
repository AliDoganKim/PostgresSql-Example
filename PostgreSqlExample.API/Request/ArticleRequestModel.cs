using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSqlExample.API.Request
{
    /// <summary>
    /// Controller tarafında gelen requesti karşılayacak model.
    /// </summary>
    public class ArticleRequestModel
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}