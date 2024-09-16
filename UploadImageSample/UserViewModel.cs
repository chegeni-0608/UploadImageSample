using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadImageSample
{
     public  class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoName { get; set; }
        public byte[] PhotoFileFromName { get; set; }
        public byte[] PhotoContent { get; set; }    
    }
}
