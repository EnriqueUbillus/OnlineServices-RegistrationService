using System;
using System.Collections.Generic;
using System.Text;
using UserServices.Shared.TransferObject;

namespace UserServices.BusinessLayer.Extensions
{
    public static class CourseExtensions
    {
        public static Course ToDoamin(this CourseTO courseTO)
        {
            return new Course
            {
                ID = courseTO.ID,
                Name = courseTO.Name,
            };
        }

        public  static CourseTO ToTransferObject(this Course course)
        {
            return new CourseTO
            {
                ID = course.ID,
                Name = course.Name,
            };
        }
    }
}
