using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.ViewModels
{
    public class InterestViewModel
    {
        public long InterestId { get; set; }
 
        public string InterestedIn { get; set; }
       
        public string NotInterestedIn { get; set; }
     
        public string Hobbies { get; set; }
       
        public string ProfileUrl { get; set; }
       
        public string About { get; set; }
      
        public long UserId { get; set; }
       
        public bool IsDeleted { get; set; }
    }
}
