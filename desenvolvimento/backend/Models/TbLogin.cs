using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_login")]
    public partial class TbLogin
    {
        [Key]
        [Column("id_login", TypeName = "int(11)")]
        public int IdLogin { get; set; }
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("ds_email", TypeName = "varchar(150)")]
        public string DsEmail { get; set; }
        [Column("ds_senha", TypeName = "varchar(150)")]
        public string DsSenha { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbLogin))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbLogin))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
    }
}
