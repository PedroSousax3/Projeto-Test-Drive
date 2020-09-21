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
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("nm_cliente", TypeName = "varchar(150)")]
        public string NmCliente { get; set; }
        [Column("ds_cnh", TypeName = "varchar(150)")]
        public string DsCnh { get; set; }
        [Column("ds_cpf", TypeName = "varchar(150)")]
        public string DsCpf { get; set; }
        [Column("dt_data", TypeName = "date")]
        public DateTime? DtData { get; set; }
        [Column("nm_endereço", TypeName = "varchar(150)")]
        public string NmEndereço { get; set; }
        [Column("ds_rg", TypeName = "varchar(150)")]
        public string DsRg { get; set; }
        [Column("ds_numero", TypeName = "varchar(150)")]
        public string DsNumero { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbAgendamento> TbAgendamento { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbLogin> TbLogin { get; set; }
    }
}
