﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentEmail { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentTime { get; set; }

        //Blog ile ilişkisi daha sonra kurulacaktır...
    }
}
