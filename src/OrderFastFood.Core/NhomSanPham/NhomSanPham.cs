using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFastFood.NhomSanPham
{
    
    [Table("NhomSanPham")]
    public class NhomSanPham:Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNhomSanPham { get; set; }

        [StringLength(50)]
        public string TenNhomSanPham { get; set; }

        public int TrangThai { get; set; }

        [StringLength(1000)]
        public string AnhNhomSanPham { get; set; }
    }
}
