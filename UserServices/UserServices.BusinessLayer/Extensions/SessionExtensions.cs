using System;
using System.Collections.Generic;
using System.Text;
using UserServices.Shared.TransferObject;
using System.Linq;

namespace UserServices.BusinessLayer.Extensions
{
    public static class SessionExtensions
    {
        public static Session ToDomain(this SessionTO sessionTO)
        {
            return new Session 
            {
                ID = sessionTO.ID,
                Course = sessionTO.Course.ToDoamin(), 
                Teacher = sessionTO.TeacherName.ToDomain(), 
                Attendee = sessionTO.Attendee.ToDomain(),
            };
        }

        public static SessionTO ToTransferObject(this Session session)
        {
            return new SessionTO
            {
                ID = session.ID,
                Course = session.Course.ToTransferObject(),
                //Local = session.Local
                TeacherName  = session.Teacher.ToTransferObject(),
                Attendee = session.Attendee.ToTransferObject(),
            };
        }
    }
}
