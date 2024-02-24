using System.ComponentModel.DataAnnotations;

namespace ShopApi.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyWord { get; set; }
        [MaxLength(256)]
        public string MetaDesc { get; set; }
        public bool Status { get; set; }
    }
}
