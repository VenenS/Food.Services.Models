using System;
using System.Collections.Generic;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class TagModel
    {
        public Int64 Id { get; set; }
        
        public Int64? ParentId { get; set; }
        
        public string Name { get; set; }
        
        public bool? IsActive { get; set; }
        
        public DateTime? CreateDate { get; set; }
        
        public Int64? CreatorId { get; set; }
        
        public DateTime? LastUpdDate { get; set; }
        
        public Int64? LastUpdateByUserId { get; set; }

        public List<TagModel> Children { get; set; }

        public TagModel Parent { get; set; }

        public bool HasChildren { get { return Children == null ? false : Children.Count > 0; } }

        public bool IsSelected { get; set; }
    }
}
