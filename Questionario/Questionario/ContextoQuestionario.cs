using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionario
{
    public class ContextoQuestionario : DbContext
    {
        public ContextoQuestionario(DbContextOptions<ContextoQuestionario> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FaixaEtaria> FaixaEtarias { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<FaixaSalarial> FaixaSalariais { get; set; }
        public DbSet<MotivoEmprestimo> MotivosEmprestimo { get; set; }

        public DbSet<Respostas> Respostas { get; set; }

    }
}
