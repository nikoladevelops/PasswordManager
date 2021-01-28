using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class AccountItemModel
    {
        public int Id { get; set; }
        public string ImagePassword { get; set; }
        public byte[] Image { get; set; }
        public int AccountId { get; set; }
    }
}
