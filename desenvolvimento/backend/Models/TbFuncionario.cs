using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        public TbFuncionario()
        {
            TbAgendamento = new HashSet<TbAgendamento>();
            TbLogin = new HashSet<TbLogin>();
        }

        [Key]
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }
        [Column("nm_funcionario", TypeName = "int(11)")]
        public int? NmFuncionario { get; set; }
        [Column("ds_cnh", TypeName = "varchar(30)")]
        public string DsCnh { get; set; }
        [Column("ds_cpf", TypeName = "varchar(30)")]
        public string DsCpf { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime? DtNascimento { get; set; }
        [Column("nm_endereço", TypeName = "varchar(100)")]
        public string NmEndereço { get; set; }
        [Column("ds_rg", TypeName = "varchar(45)")]
        public string DsRg { get; set; }
        [Column("ds_numero", TypeName = "varchar(45)")]
        public string DsNumero { get; set; }
        [Column("nm_cargo", TypeName = "varchar(45)")]
        public string NmCargo { get; set; }

        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbAgendamento> TbAgendamento { get; set; }
        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbLogin> TbLogin { get; set; }
    }
}
