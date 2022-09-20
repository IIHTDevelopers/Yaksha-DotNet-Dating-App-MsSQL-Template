using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.ViewModels
{
    public class DislikeViewModel
    {
        public long DislikeId { get; set; }

        public long UserId { get; set; }
      
        public bool IsDeleted { get; set; }
    }
}
