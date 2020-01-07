using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.TransferObject
{
    public class SessionTO
    {
        public int ID { get; set; }
        public string Local { get; set; }
        public UserTO TeacherName { get; set; }

    }
}
