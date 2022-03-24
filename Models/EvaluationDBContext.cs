using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace gestioncompte.Models
{
    public partial class EvaluationDBContext : DbContext
    {


        public EvaluationDBContext(DbContextOptions<EvaluationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employe> Employes { get; set; }

    }
}