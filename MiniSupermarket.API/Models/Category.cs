/*
 *  họ tên: Nguyễn Văn Tommy
 *  masv: 123456789
 *  mô tả: Lớp Category đại diện cho nhóm hàng hóa trong siêu thị mini, bao gồm các thuộc tính như mã định danh, tên nhóm hàng và mô tả chi tiết.
 *  ngày tạo: 2024-06-15
 */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MiniSupermarket.API.Models
{
    [Table("Categories")] // Đặt tên bảng rõ ràng trong SQL Server
    public class Category
    {
        [Key] // Khóa chính
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng (Identity 1,1)
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên nhóm hàng không được để trống!")]
        [StringLength(100, ErrorMessage = "Tên nhóm hàng không vượt quá 100 ký tự")]
        public string CategoryName { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Description { get; set; }

        // Quan hệ 1 - N: Một danh mục có nhiều sản phẩm
        [JsonIgnore] // Tránh lỗi lặp vòng vô tận khi serialize JSON
        public virtual ICollection<Product>? Products { get; set; }
    }
}
