using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFastFood.BaiViet
{
    [Table("BaiViet")]
    public class BaiViet:Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBaiViet { get; set; }

        [Required]
        [StringLength(1000)]
        public string TieuDeBaiViet { get; set; }

        [Required]
        [MaxLength]
        public string NoiDungHienThi { get; set; }

        public string NgayTao { get; set; }

        public string AnhBaiViet { get; set; }

        public int IdUser { get; set; }

    }
}
