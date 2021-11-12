using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFastFood.SanPham
{
    [Table("SanPham")]
    public class SanPham:Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSanPham { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        [Required]
        public double GiaSanPham { get; set; }

        [Required]
        public int SoLuong { get; set; }

        public string NgayTao { get; set; }

        public int TrangThai { get; set; }

        public int TopHot { get; set; }

        public string AnhSanPham { get; set; }

        public int IdNhomSanPham { get; set; }
    }
}
