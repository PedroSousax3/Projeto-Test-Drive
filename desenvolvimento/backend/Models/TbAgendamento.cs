using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_agendamento")]
    public partial class TbAgendamento
    {
        [Key]
        [Column("id_agendamento", TypeName = "int(11)")]
        public int IdAgendamento { get; set; }
        [Column("id_carro", TypeName = "int(11)")]
        public int IdCarro { get; set; }
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }
        [Column("dt_agendamento", TypeName = "date")]
        public DateTime DtAgendamento { get; set; }
        [Column("hr_inicio", TypeName = "time")]
        public TimeSpan HrInicio { get; set; }
        [Column("hr_fim", TypeName = "time")]
        public TimeSpan HrFim { get; set; }
        [Column("ds_status", TypeName = "varchar(50)")]
        public string DsStatus { get; set; }
        [Column("ds_agendamento", TypeName = "varchar(200)")]
        public string DsAgendamento { get; set; }

        [ForeignKey(nameof(IdCarro))]
        [InverseProperty(nameof(TbCarro.TbAgendamento))]
        public virtual TbCarro IdCarroNavigation { get; set; }
        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbAgendamento))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbAgendamento))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
    }
}
