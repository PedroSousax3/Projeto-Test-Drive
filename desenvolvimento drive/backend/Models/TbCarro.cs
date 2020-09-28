using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_carro")]
    public partial class TbCarro
    {
        public TbCarro()
        {
            TbAgendamento = new HashSet<TbAgendamento>();
        }

        [Key]
        [Column("id_carro")]
        public int IdCarro { get; set; }
        [Required]
        [Column("tp_carro", TypeName = "varchar(60)")]
        public string TpCarro { get; set; }
        [Column("bt_usado")]
        public bool BtUsado { get; set; }
        [Required]
        [Column("nm_marca", TypeName = "varchar(60)")]
        public string NmMarca { get; set; }
        [Column("nm_modelo", TypeName = "varchar(60)")]
        public string NmModelo { get; set; }
        [Column("dt_fabricao", TypeName = "date")]
        public DateTime? DtFabricao { get; set; }
        [Column("dt_modelo", TypeName = "date")]
        public DateTime DtModelo { get; set; }
        [Column("nr_km")]
        public int? NrKm { get; set; }
        [Column("ds_cor", TypeName = "varchar(50)")]
        public string DsCor { get; set; }
        [Column("bt_arcondicionado")]
        public bool? BtArcondicionado { get; set; }
        [Column("ds_carro", TypeName = "varchar(300)")]
        public string DsCarro { get; set; }
        [Column("vl_preco", TypeName = "decimal(10,0)")]
        public decimal VlPreco { get; set; }
        [Column("dt_publicacao", TypeName = "datetime")]
        public DateTime DtPublicacao { get; set; }

        [InverseProperty("IdCarroNavigation")]
        public virtual ICollection<TbAgendamento> TbAgendamento { get; set; }
    }
}
