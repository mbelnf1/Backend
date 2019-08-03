using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public class Meeting
    {
        public List<Person> PeopleMetWith { get; set; }
        public DateTime MeetingStartTime { get; set; }

        public DateTime MeetingEndTime { get; set; }

        public string MeetingNotes { get; set; }

        public string Title { get; set; }

        public Meeting()
        {
            PeopleMetWith = new List<Person>();
        }
    }
}
