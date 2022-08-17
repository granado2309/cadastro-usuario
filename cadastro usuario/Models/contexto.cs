using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace cadastro_usuario.Models
{
    public class context: DbContext
    {
        public DbSet<pessoa> Pessoas { get; set; }
    }
}