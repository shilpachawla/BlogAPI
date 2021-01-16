using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace BlogApplication.ViewModel
{
    public class BlogDetailViewModel
    {
        
        public Guid BlogId { get; set; }

        public string BlogContent { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public DateTime CreatedDate { get; set; }

        public string BlogTopic { get; set; }
    }
}
