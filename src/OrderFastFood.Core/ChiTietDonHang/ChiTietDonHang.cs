using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFastFood.ChiTietDonHang
{
    [Table("ChiTietDonHang")]
    public class ChiTietDonHang:Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdChiTietDonHang { get; set; }

        [Required]
        public int IdDatHang { get; set; }

        [Required]
        public int IdSanPham { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        public double GiaSanPham { get; set; }
    }
}
