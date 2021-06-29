using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Questionario
{
    public class Respostas
    {
        [Key()]
        public int Id { get; set; }

        [ForeignKey("FaixaEtaria")]
        public int FaixaEtariaId { get; set; }
        public virtual FaixaEtaria FaixaEtaria { get; set; }

        [ForeignKey("Convenio")]
        public int ConvenioId { get; set; }
        public virtual Convenio Convenio { get; set; }

        [ForeignKey("FaixaSalarial")]
        public int FaixaSalarialId { get; set; }
        public virtual FaixaSalarial FaixaSalarial { get; set; }

        [ForeignKey("MotivoEmprestimo")]
        public int MotivoEmprestimoId { get; set; }
        public virtual MotivoEmprestimo MotivoEmprestimo { get; set; }
    }
}
