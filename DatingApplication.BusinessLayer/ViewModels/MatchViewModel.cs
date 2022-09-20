using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.ViewModels
{
    public class MatchViewModel
    {
        public long MatchId { get; set; }
        public long UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
