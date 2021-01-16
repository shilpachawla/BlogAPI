using System;
using System.Collections.Generic;

#nullable disable

namespace BlogApplication.Models
{
    public partial class BlogDetail
    {
        public Guid BlogId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string BlogContent { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string BlogTopic { get; set; }
    }
}
