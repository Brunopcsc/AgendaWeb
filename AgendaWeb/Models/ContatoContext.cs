using System;
using System.Collections.Generic;
using Npgsql;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendaWeb.Models
{
    public class ContatoContext: DbContext
    {
        public ContatoContext() : base("DbContatos")
        {
        }

        public DbSet<Contato> contatos { get; set; }
    }
}