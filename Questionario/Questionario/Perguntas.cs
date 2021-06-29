using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Questionario
{
    [Table("FaixaEtaria")]
    public class FaixaEtaria
    {
        [Key()]
        public int Id { get; set; }

        [Column("Descricao")]
        public string Descricao { get; set; }
    }

    [Table("Convenio")]
    public class Convenio
    {
        [Key()]
        public int Id { get; set; }

        [Column("Descricao")]
        public string Descricao { get; set; }
    }

    [Table("FaixaSalarial")]
    public class FaixaSalarial
    {
        [Key()]
        public int Id { get; set; }

        [Column("Descricao")]
        public string Descricao { get; set; }
    }

    [Table("MotivoEmprestimo")]
    public class MotivoEmprestimo
    {
        [Key()]
        public int Id { get; set; }

        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}