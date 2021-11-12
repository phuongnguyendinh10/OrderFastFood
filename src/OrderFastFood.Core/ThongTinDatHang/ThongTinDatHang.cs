using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFastFood.ThongTinDatHang
{
    [Table("ThongTinDatHang")]
    public class ThongTinDatHang:Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDatHang { get; set; }

        public int CachThucThanhToan { get; set; }
        public string NgayTao { get; set; }
        public int TrangThai { get; set; }
        public int IdUser { get; set; }
    }
}
