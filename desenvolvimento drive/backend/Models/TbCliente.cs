using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_cliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbAgendamento = new HashSet<TbAgendamento>();
            TbLogin = new HashSet<TbLogin>();
        }

        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nm_cliente", TypeName = "varchar(100)")]
        public string NmCliente { get; set; }
        [Required]
        [Column("ds_cnh", TypeName = "varchar(20)")]
        public string DsCnh { get; set; }
        [Column("ds_cpf", TypeName = "varchar(20)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(150)")]
        public string DsEmail { get; set; }
        [Column("ds_celular", TypeName = "varchar(20)")]
        public string DsCelular { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Column("ds_rg", TypeName = "varchar(20)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(70)")]
        public string DsEndereco { get; set; }
        [Column("nr_numero")]
        public int NrNumero { get; set; }
        [Column("ds_cep", TypeName = "varchar(12)")]
        public string DsCep { get; set; }
        [Column("ds_complemento", TypeName = "varchar(20)")]
        public string DsComplemento { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbAgendamento> TbAgendamento { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbLogin> TbLogin { get; set; }
    }
}
