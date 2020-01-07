using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.BusinessLayer
{
    public class Session
    {
        public int ID { get; set; }
        public Course Course { get; set; }
        public Local Local { get; set; }
        public User Teacher{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User Attendee { get; set; }

    }
}
