using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class AccountItemsModel
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int AccountId { get; set; }
    }
}
