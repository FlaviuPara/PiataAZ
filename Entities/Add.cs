using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Net.Mime;

namespace Entities
{
    public class Add
    {
        public String id { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public Image photo { get; set; }
        public String username { get; set; }

        public Add(String id, String title, String description, Image photo, String username)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.photo = photo;
            this.username = username;
        }
    }
}
