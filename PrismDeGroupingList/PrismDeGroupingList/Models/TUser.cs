using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDeGroupingList.Models
{
    public class TUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Kana { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }

        public int Age
        {
            get { return (DateTime.Today.Year - Birthday.Year) - (Birthday.DayOfYear > DateTime.Today.DayOfYear ? 1 : 0); }
        }


    }
}
