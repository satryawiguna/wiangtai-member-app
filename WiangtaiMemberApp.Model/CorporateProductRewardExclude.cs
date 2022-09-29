using System;
namespace WiangtaiMemberApp.Model
{
    public class CorporateProductRewardExclude
    {
        public Guid ProductRewardID { get; set; }
        public Guid ProductVariantID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }
        public virtual CorporateProductReward CorporateProductReward { get; set; }
    }
}

