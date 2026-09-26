/*
 *  họ tên: Nguyễn Văn Tommy
 *  masv: 123456789
 *  mô tả: Lớp Product đại diện cho sản phẩm trong siêu thị mini, bao gồm các thuộc tính như ....
 *  ngày tạo: 2024-06-15
 */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniSupermarket.API.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Mã vạch sản phẩm không được trống")]
        [StringLength(50)]
        public string Barcode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(150)]
        public string ProductName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } // Giá bán

        public int StockQuantity { get; set; } // Số lượng tồn kho

        // Khóa ngoại liên kết tới bảng Categories
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
