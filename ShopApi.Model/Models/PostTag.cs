using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopApi.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int TagID { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}
