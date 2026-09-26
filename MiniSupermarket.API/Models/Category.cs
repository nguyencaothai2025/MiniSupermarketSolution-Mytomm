/*
 *  họ tên: Nguyễn Văn Tommy
 *  masv: 123456789
 *  mô tả: Lớp Category đại diện cho nhóm hàng hóa trong siêu thị mini, bao gồm các thuộc tính như mã định danh, tên nhóm hàng và mô tả chi tiết.
 *  ngày tạo: 2024-06-15
 *  ngày đâu tiên thực hành
 */
namespace MiniSupermarket.API.Models
{
    // Lớp biểu diễn thực thể Nhóm hàng hóa trong siêu thị mini
    public class Category
    {
        // Mã định danh nhóm hàng (Khóa chính)
        public int CategoryId { get; set; }

        // Tên nhóm hàng (Bắt buộc, không được để trống)
        public string CategoryName { get; set; } = string.Empty;

        // Mô tả chi tiết về nhóm hàng (Có thể để trống)
        public string? Description { get; set; }
    }
}
