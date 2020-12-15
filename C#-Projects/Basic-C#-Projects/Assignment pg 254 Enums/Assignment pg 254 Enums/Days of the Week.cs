using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg_254_Enums
{
    class Days_of_the_Week
    {

        public static Day ParseEnum<Day>(string value)
        {
            return (Day)Enum.Parse(typeof(Day), value, ignoreCase: true);
        }
    }
    
    public enum daysOfTheWeek
    {
        sunday,
        monday,
        tuesday,
        wedensday,
        thrusday,
        friday,
        saturday
    }
}
