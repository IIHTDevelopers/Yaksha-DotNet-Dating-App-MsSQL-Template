using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.ViewModels
{
    public class LikeViewModel
    {
        public long LikeId { get; set; }
        public long UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
